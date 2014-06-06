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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.ListNodeTime = new System.Windows.Forms.ListBox();
            this.updateTick = new System.Windows.Forms.Timer(this.components);
            this.BSave = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.TimeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.TimeChart)).BeginInit();
            this.SuspendLayout();
            // 
            // ListNodeTime
            // 
            this.ListNodeTime.FormattingEnabled = true;
            this.ListNodeTime.Location = new System.Drawing.Point(12, 12);
            this.ListNodeTime.Name = "ListNodeTime";
            this.ListNodeTime.Size = new System.Drawing.Size(201, 225);
            this.ListNodeTime.TabIndex = 0;
            // 
            // updateTick
            // 
            this.updateTick.Enabled = true;
            this.updateTick.Interval = 1;
            this.updateTick.Tick += new System.EventHandler(this.updateTick_Tick);
            // 
            // BSave
            // 
            this.BSave.Location = new System.Drawing.Point(15, 243);
            this.BSave.Name = "BSave";
            this.BSave.Size = new System.Drawing.Size(198, 23);
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
            // TimeChart
            // 
            chartArea1.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea1.Name = "ChartArea1";
            this.TimeChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.TimeChart.Legends.Add(legend1);
            this.TimeChart.Location = new System.Drawing.Point(219, 12);
            this.TimeChart.Name = "TimeChart";
            this.TimeChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.MarkerBorderWidth = 34;
            series1.MarkerColor = System.Drawing.Color.White;
            series1.Name = "Node Time";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValuesPerPoint = 2;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.TimeChart.Series.Add(series1);
            this.TimeChart.Size = new System.Drawing.Size(293, 253);
            this.TimeChart.TabIndex = 4;
            this.TimeChart.Text = "Node Time";
            title1.Name = "TI";
            title1.Text = "Experimental Time";
            this.TimeChart.Titles.Add(title1);
            // 
            // PathTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 277);
            this.Controls.Add(this.TimeChart);
            this.Controls.Add(this.BSave);
            this.Controls.Add(this.ListNodeTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PathTime";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "PathTime";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.PathTime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TimeChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer updateTick;
        public System.Windows.Forms.ListBox ListNodeTime;
        private System.Windows.Forms.Button BSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.DataVisualization.Charting.Chart TimeChart;

    }
}