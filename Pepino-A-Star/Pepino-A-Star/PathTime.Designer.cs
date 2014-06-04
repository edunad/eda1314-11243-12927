namespace Pepino_A_Star
{
    partial class PathTime
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
            this.ListNodeTime = new System.Windows.Forms.ListBox();
            this.updateTick = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.TMedia = new System.Windows.Forms.TextBox();
            this.BSave = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // ListNodeTime
            // 
            this.ListNodeTime.FormattingEnabled = true;
            this.ListNodeTime.Location = new System.Drawing.Point(12, 12);
            this.ListNodeTime.Name = "ListNodeTime";
            this.ListNodeTime.Size = new System.Drawing.Size(358, 199);
            this.ListNodeTime.TabIndex = 0;
            // 
            // updateTick
            // 
            this.updateTick.Enabled = true;
            this.updateTick.Interval = 1;
            this.updateTick.Tick += new System.EventHandler(this.updateTick_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Media dos Tempos : ";
            // 
            // TMedia
            // 
            this.TMedia.Enabled = false;
            this.TMedia.Location = new System.Drawing.Point(124, 217);
            this.TMedia.Name = "TMedia";
            this.TMedia.Size = new System.Drawing.Size(246, 20);
            this.TMedia.TabIndex = 2;
            // 
            // BSave
            // 
            this.BSave.Location = new System.Drawing.Point(15, 243);
            this.BSave.Name = "BSave";
            this.BSave.Size = new System.Drawing.Size(355, 23);
            this.BSave.TabIndex = 3;
            this.BSave.Text = "Save To File";
            this.BSave.UseVisualStyleBackColor = true;
            this.BSave.Click += new System.EventHandler(this.BSave_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "TXT|*.txt";
            this.saveFileDialog.Title = "Save Nodes Information";
            // 
            // PathTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 277);
            this.Controls.Add(this.BSave);
            this.Controls.Add(this.TMedia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListNodeTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PathTime";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "PathTime";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.PathTime_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer updateTick;
        public System.Windows.Forms.ListBox ListNodeTime;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TMedia;
        private System.Windows.Forms.Button BSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;

    }
}