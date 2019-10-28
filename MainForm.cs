using Squalr.Engine.DataTypes;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace EntityListFinder
{
    public partial class MainForm : Form
    {
        private EntityListFinder entityListFinder;
        private ControlState controlState;

        public string processName = "";

        public MainForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        public int MaxBytesBetweenObjects()
        {
            return int.Parse(marginOffsetTextBox.Text, NumberStyles.HexNumber, CultureInfo.CurrentCulture);
        }

        public ControlState GetControlState()
        {
            return controlState;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            entityListFinder = new EntityListFinder(this);
            controlState = new ControlState(this);

            controlState.Change(ControlState.State.FORM_LOAD);

            LoadToolTips();
            RefreshProcessesList();
        }

        private void LoadToolTips()
        {
            processesListToolTip.SetToolTip(processesList, "Select a process from the list");

            maxBytesToolTip.SetToolTip(maxBytesHelp, string.Format("A bigger number will give you more results but mostly useless.{0}A lower number will give you few results but accurate.{0}{0}Tip: Start with a low number.",
                Environment.NewLine));
            validateToolTip.SetToolTip(validateButtonPictureBox, string.Format("Re-scan with new settings (if you changed them) and updates{0}the possible entity list addresses previously found.", Environment.NewLine));
        }

        private void RefreshProcessesList()
        {
            processesList.Items.Clear();

            Process[] allApplications = Process.GetProcesses().Where(process => process.MainWindowHandle != IntPtr.Zero).ToArray();

            for (int i = 0; i < allApplications.Length; ++i)
            {
                processesList.Items.Add(allApplications[i].ProcessName.ToString());
            }
        }

        // This method is called when the ComboBox is opened
        private void ProcessesList_DropDown(object sender, EventArgs e)
        {
            RefreshProcessesList();
        }

        private void ProcessesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            processName = (string)comboBox.SelectedItem;

            if (processName != "")
            {
                Process process = Process.GetProcessesByName(processName)[0];

                if (process != null)
                {
                    Icon processIcon = Icon.ExtractAssociatedIcon(process.MainModule.FileName);
                    processImage.Image = Bitmap.FromHicon(processIcon.Handle);
                }

                attachButton.Enabled = true;
            }
            else
            {
                attachButton.Enabled = false;
            }
        }

        private void AttachButton_Click(object sender, EventArgs e)
        {
            entityListFinder.AttachButton();
        }

        public void LoadProcess(string processName, int processId, DataType dataType)
        {
            controlState.Change(ControlState.State.PROCESS_ATTACHED);
            processNameLabel.Text = processName + "(" + processId.ToString() + ")" + " - " + ((dataType == DataType.Int32) ? "32" : "64") + " bit";
        }

        private void LoadAddressesButton_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\possibleEntityList.txt";
            string[] result = File.ReadAllLines(desktopPath);

            addressesToFindTextBox.Text = "";

            for (int i = 0; i < result.Length; i++)
            {
                addressesToFindTextBox.AppendText(result[i] + Environment.NewLine);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(marginOffsetTextBox.Text, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out int marginOffset))
            {
                MessageBox.Show("Offset margin " + "(" + marginOffsetTextBox.Text + ")" + " is not a valid HEX number!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }

            addressesToFindTextBox.Text = addressesToFindTextBox.Text.Trim();

            if (addressesToFindTextBox.Lines.Length < 1)
            {
                MessageBox.Show("There is not addresses to be found!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }

            for (int i = 0; i < addressesToFindTextBox.Lines.Length; ++i)
            {
                if (!Int64.TryParse(addressesToFindTextBox.Lines[i], NumberStyles.HexNumber, CultureInfo.CurrentCulture, out _))
                {
                    MessageBox.Show("The address " + addressesToFindTextBox.Lines[i] + " is not a valid HEX number!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return;
                }
            }

            if (marginOffset < 4)
            {
                marginOffsetTextBox.Text = "4";
            }

            controlState.Change(ControlState.State.SEARCH_BUTTON);
            entityListFinder.SearchButton();
        }

        private void ValidateButton_Click(object sender, EventArgs e)
        {
            controlState.Change(ControlState.State.SEARCH_BUTTON);
            entityListFinder.ValidateButton();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            entityListFinder.SaveButton();
        }

        // https://stackoverflow.com/a/1953411/4671900
        public bool IsWin64Emulator(Process process)
        {
            if ((Environment.OSVersion.Version.Major > 5) || ((Environment.OSVersion.Version.Major == 5) && (Environment.OSVersion.Version.Minor >= 1)))
            {
                return NativeMethods.IsWow64Process(process.Handle, out bool retVal) && retVal;
            }

            return false; // not on 64-bit Windows Emulator
        }

        private void GoToWebsiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://guidedhacking.com/resources/gh-entity-list-finder.36/");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AboutPopup aboutPopup = new AboutPopup())
            {
                aboutPopup.ShowDialog();
            }
        }
    }
}