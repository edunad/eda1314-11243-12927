namespace Pepino_A_Star
{
    partial class PGMExtremeLoader
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
            this.BarProg = new System.Windows.Forms.ProgressBar();
            this.LStatus = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarProg
            // 
            this.BarProg.Location = new System.Drawing.Point(12, 37);
            this.BarProg.Name = "BarProg";
            this.BarProg.Size = new System.Drawing.Size(376, 23);
            this.BarProg.TabIndex = 0;
            // 
            // LStatus
            // 
            this.LStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LStatus.Location = new System.Drawing.Point(0, 0);
            this.LStatus.Name = "LStatus";
            this.LStatus.Size = new System.Drawing.Size(376, 22);
            this.LStatus.TabIndex = 1;
            this.LStatus.Text = "Now Loading";
            this.LStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LStatus);
            this.panel1.Location = new System.Drawing.Point(12, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 22);
            this.panel1.TabIndex = 2;
            // 
            // PGMExtremeLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 72);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BarProg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PGMExtremeLoader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PGMExtremeLoader";
            this.Load += new System.EventHandler(this.PGMExtremeLoader_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar BarProg;
        private System.Windows.Forms.Label LStatus;
        private System.Windows.Forms.Panel panel1;
    }
}