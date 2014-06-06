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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PathFinderMenu));
            this.BFind = new System.Windows.Forms.Button();
            this.BClose = new System.Windows.Forms.Button();
            this.BTime = new System.Windows.Forms.Button();
            this.BDelete = new System.Windows.Forms.Button();
            this.BSettings = new System.Windows.Forms.Button();
            this.POverlay = new System.Windows.Forms.PictureBox();
            this.PImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.POverlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PImage)).BeginInit();
            this.SuspendLayout();
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
            // BTime
            // 
            this.BTime.Image = global::Pepino_A_Star.Properties.Resources.clock;
            this.BTime.Location = new System.Drawing.Point(497, 36);
            this.BTime.Name = "BTime";
            this.BTime.Size = new System.Drawing.Size(26, 24);
            this.BTime.TabIndex = 13;
            this.BTime.UseVisualStyleBackColor = true;
            this.BTime.Click += new System.EventHandler(this.BTime_Click);
            // 
            // BDelete
            // 
            this.BDelete.Image = global::Pepino_A_Star.Properties.Resources.asterisk_yellow;
            this.BDelete.Location = new System.Drawing.Point(497, 66);
            this.BDelete.Name = "BDelete";
            this.BDelete.Size = new System.Drawing.Size(26, 24);
            this.BDelete.TabIndex = 12;
            this.BDelete.UseVisualStyleBackColor = true;
            this.BDelete.Click += new System.EventHandler(this.BDelete_Click);
            // 
            // BSettings
            // 
            this.BSettings.Image = global::Pepino_A_Star.Properties.Resources.wrench;
            this.BSettings.Location = new System.Drawing.Point(497, 13);
            this.BSettings.Name = "BSettings";
            this.BSettings.Size = new System.Drawing.Size(26, 24);
            this.BSettings.TabIndex = 11;
            this.BSettings.UseVisualStyleBackColor = true;
            this.BSettings.Click += new System.EventHandler(this.BSettings_Click);
            // 
            // POverlay
            // 
            this.POverlay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.POverlay.Location = new System.Drawing.Point(12, 12);
            this.POverlay.Name = "POverlay";
            this.POverlay.Size = new System.Drawing.Size(512, 512);
            this.POverlay.TabIndex = 4;
            this.POverlay.TabStop = false;
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
            // PathFinderMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 558);
            this.Controls.Add(this.BTime);
            this.Controls.Add(this.BDelete);
            this.Controls.Add(this.BSettings);
            this.Controls.Add(this.POverlay);
            this.Controls.Add(this.BClose);
            this.Controls.Add(this.BFind);
            this.Controls.Add(this.PImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PathFinderMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pepino-A-Star .: Main Menu :.";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.PathFinder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.POverlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PImage;
        private System.Windows.Forms.Button BFind;
        private System.Windows.Forms.Button BClose;
        private System.Windows.Forms.PictureBox POverlay;
        private System.Windows.Forms.Button BSettings;
        private System.Windows.Forms.Button BDelete;
        private System.Windows.Forms.Button BTime;
    }
}

