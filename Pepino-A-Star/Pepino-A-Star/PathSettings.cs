using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pepino_A_Star
{
    public partial class PathSettings : Form
    {

        public float AnimPos;
        private int Styl = 0;

        public PathSettings()
        {
            InitializeComponent();
        }

        private void PathSettings_Load(object sender, EventArgs e)
        {
            GlobalStuff._panelSettings = this;
            GlobalStuff._pathColor = Color.Aqua;

            PPathColor.BackColor = GlobalStuff._pathColor;
            CHeurisitc.SelectedIndex = 1;

            updateTick.Enabled = true;
            updateTick.Start();

        }

        public void DoShowAnimation()
        {
            Styl = 1;
            AnimPos = -this.Size.Width;
        }

        public void DoHideAnimation()
        {
            Styl = -1;
        }

        private void updateTick_Tick(object sender, EventArgs e)
        {
            this.Location = new Point(GlobalStuff._pathMenu.Size.Width + GlobalStuff._pathMenu.Location.X + (int)AnimPos, GlobalStuff._pathMenu.Location.Y);

            if (Styl == 1)
            {
                if (AnimPos < 0)
                    AnimPos += 10;
                else
                    Styl = 0;
            }
            else if(Styl == -1)
            {
                if (AnimPos > -this.Size.Width)
                    AnimPos -= 10;
                else
                {
                    this.Hide();
                    Styl = 0;
                }
            }
        }

        private void BPathColor_Click(object sender, EventArgs e)
        {
            colorDialog_Path.ShowDialog();
            GlobalStuff._pathColor = colorDialog_Path.Color;
            PPathColor.BackColor = GlobalStuff._pathColor;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            GlobalStuff._drawNeigbor = DrawNeighh.Checked;
        }

        private void GSettings_Enter(object sender, EventArgs e)
        {

        }

        private void CHeurisitc_SelectedIndexChanged(object sender, EventArgs e)
        {
            GlobalStuff._heuristicMODE = CHeurisitc.SelectedIndex;
        }
    }
}
