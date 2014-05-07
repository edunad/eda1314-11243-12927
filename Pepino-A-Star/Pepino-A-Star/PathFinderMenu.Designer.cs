namespace Pepino_A_Star
{
    partial class PathFinderMenu
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
            this.PImage = new System.Windows.Forms.PictureBox();
            this.BFind = new System.Windows.Forms.Button();
            this.BClose = new System.Windows.Forms.Button();
            this.GSettings = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TYStart = new System.Windows.Forms.TextBox();
            this.TYEnd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXEnd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXStart = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PImage)).BeginInit();
            this.GSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // PImage
            // 
            this.PImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PImage.Location = new System.Drawing.Point(12, 12);
            this.PImage.Name = "PImage";
            this.PImage.Size = new System.Drawing.Size(512, 512);
            this.PImage.TabIndex = 0;
            this.PImage.TabStop = false;
            // 
            // BFind
            // 
            this.BFind.Location = new System.Drawing.Point(12, 530);
            this.BFind.Name = "BFind";
            this.BFind.Size = new System.Drawing.Size(414, 23);
            this.BFind.TabIndex = 1;
            this.BFind.Text = "Find Path";
            this.BFind.UseVisualStyleBackColor = true;
            this.BFind.Click += new System.EventHandler(this.BFind_Click);
            // 
            // BClose
            // 
            this.BClose.Location = new System.Drawing.Point(432, 530);
            this.BClose.Name = "BClose";
            this.BClose.Size = new System.Drawing.Size(92, 23);
            this.BClose.TabIndex = 2;
            this.BClose.Text = "Close";
            this.BClose.UseVisualStyleBackColor = true;
            this.BClose.Click += new System.EventHandler(this.BClose_Click);
            // 
            // GSettings
            // 
            this.GSettings.Controls.Add(this.label5);
            this.GSettings.Controls.Add(this.label4);
            this.GSettings.Controls.Add(this.TYStart);
            this.GSettings.Controls.Add(this.TYEnd);
            this.GSettings.Controls.Add(this.label3);
            this.GSettings.Controls.Add(this.TXEnd);
            this.GSettings.Controls.Add(this.label2);
            this.GSettings.Controls.Add(this.TXStart);
            this.GSettings.Controls.Add(this.label1);
            this.GSettings.Location = new System.Drawing.Point(530, 12);
            this.GSettings.Name = "GSettings";
            this.GSettings.Size = new System.Drawing.Size(127, 328);
            this.GSettings.TabIndex = 3;
            this.GSettings.TabStop = false;
            this.GSettings.Text = "PathFinder Settings";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "X";
            // 
            // TYStart
            // 
            this.TYStart.Location = new System.Drawing.Point(80, 61);
            this.TYStart.Name = "TYStart";
            this.TYStart.Size = new System.Drawing.Size(35, 20);
            this.TYStart.TabIndex = 6;
            this.TYStart.Text = "48";
            // 
            // TYEnd
            // 
            this.TYEnd.Location = new System.Drawing.Point(80, 87);
            this.TYEnd.Name = "TYEnd";
            this.TYEnd.Size = new System.Drawing.Size(35, 20);
            this.TYEnd.TabIndex = 5;
            this.TYEnd.Text = "508";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "---- PathFinding Points ---";
            // 
            // TXEnd
            // 
            this.TXEnd.Location = new System.Drawing.Point(39, 87);
            this.TXEnd.Name = "TXEnd";
            this.TXEnd.Size = new System.Drawing.Size(35, 20);
            this.TXEnd.TabIndex = 3;
            this.TXEnd.Text = "260";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "End : ";
            // 
            // TXStart
            // 
            this.TXStart.Location = new System.Drawing.Point(39, 61);
            this.TXStart.Name = "TXStart";
            this.TXStart.Size = new System.Drawing.Size(35, 20);
            this.TXStart.TabIndex = 1;
            this.TXStart.Text = "192";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start : ";
            // 
            // PathFinderMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 558);
            this.Controls.Add(this.GSettings);
            this.Controls.Add(this.BClose);
            this.Controls.Add(this.BFind);
            this.Controls.Add(this.PImage);
            this.Name = "PathFinderMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pepino-A-Star .: Main Menu :.";
            this.Load += new System.EventHandler(this.PathFinder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PImage)).EndInit();
            this.GSettings.ResumeLayout(false);
            this.GSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PImage;
        private System.Windows.Forms.Button BFind;
        private System.Windows.Forms.Button BClose;
        private System.Windows.Forms.GroupBox GSettings;
        private System.Windows.Forms.TextBox TYStart;
        private System.Windows.Forms.TextBox TYEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

