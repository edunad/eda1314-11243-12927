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

namespace Pepino_A_Star
{
    public partial class PathTime : Form
    {

        public delegate void AddNodeList(string txt);
        public delegate void ClearList();
        public delegate void SetMedia(string Text);

        public PathTime()
        {
            InitializeComponent();
        }

        private void PathTime_Load(object sender, EventArgs e)
        {
            GlobalStuff._timeMenu = this;
        }

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

        public void SetAverage(string text)
        {
            SetMedia SPH = new SetMedia(SetAverage);

            if (this.InvokeRequired)
            {
                this.Invoke(SPH, (string)text);
            }
            else
            {
   ﻿            this.TMedia.Text = text;
            }

        }

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
            }

        }

        private void updateTick_Tick(object sender, EventArgs e)
        {
            this.Location = new Point(GlobalStuff._pathMenu.Size.Width + GlobalStuff._pathMenu.Location.X + 5, GlobalStuff._pathMenu.Location.Y + 320);
        }

        private void BSave_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "" && ListNodeTime.Items.Count > 0)
            {
                StreamWriter wr = new StreamWriter(saveFileDialog.FileName);

                foreach(string cl in ListNodeTime.Items)
                    wr.WriteLine(cl);

                wr.WriteLine("\n==============================");
                wr.WriteLine("Media do Tempo : " + TMedia.Text);
                wr.WriteLine("==============================");

                wr.Close();
            }
        }
    }
}
