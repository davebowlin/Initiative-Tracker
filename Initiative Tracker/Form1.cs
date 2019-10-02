/* TTRPG Initiatve Tracker
 * 
 * A simple, easy to use initiative tracker for
 * pretty much any table-top role playing game.
 * 
 * I wrote this for keeping initiative straight
 * while playing Dungeons and Dragons, works great.
 * 
 * Latest version:  1.5
 * Release date:  
 * 
 * License:  GNU Public License v2
 * 
 * Contact:  davebowlin@gmail.com
*/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Reflection;

namespace Initiative_Tracker
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        #region Label Clicks
        private void label_Click(object sender, MouseEventArgs e)
        {
            Label label = sender as Label;

            switch (e.Button)
            {
                case MouseButtons.Left:
                    break;
                case MouseButtons.None:
                    break;
                case MouseButtons.Right:
                    if (label.BackColor == Color.White)
                    {
                        label.BackColor = Color.Blue;
                        label.ForeColor = Color.White;
                        label.Font = new Font(label.Font, FontStyle.Regular);
                        return;
                    }
                    if (label.BackColor == Color.Blue)
                    {
                        label.BackColor = Color.SandyBrown;
                        label.ForeColor = Color.Black;
                        label.Font = new Font(label.Font, FontStyle.Regular);
                        return;
                    }
                    if (label.BackColor == Color.SandyBrown)
                    {
                        label.BackColor = Color.Black;
                        label.ForeColor = Color.White;
                        label.Font = new Font(label.Font, FontStyle.Strikeout);
                        return;
                    }
                    if (label.BackColor == Color.Black)
                    {
                        label.BackColor = Color.White;
                        label.ForeColor = Color.Black;
                        label.Font = new Font(label.Font, FontStyle.Regular);
                        return;
                    }
                    break;
                case MouseButtons.Middle:
                    this.Controls.Remove((Label)sender);
                    break;
                default:
                    break;
            }
        }
        #endregion


        #region Add New Entity
        private void PanelAdd_MouseClick(object sender, MouseEventArgs e)
        {
            AddNewEntity(sender, e);
        }


        private void AddNewEntity(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var coords = PointToClient(Cursor.Position);

                string myTitle = Input.ShowDialog("Player, monster, NPC, etc:", "Add New");
                if (!string.IsNullOrWhiteSpace(myTitle))
                {
                    Label label = new Label();
                    label.Location = coords;
                    label.Name = myTitle;
                    label.Text = label.Name;
                    this.Controls.Add(label);
                    label.Size = new Size(52, 25);
                    label.BorderStyle = BorderStyle.FixedSingle;
                    label.AutoSize = true;
                    //label.Font = new Font("Arial", 12);
                    label.BackColor = Color.White;
                    label.ForeColor = Color.Black;
                    label.BringToFront();
                    label.MouseClick += label_Click;
                    Helper.ControlMover.Init(label);
                }
            }
        }

        private void PanelInitiative_MouseClick(object sender, MouseEventArgs e)
        {
            AddNewEntity(sender, e);
        }
        #endregion


        #region Reset Labels
        private void ButtonReset_Click(object sender, EventArgs e)
        {
            foreach (var c in Controls)
            {
                if (c is Label label)
                {
                    {
                        label.BackColor = Color.White;
                        label.ForeColor = Color.Black;
                        label.Font = new Font(Font, FontStyle.Regular);
                    }
                }
            }
        }
        #endregion


        #region Mouse-Overs and Button Clicks
        private void PicOpen_MouseHover(object sender, EventArgs e)
        {
            label_info.BorderStyle = BorderStyle.FixedSingle;
            label_info.Text = "Load a saved tracker";
        }

        private void icons_MouseLeave(object sender, EventArgs e)
        {
            label_info.BorderStyle = BorderStyle.None;
            label_info.Text = "";
        }

        private void PicNew_MouseHover(object sender, EventArgs e)
        {
            label_info.BorderStyle = BorderStyle.FixedSingle;
            label_info.Text = "Create new tracker";
        }

        private void PicSave_MouseHover(object sender, EventArgs e)
        {
            label_info.BorderStyle = BorderStyle.FixedSingle;
            label_info.Text = "Save current tracker";
        }

        private void PictureBox1_MouseHover(object sender, EventArgs e)
        {
            label_info.BorderStyle = BorderStyle.FixedSingle;
            label_info.Text = "Reset all to waiting";
        }

        private void PicAbout_MouseHover(object sender, EventArgs e)
        {
            label_info.BorderStyle = BorderStyle.FixedSingle;
            label_info.Text = "TTRP Initiative Tracker is free software.";
        }

        private void GitHub_MouseHover(object sender, EventArgs e)
        {
            label_info.BorderStyle = BorderStyle.FixedSingle;
            label_info.Text = "Click for the C# source code";
        }

        private void PicGitHub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/davebowlin/Initiative-Tracker");
        }

        private void PicAbout_Click(object sender, EventArgs e)
        {
            var major = Assembly.GetExecutingAssembly().GetName().Version.Major;
            var minor = Assembly.GetExecutingAssembly().GetName().Version.Minor;
            string version = major.ToString() + "." + minor.ToString();


            string nl = Environment.NewLine + Environment.NewLine;
            string msg = "TTRPG Initiative Tracker for Windows" + Environment.NewLine;
            msg += "Version " + version + nl;
            msg += "Freeware. C# source code is available on GitHub." + Environment.NewLine;
            msg += "Click the GitHub icon for the source code." + nl;
            msg += "Use at your own risk." + nl;
            msg += "davebowlin@gmail.com";
            MessageBox.Show(msg);
        }

        private void PicSave_Click(object sender, EventArgs e)
        {
            GetTextData();
        }
        #endregion


        #region New List
        private void PicNew_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Create new tracker?" + Environment.NewLine + "Current " +
                "tracker will be cleared.", "New Tracker", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                // put the labels in a List to make sure they are all removed at the same time
                List<Control> labels = new List<Control>();
                foreach (Control c in this.Controls)
                {
                    if (c is Label)
                    {
                        labels.Add(c);
                    }
                }
                foreach (Control remove in labels)
                {
                    this.Controls.Remove(remove);
                    remove.Dispose();
                }
            }
        }
        #endregion


        #region Get All Label Text and Data To Export To File
        private void GetTextData()
        {
            string txtToSave = string.Empty;
            List<string> data = new List<string>();

            foreach (Control c in this.Controls)
            {
                string divider = "¢";

                if (c.GetType() == typeof(Label))
                {
                    Color bgcolor = c.BackColor;
                    Color fgcolor = c.ForeColor;

                    bool strikeout = c.Font.Strikeout;
                    data.Add(c.Text + divider + c.Location.X.ToString() + divider + c.Location.Y.ToString() + divider + bgcolor + divider + fgcolor + divider + strikeout);
                }
            }
            try
            {
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllLines(saveFile.FileName, data);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured, the tracker was not saved." + Environment.NewLine + "Error: "
                    + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion


        #region Load Data
        private void PicLoad_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string line = string.Empty;
                StreamReader sr = new StreamReader(openFile.FileName);
                while ((line = sr.ReadLine()) != null)
                {
                    string[] sections = line.Split('¢');
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        Label label = new Label
                        {
                            Location = new Point(Convert.ToInt32(sections[1]), (Convert.ToInt32(sections[2]))),
                            Text = sections[0]
                        };
                        Controls.Add(label);
                        label.Size = new Size(52, 25);
                        label.BorderStyle = BorderStyle.FixedSingle;
                        label.AutoSize = true;
                        label.Font = new Font("Arial", 12);
                        label.BringToFront();
                        label.MouseClick += label_Click;
                        Helper.ControlMover.Init(label);
                    }
                }
                sr.Close();
            }
        } 
        #endregion
    }
}
