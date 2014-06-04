using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
        public delegate void SetTextHandler(string txt);
        public delegate void SetImageHandler(Bitmap img);
        public delegate void FinishPath();

        public bool ToggleMenu;

        public PathFinderMenu()
        {
            InitializeComponent();
        }

        private void PathFinder_Load(object sender, EventArgs e)
        {
            GlobalStuff._pathMenu = this;

            if (GlobalStuff._panelSettings == null)
                GlobalStuff._panelSettings = new PathSettings();

            if (GlobalStuff._timeMenu == null)
                GlobalStuff._timeMenu = new PathTime();

            GlobalStuff._panelSettings.Show();
            GlobalStuff._panelSettings.Hide();

            GlobalStuff._timeMenu.Show();

            GlobalStuff._loadMenu = new PGMExtremeLoader();
            GlobalStuff._loadMenu.ShowDialog();

            GlobalStuff.Width = GlobalStuff._OriginalImage.Width;
            GlobalStuff.Height = GlobalStuff._OriginalImage.Height;

            POverlay.Parent = PImage;
            POverlay.BackColor = Color.FromArgb(0, 255, 255, 255);
            POverlay.Dock = DockStyle.Fill;

            if (GlobalStuff._OriginalImage != null)
                PImage.Image = GlobalStuff._OriginalImage;
            

        }

        public void SetText(string text)
        {
            SetTextHandler SPH = new SetTextHandler(SetText);

            if (this.InvokeRequired)
            {
                this.Invoke(SPH, (string)text);
            }
            else
            {
   ﻿             BFind.Text = text;
            }

        }

        public void SetPathFinished()
        {
            FinishPath SPH = new FinishPath(SetPathFinished);

            if (this.InvokeRequired)
            {
                this.Invoke(SPH);
            }
            else
            {
                UnlockControls();
            }

        }


        public void SetImagePreview(Bitmap img)
        {
            SetImageHandler SPH = new SetImageHandler(SetImagePreview);

            if (this.InvokeRequired)
            {
                this.Invoke(SPH, (Bitmap)img);
            }
            else
            {
                POverlay.Image = img;
            }

        }

        private void LockControls()
        {
            BFind.Enabled = false;
            BFind.Text = "Calculating Path";

            GlobalStuff._panelSettings.TXEnd.Enabled = false;
            GlobalStuff._panelSettings.TXStart.Enabled = false;
            GlobalStuff._panelSettings.TYEnd.Enabled = false;
            GlobalStuff._panelSettings.TYStart.Enabled = false;

            ToggleMenu = false;
            GlobalStuff._panelSettings.Hide();
            BSettings.Image = Properties.Resources.wrench;

            BSettings.Hide();
            BDelete.Hide();
        }

        private void UnlockControls()
        {
            BFind.Enabled = true;
            BFind.Text = "Find Path";

            GlobalStuff._panelSettings.TXEnd.Enabled = true;
            GlobalStuff._panelSettings.TXStart.Enabled = true;
            GlobalStuff._panelSettings.TYEnd.Enabled = true;
            GlobalStuff._panelSettings.TYStart.Enabled = true;

            BSettings.Show();
            BDelete.Show();
        }

        private void BFind_Click(object sender, EventArgs e)
        {

            LockControls();

            Vector2 _start = new Vector2(Convert.ToInt32(GlobalStuff._panelSettings.TXStart.Text), Convert.ToInt32(GlobalStuff._panelSettings.TYStart.Text));
            Vector2 _end = new Vector2(Convert.ToInt32(GlobalStuff._panelSettings.TXEnd.Text), Convert.ToInt32(GlobalStuff._panelSettings.TYEnd.Text));

            Vector2[] _pos = new Vector2[] { _start, _end };

            _PathfinderThrd = new Thread(new ParameterizedThreadStart(FindPath));
            _PathfinderThrd.Name = "Path Finder Thread";
            _PathfinderThrd.Start((Object)_pos);
            

        }

        public void FindPath(Object obj)
        {
            if (((Vector2[])obj).Length < 2) return;

            Vector2 _startPoint = ((Vector2[])obj)[0];
            Vector2 _endPoint = ((Vector2[])obj)[1];

            string[] lines = File.ReadAllLines("Texture/peppersgrad.pgm");
            GlobalStuff._pgmData = new byte[GlobalStuff.Width * GlobalStuff.Height];

            Bitmap _pathPreview = new Bitmap(GlobalStuff.Width, GlobalStuff.Height);

            PixelUtilities.DrawSquare(_pathPreview, _startPoint, new Vector2(4, 4), Color.Green);
            PixelUtilities.DrawSquare(_pathPreview, _endPoint, new Vector2(4, 4), Color.Red);

            SetImagePreview(_pathPreview);

            int indx = 0;

            foreach (string line in lines){
                if (indx > 4 && line != "")
                    GlobalStuff._pgmData[indx - 4] = Convert.ToByte(line);
                indx++;
            }

            AStarPathFinder.FindPath(new Node(_startPoint), new Node(_endPoint), _pathPreview);

        }

        private void BClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void POverlay_Click(object sender, EventArgs e)
        {

        }

        private void BSettings_Click(object sender, EventArgs e)
        {
            if (!ToggleMenu)
            {
                GlobalStuff._panelSettings.Show();
                GlobalStuff._panelSettings.DoShowAnimation();
                BSettings.Image = Properties.Resources.wrench_orange;
            }
            else
            {
                GlobalStuff._panelSettings.DoHideAnimation();
                BSettings.Image = Properties.Resources.wrench;
            }

            this.Focus();
            ToggleMenu = !ToggleMenu;

        }

        private void BDelete_Click(object sender, EventArgs e)
        {
            Bitmap _pathPreview = new Bitmap(100,100);
            SetImagePreview(_pathPreview);
        }
    }
}
