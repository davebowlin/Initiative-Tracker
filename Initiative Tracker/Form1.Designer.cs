namespace Initiative_Tracker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LABEL2 = new System.Windows.Forms.Label();
            this.LABEL1 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.picGitHub = new System.Windows.Forms.PictureBox();
            this.picAbout = new System.Windows.Forms.PictureBox();
            this.picReset = new System.Windows.Forms.PictureBox();
            this.picNew = new System.Windows.Forms.PictureBox();
            this.picLoad = new System.Windows.Forms.PictureBox();
            this.picSave = new System.Windows.Forms.PictureBox();
            this.label_info = new System.Windows.Forms.Label();
            this.tableContainer = new System.Windows.Forms.TableLayoutPanel();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LABEL11 = new System.Windows.Forms.Label();
            this.LABEL9 = new System.Windows.Forms.Label();
            this.LABEL8 = new System.Windows.Forms.Label();
            this.LABEL7 = new System.Windows.Forms.Label();
            this.LABEL6 = new System.Windows.Forms.Label();
            this.LABEL5 = new System.Windows.Forms.Label();
            this.LABEL4 = new System.Windows.Forms.Label();
            this.LABEL3 = new System.Windows.Forms.Label();
            this.panelInitiative = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picGitHub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAbout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSave)).BeginInit();
            this.tableContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LABEL2
            // 
            this.LABEL2.AutoSize = true;
            this.LABEL2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL2.ForeColor = System.Drawing.Color.DarkGray;
            this.LABEL2.Location = new System.Drawing.Point(8, 47);
            this.LABEL2.Name = "LABEL2";
            this.LABEL2.Size = new System.Drawing.Size(112, 19);
            this.LABEL2.TabIndex = 0;
            this.LABEL2.Text = "Initiative Order";
            this.LABEL2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LABEL1
            // 
            this.LABEL1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LABEL1.AutoSize = true;
            this.LABEL1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL1.ForeColor = System.Drawing.Color.DarkGray;
            this.LABEL1.Location = new System.Drawing.Point(573, 44);
            this.LABEL1.Name = "LABEL1";
            this.LABEL1.Size = new System.Drawing.Size(131, 19);
            this.LABEL1.TabIndex = 3;
            this.LABEL1.Text = "Waiting / Unused";
            this.LABEL1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolTip
            // 
            this.toolTip.IsBalloon = true;
            // 
            // picGitHub
            // 
            this.picGitHub.BackColor = System.Drawing.Color.Transparent;
            this.picGitHub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGitHub.Image = global::Initiative_Tracker.Properties.Resources.icon_github;
            this.picGitHub.Location = new System.Drawing.Point(638, 6);
            this.picGitHub.Name = "picGitHub";
            this.picGitHub.Size = new System.Drawing.Size(30, 35);
            this.picGitHub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGitHub.TabIndex = 31;
            this.picGitHub.TabStop = false;
            this.toolTip.SetToolTip(this.picGitHub, "GitHub");
            this.picGitHub.Click += new System.EventHandler(this.PicGitHub_Click);
            this.picGitHub.MouseLeave += new System.EventHandler(this.icons_MouseLeave);
            this.picGitHub.MouseHover += new System.EventHandler(this.GitHub_MouseHover);
            // 
            // picAbout
            // 
            this.picAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picAbout.BackColor = System.Drawing.Color.Transparent;
            this.picAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAbout.Image = global::Initiative_Tracker.Properties.Resources.icon_about;
            this.picAbout.Location = new System.Drawing.Point(674, 6);
            this.picAbout.Name = "picAbout";
            this.picAbout.Size = new System.Drawing.Size(30, 35);
            this.picAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAbout.TabIndex = 30;
            this.picAbout.TabStop = false;
            this.toolTip.SetToolTip(this.picAbout, "About");
            this.picAbout.Click += new System.EventHandler(this.PicAbout_Click);
            this.picAbout.MouseLeave += new System.EventHandler(this.icons_MouseLeave);
            this.picAbout.MouseHover += new System.EventHandler(this.PicAbout_MouseHover);
            // 
            // picReset
            // 
            this.picReset.BackColor = System.Drawing.Color.Transparent;
            this.picReset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picReset.Image = global::Initiative_Tracker.Properties.Resources.icon_reset2;
            this.picReset.Location = new System.Drawing.Point(151, 9);
            this.picReset.Name = "picReset";
            this.picReset.Size = new System.Drawing.Size(30, 35);
            this.picReset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picReset.TabIndex = 29;
            this.picReset.TabStop = false;
            this.toolTip.SetToolTip(this.picReset, "Reset");
            this.picReset.MouseLeave += new System.EventHandler(this.icons_MouseLeave);
            this.picReset.MouseHover += new System.EventHandler(this.PictureBox1_MouseHover);
            // 
            // picNew
            // 
            this.picNew.BackColor = System.Drawing.Color.Transparent;
            this.picNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picNew.Image = global::Initiative_Tracker.Properties.Resources.icon_new;
            this.picNew.Location = new System.Drawing.Point(84, 9);
            this.picNew.Name = "picNew";
            this.picNew.Size = new System.Drawing.Size(30, 35);
            this.picNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picNew.TabIndex = 26;
            this.picNew.TabStop = false;
            this.toolTip.SetToolTip(this.picNew, "New");
            this.picNew.MouseLeave += new System.EventHandler(this.icons_MouseLeave);
            this.picNew.MouseHover += new System.EventHandler(this.PicNew_MouseHover);
            // 
            // picLoad
            // 
            this.picLoad.BackColor = System.Drawing.Color.Transparent;
            this.picLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLoad.Image = global::Initiative_Tracker.Properties.Resources.icon_open;
            this.picLoad.Location = new System.Drawing.Point(48, 9);
            this.picLoad.Name = "picLoad";
            this.picLoad.Size = new System.Drawing.Size(30, 35);
            this.picLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLoad.TabIndex = 25;
            this.picLoad.TabStop = false;
            this.toolTip.SetToolTip(this.picLoad, "Load");
            this.picLoad.MouseLeave += new System.EventHandler(this.icons_MouseLeave);
            this.picLoad.MouseHover += new System.EventHandler(this.PicOpen_MouseHover);
            // 
            // picSave
            // 
            this.picSave.BackColor = System.Drawing.Color.Transparent;
            this.picSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSave.Image = global::Initiative_Tracker.Properties.Resources.icon_save;
            this.picSave.Location = new System.Drawing.Point(12, 9);
            this.picSave.Name = "picSave";
            this.picSave.Size = new System.Drawing.Size(30, 35);
            this.picSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSave.TabIndex = 24;
            this.picSave.TabStop = false;
            this.toolTip.SetToolTip(this.picSave, "Save");
            this.picSave.MouseLeave += new System.EventHandler(this.icons_MouseLeave);
            this.picSave.MouseHover += new System.EventHandler(this.PicSave_MouseHover);
            // 
            // label_info
            // 
            this.label_info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_info.BackColor = System.Drawing.Color.Transparent;
            this.label_info.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_info.ForeColor = System.Drawing.Color.DarkRed;
            this.label_info.Location = new System.Drawing.Point(198, 9);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(420, 35);
            this.label_info.TabIndex = 27;
            this.label_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableContainer
            // 
            this.tableContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableContainer.BackColor = System.Drawing.Color.Transparent;
            this.tableContainer.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableContainer.ColumnCount = 3;
            this.tableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableContainer.Controls.Add(this.panelAdd, 0, 0);
            this.tableContainer.Controls.Add(this.panel1, 0, 0);
            this.tableContainer.Controls.Add(this.panelInitiative, 0, 0);
            this.tableContainer.Location = new System.Drawing.Point(12, 66);
            this.tableContainer.Name = "tableContainer";
            this.tableContainer.RowCount = 1;
            this.tableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableContainer.Size = new System.Drawing.Size(695, 486);
            this.tableContainer.TabIndex = 28;
            // 
            // panelAdd
            // 
            this.panelAdd.AllowDrop = true;
            this.panelAdd.BackColor = System.Drawing.Color.NavajoWhite;
            this.panelAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAdd.Location = new System.Drawing.Point(432, 5);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(258, 476);
            this.panelAdd.TabIndex = 3;
            this.panelAdd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelAdd_MouseClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.LABEL11);
            this.panel1.Controls.Add(this.LABEL9);
            this.panel1.Controls.Add(this.LABEL8);
            this.panel1.Controls.Add(this.LABEL7);
            this.panel1.Controls.Add(this.LABEL6);
            this.panel1.Controls.Add(this.LABEL5);
            this.panel1.Controls.Add(this.LABEL4);
            this.panel1.Controls.Add(this.LABEL3);
            this.panel1.Location = new System.Drawing.Point(270, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 476);
            this.panel1.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label13.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkGray;
            this.label13.Location = new System.Drawing.Point(0, 450);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(153, 25);
            this.label13.TabIndex = 25;
            this.label13.Text = "This software is free.";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkGray;
            this.label10.Location = new System.Drawing.Point(-6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 19);
            this.label10.TabIndex = 7;
            this.label10.Text = "<<   Right-Click To Add   >>";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LABEL11
            // 
            this.LABEL11.AutoSize = true;
            this.LABEL11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL11.ForeColor = System.Drawing.Color.DarkGray;
            this.LABEL11.Location = new System.Drawing.Point(41, 270);
            this.LABEL11.Name = "LABEL11";
            this.LABEL11.Size = new System.Drawing.Size(111, 30);
            this.LABEL11.TabIndex = 22;
            this.LABEL11.Text = "Strikeout: Dead /\r\n                  Disabled";
            this.LABEL11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LABEL9
            // 
            this.LABEL9.AutoSize = true;
            this.LABEL9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL9.ForeColor = System.Drawing.Color.DarkGray;
            this.LABEL9.Location = new System.Drawing.Point(9, 320);
            this.LABEL9.Name = "LABEL9";
            this.LABEL9.Size = new System.Drawing.Size(133, 15);
            this.LABEL9.TabIndex = 21;
            this.LABEL9.Text = "Left-Click: Drag-n-Drop";
            this.LABEL9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LABEL8
            // 
            this.LABEL8.AutoSize = true;
            this.LABEL8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL8.ForeColor = System.Drawing.Color.DarkGray;
            this.LABEL8.Location = new System.Drawing.Point(45, 255);
            this.LABEL8.Name = "LABEL8";
            this.LABEL8.Size = new System.Drawing.Size(87, 15);
            this.LABEL8.TabIndex = 20;
            this.LABEL8.Text = "Tan: Complete";
            this.LABEL8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LABEL7
            // 
            this.LABEL7.AutoSize = true;
            this.LABEL7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL7.ForeColor = System.Drawing.Color.DarkGray;
            this.LABEL7.Location = new System.Drawing.Point(45, 240);
            this.LABEL7.Name = "LABEL7";
            this.LABEL7.Size = new System.Drawing.Size(68, 15);
            this.LABEL7.TabIndex = 19;
            this.LABEL7.Text = "Blue: Active";
            this.LABEL7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LABEL6
            // 
            this.LABEL6.AutoSize = true;
            this.LABEL6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL6.ForeColor = System.Drawing.Color.DarkGray;
            this.LABEL6.Location = new System.Drawing.Point(45, 225);
            this.LABEL6.Name = "LABEL6";
            this.LABEL6.Size = new System.Drawing.Size(85, 15);
            this.LABEL6.TabIndex = 18;
            this.LABEL6.Text = "White: Waiting";
            this.LABEL6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LABEL5
            // 
            this.LABEL5.AutoSize = true;
            this.LABEL5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL5.ForeColor = System.Drawing.Color.DarkGray;
            this.LABEL5.Location = new System.Drawing.Point(9, 199);
            this.LABEL5.Name = "LABEL5";
            this.LABEL5.Size = new System.Drawing.Size(70, 15);
            this.LABEL5.TabIndex = 17;
            this.LABEL5.Text = "Right-Click:";
            this.LABEL5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LABEL4
            // 
            this.LABEL4.AutoSize = true;
            this.LABEL4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL4.ForeColor = System.Drawing.Color.DarkGray;
            this.LABEL4.Location = new System.Drawing.Point(9, 159);
            this.LABEL4.Name = "LABEL4";
            this.LABEL4.Size = new System.Drawing.Size(116, 15);
            this.LABEL4.TabIndex = 16;
            this.LABEL4.Text = "Middle-Click: Delete";
            this.LABEL4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LABEL3
            // 
            this.LABEL3.AutoSize = true;
            this.LABEL3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL3.ForeColor = System.Drawing.Color.DarkGray;
            this.LABEL3.Location = new System.Drawing.Point(31, 117);
            this.LABEL3.Name = "LABEL3";
            this.LABEL3.Size = new System.Drawing.Size(94, 19);
            this.LABEL3.TabIndex = 15;
            this.LABEL3.Text = "Instructions:";
            this.LABEL3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelInitiative
            // 
            this.panelInitiative.AllowDrop = true;
            this.panelInitiative.BackColor = System.Drawing.Color.PaleGreen;
            this.panelInitiative.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInitiative.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInitiative.Location = new System.Drawing.Point(5, 5);
            this.panelInitiative.Name = "panelInitiative";
            this.panelInitiative.Size = new System.Drawing.Size(257, 476);
            this.panelInitiative.TabIndex = 1;
            this.panelInitiative.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelInitiative_MouseClick);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(716, 564);
            this.Controls.Add(this.picGitHub);
            this.Controls.Add(this.picAbout);
            this.Controls.Add(this.picReset);
            this.Controls.Add(this.tableContainer);
            this.Controls.Add(this.label_info);
            this.Controls.Add(this.picNew);
            this.Controls.Add(this.picLoad);
            this.Controls.Add(this.picSave);
            this.Controls.Add(this.LABEL1);
            this.Controls.Add(this.LABEL2);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "TTRPG Initiative Tracker";
            ((System.ComponentModel.ISupportInitialize)(this.picGitHub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAbout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSave)).EndInit();
            this.tableContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LABEL2;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label LABEL1;
        private System.Windows.Forms.PictureBox picSave;
        private System.Windows.Forms.PictureBox picLoad;
        private System.Windows.Forms.PictureBox picNew;
        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.TableLayoutPanel tableContainer;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LABEL11;
        private System.Windows.Forms.Label LABEL9;
        private System.Windows.Forms.Label LABEL8;
        private System.Windows.Forms.Label LABEL7;
        private System.Windows.Forms.Label LABEL6;
        private System.Windows.Forms.Label LABEL5;
        private System.Windows.Forms.Label LABEL4;
        private System.Windows.Forms.Label LABEL3;
        private System.Windows.Forms.Panel panelInitiative;
        private System.Windows.Forms.PictureBox picReset;
        private System.Windows.Forms.PictureBox picAbout;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox picGitHub;
    }
}

