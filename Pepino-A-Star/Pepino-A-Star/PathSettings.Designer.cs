namespace Pepino_A_Star
{
    partial class PathSettings
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
            this.GSettings = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TYStart = new System.Windows.Forms.TextBox();
            this.TYEnd = new System.Windows.Forms.TextBox();
            this.TXEnd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXStart = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.updateTick = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CHeurisitc = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DrawNeighh = new System.Windows.Forms.CheckBox();
            this.BPathColor = new System.Windows.Forms.Button();
            this.PPathColor = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.colorDialog_Path = new System.Windows.Forms.ColorDialog();
            this.GSettings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // GSettings
            // 
            this.GSettings.Controls.Add(this.label5);
            this.GSettings.Controls.Add(this.label4);
            this.GSettings.Controls.Add(this.TYStart);
            this.GSettings.Controls.Add(this.TYEnd);
            this.GSettings.Controls.Add(this.TXEnd);
            this.GSettings.Controls.Add(this.label2);
            this.GSettings.Controls.Add(this.TXStart);
            this.GSettings.Controls.Add(this.label1);
            this.GSettings.Location = new System.Drawing.Point(5, 4);
            this.GSettings.Name = "GSettings";
            this.GSettings.Size = new System.Drawing.Size(155, 104);
            this.GSettings.TabIndex = 4;
            this.GSettings.TabStop = false;
            this.GSettings.Text = "Pathfinder Points";
            this.GSettings.Enter += new System.EventHandler(this.GSettings_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "X";
            // 
            // TYStart
            // 
            this.TYStart.Location = new System.Drawing.Point(97, 41);
            this.TYStart.Name = "TYStart";
            this.TYStart.Size = new System.Drawing.Size(47, 20);
            this.TYStart.TabIndex = 6;
            this.TYStart.Text = "48";
            this.TYStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TYEnd
            // 
            this.TYEnd.Location = new System.Drawing.Point(97, 67);
            this.TYEnd.Name = "TYEnd";
            this.TYEnd.Size = new System.Drawing.Size(47, 20);
            this.TYEnd.TabIndex = 5;
            this.TYEnd.Text = "508";
            this.TYEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXEnd
            // 
            this.TXEnd.Location = new System.Drawing.Point(44, 67);
            this.TXEnd.Name = "TXEnd";
            this.TXEnd.Size = new System.Drawing.Size(47, 20);
            this.TXEnd.TabIndex = 3;
            this.TXEnd.Text = "260";
            this.TXEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "End : ";
            // 
            // TXStart
            // 
            this.TXStart.Location = new System.Drawing.Point(44, 41);
            this.TXStart.Name = "TXStart";
            this.TXStart.Size = new System.Drawing.Size(47, 20);
            this.TXStart.TabIndex = 1;
            this.TXStart.Text = "192";
            this.TXStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start : ";
            // 
            // updateTick
            // 
            this.updateTick.Interval = 1;
            this.updateTick.Tick += new System.EventHandler(this.updateTick_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CHeurisitc);
            this.groupBox1.Location = new System.Drawing.Point(5, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 53);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pathfinder Heuristic Formula";
            // 
            // CHeurisitc
            // 
            this.CHeurisitc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CHeurisitc.FormattingEnabled = true;
            this.CHeurisitc.Items.AddRange(new object[] {
            "Manhattan",
            "Euclidean"});
            this.CHeurisitc.Location = new System.Drawing.Point(14, 19);
            this.CHeurisitc.MaxDropDownItems = 3;
            this.CHeurisitc.Name = "CHeurisitc";
            this.CHeurisitc.Size = new System.Drawing.Size(130, 21);
            this.CHeurisitc.TabIndex = 0;
            this.CHeurisitc.SelectedIndexChanged += new System.EventHandler(this.CHeurisitc_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DrawNeighh);
            this.groupBox2.Controls.Add(this.BPathColor);
            this.groupBox2.Controls.Add(this.PPathColor);
            this.groupBox2.Location = new System.Drawing.Point(5, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(155, 73);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pathfinder Other Settings";
            // 
            // DrawNeighh
            // 
            this.DrawNeighh.AutoSize = true;
            this.DrawNeighh.Location = new System.Drawing.Point(24, 49);
            this.DrawNeighh.Name = "DrawNeighh";
            this.DrawNeighh.Size = new System.Drawing.Size(104, 17);
            this.DrawNeighh.TabIndex = 2;
            this.DrawNeighh.Text = "Show Neighbors";
            this.DrawNeighh.UseVisualStyleBackColor = true;
            this.DrawNeighh.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // BPathColor
            // 
            this.BPathColor.Location = new System.Drawing.Point(36, 19);
            this.BPathColor.Name = "BPathColor";
            this.BPathColor.Size = new System.Drawing.Size(108, 23);
            this.BPathColor.TabIndex = 1;
            this.BPathColor.Text = "Select Path Color";
            this.BPathColor.UseVisualStyleBackColor = true;
            this.BPathColor.Click += new System.EventHandler(this.BPathColor_Click);
            // 
            // PPathColor
            // 
            this.PPathColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PPathColor.Location = new System.Drawing.Point(6, 19);
            this.PPathColor.Name = "PPathColor";
            this.PPathColor.Size = new System.Drawing.Size(24, 24);
            this.PPathColor.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(5, 252);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(155, 57);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Credits";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Damien Fialho nº11243";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Eduardo Fernandes nº12927";
            // 
            // colorDialog_Path
            // 
            this.colorDialog_Path.Color = System.Drawing.Color.Aqua;
            // 
            // PathSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(165, 316);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PathSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "PathSettings";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.PathSettings_Load);
            this.GSettings.ResumeLayout(false);
            this.GSettings.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GSettings;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TYStart;
        public System.Windows.Forms.TextBox TYEnd;
        public System.Windows.Forms.TextBox TXEnd;
        public System.Windows.Forms.TextBox TXStart;
        private System.Windows.Forms.Timer updateTick;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox CHeurisitc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BPathColor;
        private System.Windows.Forms.Panel PPathColor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ColorDialog colorDialog_Path;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox DrawNeighh;
    }
}