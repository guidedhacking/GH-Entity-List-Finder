using Squalr.Engine;
using Squalr.Engine.DataTypes;
using Squalr.Engine.Memory;
using Squalr.Engine.OS;
using Squalr.Engine.Projects.Items;
using Squalr.Engine.Scanning.Scanners;
using Squalr.Engine.Scanning.Scanners.Constraints;
using Squalr.Engine.Scanning.Snapshots;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace EntityListFinder
{
    internal class EntityListFinder
    {
        private readonly MainForm appForm;

        private List<List<Int64>> scannedAddresses;
        private List<Int64> possibleEntityList;
        private List<Int64> addressesToFind;
        private List<Int64> validatingEntityList;

        private DataType dataType;

        public EntityListFinder(MainForm form)
        {
            appForm = form;

            scannedAddresses = new List<List<Int64>>();
            possibleEntityList = new List<Int64>();
            addressesToFind = new List<Int64>();
            validatingEntityList = new List<Int64>();
        }

        public void AttachButton()
        {
            string processName = appForm.processName;
            Process[] gameProcess = Process.GetProcessesByName(processName);

            if (gameProcess.Length > 0)
            {
                Processes.Default.OpenedProcess = gameProcess[0];
                dataType = (appForm.IsWin64Emulator(gameProcess[0])) ? DataType.Int32 : DataType.Int64;
                appForm.LoadProcess(gameProcess[0].ProcessName, gameProcess[0].Id, dataType);
            }
            else
            {
                MessageBox.Show("Process " + processName + " couldn't be found.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SearchButton()
        {
            scannedAddresses.Clear();
            possibleEntityList.Clear();
            appForm.possibleEntityListTextBox.Clear();

            SnapshotManager.ClearSnapshots();

            if (addressesToFind.Count == 0)
            {
                TextBox addressesToFindTextBox = appForm.addressesToFindTextBox;
                for (int i = 0; i < addressesToFindTextBox.Lines.Length; ++i)
                {
                    addressesToFind.Add(Int64.Parse(addressesToFindTextBox.Lines[i], NumberStyles.HexNumber, CultureInfo.CurrentCulture));
                }
            }

            StartScan(0, addressesToFind[0]);
        }

        private void StartScan(int index, Int64 searchAddress, bool validatingProcess = false)
        {
            if (index > 0)
            {
                SnapshotManager.ClearSnapshots();
            }

            ConstraintNode scanConstraints = new ScanConstraint(ScanConstraint.ConstraintType.Equal, searchAddress, dataType);

            TrackableTask<Snapshot> valueCollectorTask = ValueCollector.CollectValues(
                SnapshotManager.GetSnapshot(Snapshot.SnapshotRetrievalMode.FromActiveSnapshotOrPrefilter, dataType),
                TrackableTask.UniversalIdentifier);

            valueCollectorTask.OnCompletedEvent += ((completedValueCollectionTask) =>
            {
                Snapshot snapshot = valueCollectorTask.Result;

                TrackableTask<Snapshot> scanTask = ManualScanner.Scan(
                    snapshot,
                    scanConstraints,
                    TrackableTask.UniversalIdentifier);

                SnapshotManager.SaveSnapshot(scanTask.Result);

                snapshot = scanTask.Result;

                scannedAddresses.Add(new List<Int64>());

                if (snapshot != null)
                {
                    for (UInt64 i = 0; i < snapshot.ElementCount; ++i)
                    {
                        SnapshotElementIndexer element = snapshot[i];

                        Object currentValue = element.HasCurrentValue() ? element.LoadCurrentValue() : null;
                        Object previousValue = element.HasPreviousValue() ? element.LoadPreviousValue() : null;

                        String moduleName = String.Empty;
                        UInt64 address = Query.Default.AddressToModule(element.BaseAddress, out moduleName);

                        PointerItem pointerItem = new PointerItem(baseAddress: address, dataType: dataType, moduleName: moduleName, value: currentValue);
                        pointerItem.ForceResolveAddress();

                        scannedAddresses[index].Add(Int64.Parse(pointerItem.AddressSpecifier, NumberStyles.HexNumber, CultureInfo.CurrentCulture));
                    }
                }

                int nextIteration = index + 1;
                if (nextIteration < addressesToFind.Count)
                {
                    StartScan(nextIteration, addressesToFind[nextIteration], validatingProcess);
                }
                else
                {
                    SearchLogic(validatingProcess);
                }
            });
        }

        public void SearchLogic(bool validatingProcess)
        {
            if (scannedAddresses.Count == 0)
            {
                StopSearching(noAddressesFound: true);
                return;
            }

            for (int i = 0; i < scannedAddresses.Count; i++)
            {
                if (scannedAddresses[i].Count == 0)
                {
                    StopSearching(noAddressesFound: true);
                    return;
                }
            }

            int maxBytesBetweenObjects = appForm.MaxBytesBetweenObjects();
            List<Int64> tempGroupedAddresses = new List<Int64>(); // This is to save possible addresses and check how many bytes are between them

            if (scannedAddresses.Count > 1)
            {
                for (int i = 0; i < scannedAddresses[0].Count; i++)
                {
                    int compareIterator = 1;

                    tempGroupedAddresses.Add(scannedAddresses[0][i]);

                    for (int j = 0; j < scannedAddresses[compareIterator].Count; j++)
                    {
                        bool valueInRange = false;
                        for (int k = 0; k < tempGroupedAddresses.Count; k++)
                        {
                            if (IsValueInRange(value1: tempGroupedAddresses[k], value2: scannedAddresses[compareIterator][j], range: maxBytesBetweenObjects))
                            {
                                valueInRange = true;
                                break;
                            }
                        }

                        if (valueInRange)
                        {
                            tempGroupedAddresses.Add(scannedAddresses[compareIterator][j]);
                            tempGroupedAddresses.Sort();

                            if ((compareIterator + 1) == scannedAddresses.Count)
                            { // End of lists
                                appForm.possibleEntityListTextBox.AppendText(tempGroupedAddresses[0].ToString("X") + Environment.NewLine);

                                possibleEntityList.Add(tempGroupedAddresses[0]);
                                validatingEntityList.Add(tempGroupedAddresses[0]);

                                break;
                            }
                            else
                            {
                                scannedAddresses[0][i] = scannedAddresses[compareIterator][j]; // Compare against the new address and not the old one

                                j = -1;
                                ++compareIterator;
                            }
                        }
                    }

                    tempGroupedAddresses.Clear();
                }
            }
            else
            {
                for (int i = 0; i < scannedAddresses[0].Count; ++i)
                {
                    appForm.possibleEntityListTextBox.AppendText(scannedAddresses[0][i].ToString("X") + Environment.NewLine);
                }

                possibleEntityList.AddRange(scannedAddresses[0]);
                validatingEntityList.AddRange(scannedAddresses[0]);
            }

            StopSearching(possibleEntityList.Count == 0, validatingProcess: validatingProcess);
        }

        private bool IsValueInRange(Int64 value1, Int64 value2, int range)
        {
            return (value1 - range) <= value2 && (value1 + range) >= value2;
        }

        public void StopSearching(bool noAddressesFound = false, bool validatingProcess = false)
        {
            if (validatingProcess)
            {
                List<Int64> validatedEntityList = possibleEntityList.Intersect(validatingEntityList).ToList();
                possibleEntityList = validatedEntityList;

                if (validatedEntityList.Count > 0)
                {
                    noAddressesFound = false;
                    appForm.possibleEntityListTextBox.Clear();

                    for (int i = 0; i < validatedEntityList.Count; ++i)
                    {
                        appForm.possibleEntityListTextBox.AppendText(validatedEntityList[i].ToString("X") + Environment.NewLine);
                    }
                }
                else
                {
                    noAddressesFound = true;
                }
            }

            if (noAddressesFound)
            {
                appForm.possibleEntityListTextBox.Text = "No addresses found";
            }

            appForm.GetControlState().Change(ControlState.State.STOP_BUTTON);
        }

        public void SaveButton()
        {
            if (possibleEntityList.Count > 0)
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\possibleEntityList.txt";
                string result = string.Join(Environment.NewLine, possibleEntityList.Select(item => item.ToString("X")).ToArray());

                File.WriteAllText(desktopPath, result);

                MessageBox.Show("Saved to " + desktopPath, "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        public void ValidateButton()
        {
            scannedAddresses.Clear();
            validatingEntityList.Clear();

            SnapshotManager.ClearSnapshots();

            StartScan(index: 0, searchAddress: addressesToFind[0], validatingProcess: true);
        }
    }
}