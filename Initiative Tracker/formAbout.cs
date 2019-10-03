using System;
using System.Diagnostics;
using System.Drawing;
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

        private void LabelContact_Click(object sender, EventArgs e)
        {
            Process.Start("mailto:davebowlin@gmail.com");
        }

        private void LabelContact_MouseHover(object sender, EventArgs e)
        {
            labelContact.ForeColor = Color.White;
            labelContact.BackColor = Color.Black;
        }

        private void LabelContact_MouseLeave(object sender, EventArgs e)
        {
            labelContact.ForeColor = Color.DarkRed;
            labelContact.BackColor = Color.Transparent;
        }
    }
}
