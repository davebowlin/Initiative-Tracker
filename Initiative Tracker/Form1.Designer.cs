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
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
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
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.panelTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LABEL2 = new System.Windows.Forms.Label();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.toolMain = new System.Windows.Forms.ToolStrip();
            this.toolSave = new System.Windows.Forms.ToolStripButton();
            this.toolLoad = new System.Windows.Forms.ToolStripButton();
            this.toolNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolReset = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolGit = new System.Windows.Forms.ToolStripButton();
            this.toolAbout = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gitHubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.toolMain.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip
            // 
            this.toolTip.IsBalloon = true;
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
            this.panelAdd.BackColor = System.Drawing.Color.DarkGray;
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
            this.label13.Location = new System.Drawing.Point(0, 440);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(153, 25);
            this.label13.TabIndex = 25;
            this.label13.Text = "davebowlin@gmail.com";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkGray;
            this.label10.Location = new System.Drawing.Point(-7, 69);
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
            this.LABEL11.Location = new System.Drawing.Point(32, 226);
            this.LABEL11.Name = "LABEL11";
            this.LABEL11.Size = new System.Drawing.Size(111, 30);
            this.LABEL11.TabIndex = 22;
            this.LABEL11.Text = "Strikeout: Dead /\r\n                  Disabled";
            this.LABEL11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LABEL9
            // 
            this.LABEL9.AutoSize = true;
            this.LABEL9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL9.ForeColor = System.Drawing.Color.DarkGray;
            this.LABEL9.Location = new System.Drawing.Point(10, 307);
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
            this.LABEL8.Location = new System.Drawing.Point(32, 211);
            this.LABEL8.Name = "LABEL8";
            this.LABEL8.Size = new System.Drawing.Size(87, 15);
            this.LABEL8.TabIndex = 20;
            this.LABEL8.Text = "Tan: Complete";
            this.LABEL8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LABEL7
            // 
            this.LABEL7.AutoSize = true;
            this.LABEL7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL7.ForeColor = System.Drawing.Color.DarkGray;
            this.LABEL7.Location = new System.Drawing.Point(32, 196);
            this.LABEL7.Name = "LABEL7";
            this.LABEL7.Size = new System.Drawing.Size(68, 15);
            this.LABEL7.TabIndex = 19;
            this.LABEL7.Text = "Blue: Active";
            this.LABEL7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LABEL6
            // 
            this.LABEL6.AutoSize = true;
            this.LABEL6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL6.ForeColor = System.Drawing.Color.DarkGray;
            this.LABEL6.Location = new System.Drawing.Point(32, 181);
            this.LABEL6.Name = "LABEL6";
            this.LABEL6.Size = new System.Drawing.Size(85, 15);
            this.LABEL6.TabIndex = 18;
            this.LABEL6.Text = "White: Waiting";
            this.LABEL6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LABEL5
            // 
            this.LABEL5.AutoSize = true;
            this.LABEL5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL5.ForeColor = System.Drawing.Color.DarkGray;
            this.LABEL5.Location = new System.Drawing.Point(9, 166);
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
            this.LABEL4.Location = new System.Drawing.Point(9, 115);
            this.LABEL4.Name = "LABEL4";
            this.LABEL4.Size = new System.Drawing.Size(116, 15);
            this.LABEL4.TabIndex = 16;
            this.LABEL4.Text = "Middle-Click: Delete";
            this.LABEL4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LABEL3
            // 
            this.LABEL3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL3.ForeColor = System.Drawing.Color.Gray;
            this.LABEL3.Location = new System.Drawing.Point(1, 25);
            this.LABEL3.Name = "LABEL3";
            this.LABEL3.Size = new System.Drawing.Size(152, 19);
            this.LABEL3.TabIndex = 15;
            this.LABEL3.Text = "Instructions:";
            this.LABEL3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelInitiative
            // 
            this.panelInitiative.AllowDrop = true;
            this.panelInitiative.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelInitiative.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInitiative.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInitiative.Location = new System.Drawing.Point(5, 5);
            this.panelInitiative.Name = "panelInitiative";
            this.panelInitiative.Size = new System.Drawing.Size(257, 476);
            this.panelInitiative.TabIndex = 1;
            this.panelInitiative.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelInitiative_MouseClick);
            // 
            // saveFile
            // 
            this.saveFile.DefaultExt = "trk";
            this.saveFile.Filter = "Initiative Tracker | *.trk";
            this.saveFile.InitialDirectory = "%USERPROFILE%\\Documents";
            this.saveFile.Title = "Save current TRK file...";
            // 
            // panelTop
            // 
            this.panelTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.LABEL2);
            this.panelTop.Location = new System.Drawing.Point(12, 6);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(692, 63);
            this.panelTop.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(572, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "Unused / Waiting";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LABEL2
            // 
            this.LABEL2.AutoSize = true;
            this.LABEL2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL2.ForeColor = System.Drawing.Color.DarkGray;
            this.LABEL2.Location = new System.Drawing.Point(3, 46);
            this.LABEL2.Name = "LABEL2";
            this.LABEL2.Size = new System.Drawing.Size(100, 16);
            this.LABEL2.TabIndex = 30;
            this.LABEL2.Text = "Initiative Order";
            this.LABEL2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFile
            // 
            this.openFile.DefaultExt = "trk";
            this.openFile.Filter = "Initiative Tracker | *.trk";
            this.openFile.InitialDirectory = "%USERPROFILE%\\Documents";
            this.openFile.Title = "Select TRK file to open...";
            // 
            // toolMain
            // 
            this.toolMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSave,
            this.toolLoad,
            this.toolNew,
            this.toolStripSeparator1,
            this.toolReset,
            this.toolStripSeparator2,
            this.toolGit,
            this.toolAbout});
            this.toolMain.Location = new System.Drawing.Point(0, 24);
            this.toolMain.Name = "toolMain";
            this.toolMain.Size = new System.Drawing.Size(716, 25);
            this.toolMain.TabIndex = 33;
            // 
            // toolSave
            // 
            this.toolSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSave.Image = ((System.Drawing.Image)(resources.GetObject("toolSave.Image")));
            this.toolSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSave.Name = "toolSave";
            this.toolSave.Size = new System.Drawing.Size(23, 22);
            this.toolSave.Text = "Save";
            this.toolSave.Click += new System.EventHandler(this.PicSave_Click);
            // 
            // toolLoad
            // 
            this.toolLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolLoad.Image = ((System.Drawing.Image)(resources.GetObject("toolLoad.Image")));
            this.toolLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolLoad.Name = "toolLoad";
            this.toolLoad.Size = new System.Drawing.Size(23, 22);
            this.toolLoad.Text = "Load";
            this.toolLoad.Click += new System.EventHandler(this.PicLoad_Click);
            // 
            // toolNew
            // 
            this.toolNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolNew.Image = ((System.Drawing.Image)(resources.GetObject("toolNew.Image")));
            this.toolNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolNew.Name = "toolNew";
            this.toolNew.Size = new System.Drawing.Size(23, 22);
            this.toolNew.Text = "New";
            this.toolNew.Click += new System.EventHandler(this.PicNew_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolReset
            // 
            this.toolReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolReset.Image = ((System.Drawing.Image)(resources.GetObject("toolReset.Image")));
            this.toolReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolReset.Name = "toolReset";
            this.toolReset.Size = new System.Drawing.Size(23, 22);
            this.toolReset.Text = "Reset";
            this.toolReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolGit
            // 
            this.toolGit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolGit.Image = global::Initiative_Tracker.Properties.Resources.icon_github;
            this.toolGit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolGit.Name = "toolGit";
            this.toolGit.Size = new System.Drawing.Size(23, 22);
            this.toolGit.Text = "GitHub";
            this.toolGit.Click += new System.EventHandler(this.PicGitHub_Click);
            // 
            // toolAbout
            // 
            this.toolAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolAbout.Image = ((System.Drawing.Image)(resources.GetObject("toolAbout.Image")));
            this.toolAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAbout.Name = "toolAbout";
            this.toolAbout.Size = new System.Drawing.Size(23, 22);
            this.toolAbout.Text = "About";
            this.toolAbout.Click += new System.EventHandler(this.PicAbout_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.newToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.gitHubToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(716, 24);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.PicSave_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.loadToolStripMenuItem.Text = "&Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.PicLoad_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.PicNew_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.resetToolStripMenuItem.Text = "&Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // gitHubToolStripMenuItem
            // 
            this.gitHubToolStripMenuItem.Name = "gitHubToolStripMenuItem";
            this.gitHubToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.gitHubToolStripMenuItem.Text = "&GitHub";
            this.gitHubToolStripMenuItem.Click += new System.EventHandler(this.PicGitHub_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.PicAbout_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(716, 564);
            this.Controls.Add(this.toolMain);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.tableContainer);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TTRPG Initiative Tracker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.toolMain.ResumeLayout(false);
            this.toolMain.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip;
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
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LABEL2;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.ToolStrip toolMain;
        private System.Windows.Forms.ToolStripButton toolSave;
        private System.Windows.Forms.ToolStripButton toolLoad;
        private System.Windows.Forms.ToolStripButton toolNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolReset;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolGit;
        private System.Windows.Forms.ToolStripButton toolAbout;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gitHubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

