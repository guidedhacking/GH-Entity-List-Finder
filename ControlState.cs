namespace EntityListFinder
{
    public class ControlState
    {
        private MainForm appForm;

        public enum State
        {
            FORM_LOAD = 0,
            PROCESS_ATTACHED,
            SEARCH_BUTTON,
            STOP_BUTTON,
            VALIDATE_BUTTON
        };

        public ControlState(MainForm mainForm)
        {
            appForm = mainForm;
        }

        public void Change(State state)
        {
            switch (state)
            {
                case State.FORM_LOAD:
                    {
                        appForm.processNameLabel.Visible = false;
                        appForm.searchPanel.Visible = false;
                        appForm.marginOffsetTextBox.Enabled = false;
                        appForm.addressesToFindTextBox.Enabled = false;
                        appForm.loadAddressesButton.Enabled = false;
                        appForm.searchButton.Enabled = false;

                        break;
                    }
                case State.PROCESS_ATTACHED:
                    {
                        appForm.processNameLabel.Visible = true;
                        appForm.marginOffsetTextBox.Enabled = true;
                        appForm.addressesToFindTextBox.Enabled = true;
                        appForm.loadAddressesButton.Enabled = true;
                        appForm.searchButton.Enabled = true;

                        break;
                    }
                case State.SEARCH_BUTTON:
                case State.VALIDATE_BUTTON:
                    {
                        appForm.searchPanel.Visible = true;
                        appForm.marginOffsetTextBox.Enabled = false;
                        appForm.addressesToFindTextBox.Enabled = false;
                        appForm.loadAddressesButton.Enabled = false;
                        appForm.searchButton.Enabled = false;
                        appForm.attachButton.Enabled = false;
                        appForm.saveButton.Enabled = false;
                        appForm.validateButton.Enabled = false;

                        break;
                    }
                case State.STOP_BUTTON:
                    {
                        appForm.marginOffsetTextBox.Enabled = true;
                        appForm.addressesToFindTextBox.Enabled = true;
                        appForm.loadAddressesButton.Enabled = true;
                        appForm.searchButton.Enabled = true;
                        appForm.attachButton.Enabled = true;
                        appForm.saveButton.Enabled = true;
                        appForm.validateButton.Enabled = true;

                        break;
                    }
            }
        }
    }
}