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
    /// <summary>
    /// @author Eduardo Fernandes nº12927
    /// @author Damien Fialho nº11243
    /// 
    /// @date 06/06/1024
    /// @code https://code.google.com/p/eda1314-11243-12927/
    /// 
    /// The Settings Menu
    /// </summary>
    /// 
    public partial class PathSettings : Form
    {

        public float AnimPos;
        private int Styl = 0;

        public PathSettings()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Settings Menu load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PathSettings_Load(object sender, EventArgs e)
        {
            GlobalStuff._panelSettings = this;
            GlobalStuff._pathColor = Color.Aqua;

            PPathColor.BackColor = GlobalStuff._pathColor;
            CHeurisitc.SelectedIndex = 1;

            updateTick.Enabled = true;
            updateTick.Start();

        }

        /// <summary>
        /// Show Animation
        /// </summary>
        public void DoShowAnimation()
        {
            Styl = 1;
            AnimPos = -this.Size.Width;
        }

        /// <summary>
        /// Hide Animation
        /// </summary>
        public void DoHideAnimation()
        {
            Styl = -1;
        }

        /// <summary>
        /// Update Location
        /// Animate Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateTick_Tick(object sender, EventArgs e)
        {
            this.Location = new Point(GlobalStuff._pathMenu.Size.Width + GlobalStuff._pathMenu.Location.X + (int)AnimPos + 4, GlobalStuff._pathMenu.Location.Y);

            if (Styl == 1)
            {
                if (AnimPos < 0)
                    AnimPos += 15;
                else
                    Styl = 0;
            }
            else if(Styl == -1)
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
        /// The Path Color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BPathColor_Click(object sender, EventArgs e)
        {
            colorDialog_Path.ShowDialog();
            GlobalStuff._pathColor = colorDialog_Path.Color;
            PPathColor.BackColor = GlobalStuff._pathColor;
        }

        /// <summary>
        /// Selected Heuristic
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CHeurisitc_SelectedIndexChanged(object sender, EventArgs e)
        {
            GlobalStuff._heuristicMODE = CHeurisitc.SelectedIndex;
        }
    }
}
