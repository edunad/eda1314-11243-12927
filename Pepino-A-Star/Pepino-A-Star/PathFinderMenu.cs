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
    public partial class PathFinderMenu : Form
    {
        public PathFinderMenu()
        {
            InitializeComponent();
        }

        private void PathFinder_Load(object sender, EventArgs e)
        {
            GlobalStuff._pathMenu = this;

            GlobalStuff._loadMenu = new PGMExtremeLoader();
            GlobalStuff._loadMenu.ShowDialog();

            if (GlobalStuff._image != null)
                PImage.Image = GlobalStuff._image;

        }

        private void BFind_Click(object sender, EventArgs e)
        {

        }

        private void BClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
