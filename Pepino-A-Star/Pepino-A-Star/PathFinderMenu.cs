using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pepino_A_Star
{
    public partial class PathFinderMenu : Form
    {

        public Thread _PathfinderThrd;

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

        private void LockControls()
        {
            BFind.Enabled = false;
            BFind.Text = "Calculating Path";

            TXEnd.Enabled = false;
            TXStart.Enabled = false;
            TYEnd.Enabled = false;
            TYStart.Enabled = false;
        }

        private void UnlockControls()
        {
            BFind.Enabled = true;
            BFind.Text = "Find Path";

            TXEnd.Enabled = true;
            TXStart.Enabled = true;
            TYEnd.Enabled = true;
            TYStart.Enabled = true;
        }

        private void BFind_Click(object sender, EventArgs e)
        {

            LockControls();

            Vector2 _start = new Vector2(Convert.ToInt32(TXStart.Text), Convert.ToInt32(TYStart.Text));
            Vector2 _end = new Vector2(Convert.ToInt32(TXEnd.Text), Convert.ToInt32(TYEnd.Text));

            Vector2[] _pos = new Vector2[] { _start,_end};

            Bitmap tmp = new Bitmap(PImage.Image);

            PixelUtilities.DrawSquare(tmp, _start, new Vector2(4, 4), Color.Green);
            PixelUtilities.DrawSquare(tmp, _end, new Vector2(4, 4), Color.Red);

            PImage.Image = tmp;

            _PathfinderThrd = new Thread(new ParameterizedThreadStart(FindPath));
            _PathfinderThrd.Name = "Path Finder Thread";
            _PathfinderThrd.Start((Object)_pos);


        }

        public void FindPath(Object obj)
        {
            if (((Vector2[])obj).Length < 2) return;

            Vector2 _startPoint = ((Vector2[])obj)[0];
            Vector2 _endPoint = ((Vector2[])obj)[1];


            // PATHFINDER CLASS HERE.

        }


        private void BClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
