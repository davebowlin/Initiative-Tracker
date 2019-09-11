using System;
using System.Drawing;
using System.Windows.Forms;

namespace Initiative_Tracker
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

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
                        label.BackColor = Color.LightPink;
                        label.ForeColor = Color.Black;
                        label.Font = new Font(label.Font, FontStyle.Regular);
                        return;
                    }
                    if (label.BackColor == Color.LightPink)
                    {
                        label.BackColor = Color.LightGray;
                        label.ForeColor = Color.Black;
                        label.Font = new Font(label.Font, FontStyle.Regular);
                        return;
                    }
                    if (label.BackColor == Color.LightGray)
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

        private void PanelAdd_MouseClick(object sender, MouseEventArgs e)
        {
            AddNewEntity(sender, e);
        }

        void AddNewEntity(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var coords = PointToClient(Cursor.Position);

                string myTitle = Input.ShowDialog("Name of player, monster, NPC:", "Add New");
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
                    label.BringToFront();
                    label.MouseClick += label_Click;
                    Helper.ControlMover.Init(label);
                }
            }
        }


        // this is preventing the labels from being right-clicked after use, so I've removed it for now.
        private void ButtonReset_Click(object sender, EventArgs e)
        {
            foreach (var c in Controls)
            {
                if (c is Label)
                {
                    string n = ((Label)c).Name;
                    if (n.Contains("LABEL"))
                    {
                        // skip these
                    }
                    else
                    {
                        ((Label)c).BackColor = Color.Transparent;
                        ((Label)c).ForeColor = Color.Black;
                        ((Label)c).Font = new Font(Font, FontStyle.Regular);
                    }
                }
            }
        }

        private void PanelInitiative_MouseClick(object sender, MouseEventArgs e)
        {
            AddNewEntity(sender, e);
        }
    }
}
