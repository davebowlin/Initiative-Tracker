/* TTRPG Initiatve Tracker
 * 
 * A simple, easy to use initiative tracker for
 * pretty much any table-top role playing game.
 * 
 * I wrote this for keeping initiative straight
 * while playing Dungeons and Dragons, works great.
 * 
 * Latest version:  1.7
 * Release date:  3 October 2019
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


        #region Menu and Toolbar Button Clicks
        private void PicGitHub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/davebowlin/Initiative-Tracker");
        }

        private void PicAbout_Click(object sender, EventArgs e)
        {
            formAbout form = new formAbout();
            form.ShowDialog();
            form.Dispose();
        }

        private void PicSave_Click(object sender, EventArgs e)
        {
            GetTextData();
        }
        #endregion


        #region New Tracker
        private void PicNew_Click(object sender, EventArgs e)
        {
            int count = 0;

            foreach (var c in Controls)
            {
                if (c is Label label)
                {
                    {
                        count++;
                    }
                }
            }

            if (count > 0)
            {
                DialogResult dr = MessageBox.Show("Create a new tracker?" + Environment.NewLine + Environment.NewLine + "The current " +
                        "tracker will be destroyed," + Environment.NewLine + "so save it first if you want to" +
                        " keep it.", "New Tracker", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    RemoveLabels();
                }
                else
                {
                    return;
                }
            }
        }

            private void RemoveLabels()
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
        #endregion


        #region Save Tracker
        private void GetTextData()
        {
            string txtToSave = string.Empty;
            List<string> data = new List<string>();

            foreach (Control c in this.Controls)
            {
                string divider = "¢";

                if (c.GetType() == typeof(Label))
                {
                    string bgcolor, fgcolor = string.Empty;

                    if (c.ForeColor == Color.White)
                    {
                        fgcolor = "White";
                    }
                    else
                    {
                        fgcolor = "Black";
                    }

                    switch (c.BackColor.ToString())
                    {
                        case "Color [Black]":
                            bgcolor = "Black";
                            break;
                        case "Color [SandyBrown]":
                            bgcolor = "SandyBrown";
                            break;
                        case "Color [Blue]":
                            bgcolor = "Blue";
                            break;
                        default:
                            bgcolor = "White";
                            break;
                    }

                    bool strikeout = c.Font.Strikeout;

                    data.Add(c.Text + divider + c.Location.X.ToString() + divider + c.Location.Y.ToString() + divider
                        + bgcolor + divider + fgcolor + divider + strikeout);
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


        #region Load Tracker
        private void PicLoad_Click(object sender, EventArgs e)
        {
            int count = 0;

            foreach (var c in Controls)
            {
                if (c is Label label)
                {
                    {
                        count++;
                    }
                }
            }

            if (count > 0)
            {
                DialogResult dr = MessageBox.Show("Load a tracker?" + Environment.NewLine + Environment.NewLine + "The current " +
                        "tracker will be destroyed," + Environment.NewLine + "so save it first if you want to" +
                        " keep it.", "Load Tracker", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    RemoveLabels();
                }
                else
                {
                    return;
                }
            }

            try
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
                                Text = sections[0],
                                BackColor = Color.FromName(sections[3]),
                                ForeColor = Color.FromName(sections[4])
                            };
                            Controls.Add(label);
                            label.Size = new Size(52, 25);
                            label.BorderStyle = BorderStyle.FixedSingle;
                            label.AutoSize = true;
                            //label.Font = new Font("Arial", 12);
                            if (sections[5] == "True")
                            {
                                label.Font = new Font(label.Font, FontStyle.Strikeout);
                            }
                            label.BringToFront();
                            label.MouseClick += label_Click;
                            Helper.ControlMover.Init(label);
                        }
                    }
                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred and the tracker cannot be loaded." + Environment.NewLine
                    + "Error: " + Environment.NewLine + ex.Message, "Error");
            }
        }
        #endregion


        #region Form Position Saving and Loading
        private void Form1_Load(object sender, EventArgs e)
        {
            this.RestoreWindowPosition();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.SaveWindowPosition();
        }

        private void RestoreWindowPosition()
        {
            if (Properties.Settings.Default.HasSetDefaults)
            {
                this.WindowState = Properties.Settings.Default.WindowState;
                this.Location = Properties.Settings.Default.Location;
                this.Size = Properties.Settings.Default.Size;
            }
        }

        private void SaveWindowPosition()
        {
            Properties.Settings.Default.WindowState = this.WindowState;

            if (this.WindowState == FormWindowState.Normal)
            {
                Properties.Settings.Default.Location = this.Location;
                Properties.Settings.Default.Size = this.Size;
            }
            else
            {
                Properties.Settings.Default.Location = this.RestoreBounds.Location;
                Properties.Settings.Default.Size = this.RestoreBounds.Size;
            }

            Properties.Settings.Default.HasSetDefaults = true;

            Properties.Settings.Default.Save();
        }
        #endregion

    }    
} 

