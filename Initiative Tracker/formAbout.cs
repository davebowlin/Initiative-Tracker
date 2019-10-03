using System;
using System.Reflection;
using System.Windows.Forms;

namespace Initiative_Tracker
{
    public partial class formAbout : Form
    {
        public formAbout()
        {
            InitializeComponent();
        }

        private void FormAbout_Load(object sender, EventArgs e)
        {
            var major = Assembly.GetExecutingAssembly().GetName().Version.Major;
            var minor = Assembly.GetExecutingAssembly().GetName().Version.Minor;
            string version = major.ToString() + "." + minor.ToString();
            labelVersion.Text = version;
        }

        private void PicGitHub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/davebowlin/Initiative-Tracker");
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PicLogo_MouseHover(object sender, EventArgs e)
        {
            picLogo.Image = Properties.Resources.me;
        }

        private void PicLogo_MouseLeave(object sender, EventArgs e)
        {
            picLogo.Image = Properties.Resources.icon;
        }
    }
}
