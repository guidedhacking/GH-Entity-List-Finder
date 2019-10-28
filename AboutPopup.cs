using System.Diagnostics;
using System.Windows.Forms;

namespace EntityListFinder
{
    public partial class AboutPopup : Form
    {
        public AboutPopup()
        {
            InitializeComponent();
        }

        private void squalrHyperlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Squalr/Squalr");
        }
    }
}