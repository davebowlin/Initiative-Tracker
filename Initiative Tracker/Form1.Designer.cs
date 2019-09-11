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
            this.panelInitiative = new System.Windows.Forms.Panel();
            this.LABEL2 = new System.Windows.Forms.Label();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.LABEL1 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.LABEL11 = new System.Windows.Forms.Label();
            this.LABEL9 = new System.Windows.Forms.Label();
            this.LABEL8 = new System.Windows.Forms.Label();
            this.LABEL7 = new System.Windows.Forms.Label();
            this.LABEL6 = new System.Windows.Forms.Label();
            this.LABEL5 = new System.Windows.Forms.Label();
            this.LABEL4 = new System.Windows.Forms.Label();
            this.LABEL3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInitiative
            // 
            this.panelInitiative.AllowDrop = true;
            this.panelInitiative.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelInitiative.BackColor = System.Drawing.Color.PaleGreen;
            this.panelInitiative.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInitiative.Location = new System.Drawing.Point(12, 41);
            this.panelInitiative.Name = "panelInitiative";
            this.panelInitiative.Size = new System.Drawing.Size(180, 505);
            this.panelInitiative.TabIndex = 0;
            this.panelInitiative.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelInitiative_MouseClick);
            // 
            // LABEL2
            // 
            this.LABEL2.AutoSize = true;
            this.LABEL2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL2.ForeColor = System.Drawing.Color.DarkGray;
            this.LABEL2.Location = new System.Drawing.Point(8, 19);
            this.LABEL2.Name = "LABEL2";
            this.LABEL2.Size = new System.Drawing.Size(112, 19);
            this.LABEL2.TabIndex = 0;
            this.LABEL2.Text = "Initiative Order";
            this.LABEL2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelAdd
            // 
            this.panelAdd.AllowDrop = true;
            this.panelAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelAdd.BackColor = System.Drawing.Color.NavajoWhite;
            this.panelAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAdd.Location = new System.Drawing.Point(366, 41);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(180, 505);
            this.panelAdd.TabIndex = 2;
            this.panelAdd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelAdd_MouseClick);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkGray;
            this.label10.Location = new System.Drawing.Point(-1, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 19);
            this.label10.TabIndex = 7;
            this.label10.Text = "<<   Right-Click To Add   >>";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LABEL1
            // 
            this.LABEL1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LABEL1.AutoSize = true;
            this.LABEL1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL1.ForeColor = System.Drawing.Color.DarkGray;
            this.LABEL1.Location = new System.Drawing.Point(362, 19);
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.LABEL11);
            this.panel1.Controls.Add(this.LABEL9);
            this.panel1.Controls.Add(this.LABEL8);
            this.panel1.Controls.Add(this.LABEL7);
            this.panel1.Controls.Add(this.LABEL6);
            this.panel1.Controls.Add(this.LABEL5);
            this.panel1.Controls.Add(this.LABEL4);
            this.panel1.Controls.Add(this.LABEL3);
            this.panel1.Location = new System.Drawing.Point(198, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 505);
            this.panel1.TabIndex = 0;
            // 
            // LABEL11
            // 
            this.LABEL11.AutoSize = true;
            this.LABEL11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL11.ForeColor = System.Drawing.Color.DarkGray;
            this.LABEL11.Location = new System.Drawing.Point(46, 270);
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
            this.LABEL9.Location = new System.Drawing.Point(14, 320);
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
            this.LABEL8.Location = new System.Drawing.Point(50, 255);
            this.LABEL8.Name = "LABEL8";
            this.LABEL8.Size = new System.Drawing.Size(92, 15);
            this.LABEL8.TabIndex = 20;
            this.LABEL8.Text = "Gray: Complete";
            this.LABEL8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LABEL7
            // 
            this.LABEL7.AutoSize = true;
            this.LABEL7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL7.ForeColor = System.Drawing.Color.DarkGray;
            this.LABEL7.Location = new System.Drawing.Point(50, 240);
            this.LABEL7.Name = "LABEL7";
            this.LABEL7.Size = new System.Drawing.Size(67, 15);
            this.LABEL7.TabIndex = 19;
            this.LABEL7.Text = "Pink: Active";
            this.LABEL7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LABEL6
            // 
            this.LABEL6.AutoSize = true;
            this.LABEL6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL6.ForeColor = System.Drawing.Color.DarkGray;
            this.LABEL6.Location = new System.Drawing.Point(50, 225);
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
            this.LABEL5.Location = new System.Drawing.Point(14, 199);
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
            this.LABEL4.Location = new System.Drawing.Point(14, 159);
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
            this.LABEL3.Location = new System.Drawing.Point(36, 117);
            this.LABEL3.Name = "LABEL3";
            this.LABEL3.Size = new System.Drawing.Size(94, 19);
            this.LABEL3.TabIndex = 15;
            this.LABEL3.Text = "Instructions:";
            this.LABEL3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(558, 558);
            this.Controls.Add(this.LABEL1);
            this.Controls.Add(this.panelInitiative);
            this.Controls.Add(this.LABEL2);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "TTRPG Initiative Tracker";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelInitiative;
        private System.Windows.Forms.Label LABEL2;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label LABEL1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LABEL11;
        private System.Windows.Forms.Label LABEL9;
        private System.Windows.Forms.Label LABEL8;
        private System.Windows.Forms.Label LABEL7;
        private System.Windows.Forms.Label LABEL6;
        private System.Windows.Forms.Label LABEL5;
        private System.Windows.Forms.Label LABEL4;
        private System.Windows.Forms.Label LABEL3;
    }
}

