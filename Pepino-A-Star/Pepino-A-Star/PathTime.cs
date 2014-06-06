using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Pepino_A_Star
{
    /// <summary>
    /// @author Eduardo Fernandes nº12927
    /// @author Damien Fialho nº11243
    /// 
    /// @date 06/06/1024
    /// @code https://code.google.com/p/eda1314-11243-12927/
    /// 
    /// The Time Menu
    /// </summary>
    /// 

    public partial class PathTime : Form
    {

        public delegate void AddTimeChart(double time);
        public delegate void AddNodeList(string txt);
        public delegate void ClearList();

        public float AnimPos;
        private int Styl = 0;

        public PathTime()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Start Menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PathTime_Load(object sender, EventArgs e)
        {
            GlobalStuff._timeMenu = this;
            this.TimeChart.Series["Node Time"].Color = Color.Red;
            this.TimeChart.Series["Node Time"].IsValueShownAsLabel = false;
            this.TimeChart.Series["Node Time"].IsVisibleInLegend = true;
            this.TimeChart.Series["Node Time"].BorderWidth = 2;

            TimeChart.Legends.Add(new Legend() { Name = "Legend" });
            TimeChart.Legends[0].Docking = Docking.Bottom;
            TimeChart.Palette = ChartColorPalette.BrightPastel;
            TimeChart.ChartAreas[0].BorderWidth = 0;

            this.TimeChart.Series["Node Time"].Points.Clear();
            
        }
        /// <summary>
        /// Adds Average to the chart
        /// </summary>
        /// <param name="time">The Average Time</param>
        public void AddChartPoint(double time)
        {
            AddTimeChart SPH = new AddTimeChart(AddChartPoint);

            if (this.InvokeRequired)
            {
                this.Invoke(SPH, (double)time);
            }
            else
            {
   ﻿             TimeChart.Series["Node Time"].Points.AddY(time);
            }

        }
        /// <summary>
        /// Adds the Node info to the comboBox
        /// </summary>
        /// <param name="text">Info</param>
        public void AddNodeInfo(string text)
        {
            AddNodeList SPH = new AddNodeList(AddNodeInfo);

            if (this.InvokeRequired)
            {
                this.Invoke(SPH, (string)text);
            }
            else
            {
   ﻿             ListNodeTime.Items.Add(text);
            }

        }

        /// <summary>
        /// Shows Animation
        /// </summary>
        public void DoShowAnimation()
        {
            Styl = 1;
            AnimPos = -this.Size.Width;
        }

        /// <summary>
        /// Shows Hide Animation
        /// </summary>
        public void DoHideAnimation()
        {
            Styl = -1;
        }

        /// <summary>
        /// Clears the Node List Information
        /// </summary>
        public void ClearNodeList()
        {
            ClearList SPH = new ClearList(ClearNodeList);

            if (this.InvokeRequired)
            {
                this.Invoke(SPH);
            }
            else
            {
   ﻿             ListNodeTime.Items.Clear();
                this.TimeChart.Series["Node Time"].Points.Clear();
            }

        }

        /// <summary>
        /// Update Tick.
        /// Animates the Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateTick_Tick(object sender, EventArgs e)
        {
            this.Location = new Point(GlobalStuff._pathMenu.Size.Width + GlobalStuff._pathMenu.Location.X + (int)AnimPos - 2, GlobalStuff._pathMenu.Location.Y + 320);

            if (Styl == 1)
            {
                if (AnimPos < 0)
                    AnimPos += 15;
                else
                    Styl = 0;
            }
            else if (Styl == -1)
            {
                if (AnimPos > -this.Size.Width)
                    AnimPos -= 15;
                else
                {
                    this.Hide();
                    Styl = 0;
                }
            }
        }

        /// <summary>
        /// Save Button, to save the data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BSave_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "" && ListNodeTime.Items.Count > 0)
            {
                StreamWriter wr = new StreamWriter(saveFileDialog.FileName);

                foreach(string cl in ListNodeTime.Items)
                    wr.WriteLine(cl);

                wr.WriteLine("\n==============================");

                foreach (string cl in GlobalStuff._mediaExperimental)
                    wr.WriteLine(cl);
                
                wr.Close();
            }
        }
    }
}
