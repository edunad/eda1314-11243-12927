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
            ((System.ComponentModel.ISupportInitialize)(this.PImage)).BeginInit();
            this.SuspendLayout();
            // 
            // PImage
            // 
            this.PImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PImage.Location = new System.Drawing.Point(12, 12);
            this.PImage.Name = "PImage";
            this.PImage.Size = new System.Drawing.Size(370, 328);
            this.PImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PImage.TabIndex = 0;
            this.PImage.TabStop = false;
            // 
            // BFind
            // 
            this.BFind.Location = new System.Drawing.Point(12, 346);
            this.BFind.Name = "BFind";
            this.BFind.Size = new System.Drawing.Size(272, 23);
            this.BFind.TabIndex = 1;
            this.BFind.Text = "Find Path";
            this.BFind.UseVisualStyleBackColor = true;
            this.BFind.Click += new System.EventHandler(this.BFind_Click);
            // 
            // BClose
            // 
            this.BClose.Location = new System.Drawing.Point(290, 346);
            this.BClose.Name = "BClose";
            this.BClose.Size = new System.Drawing.Size(92, 23);
            this.BClose.TabIndex = 2;
            this.BClose.Text = "Close";
            this.BClose.UseVisualStyleBackColor = true;
            this.BClose.Click += new System.EventHandler(this.BClose_Click);
            // 
            // PathFinderMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 377);
            this.Controls.Add(this.BClose);
            this.Controls.Add(this.BFind);
            this.Controls.Add(this.PImage);
            this.Name = "PathFinderMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pepino-A-Star .: Main Menu :.";
            this.Load += new System.EventHandler(this.PathFinder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PImage;
        private System.Windows.Forms.Button BFind;
        private System.Windows.Forms.Button BClose;
    }
}

