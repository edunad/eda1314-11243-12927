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

    /// <summary>
    /// @author Eduardo Fernandes nº12927
    /// @author Damien Fialho nº11243
    /// 
    /// @date 06/06/1024
    /// @code https://code.google.com/p/eda1314-11243-12927/
    /// 
    /// The program's main menu, where the user can choose the many options to costumize and control the pathfinding.
    /// </summary>

    public partial class PathFinderMenu : Form
    {

        public Thread _PathfinderThrd;
        public delegate void SetTextHandler(string txt);
        public delegate void SetImageHandler(Bitmap img);
        public delegate void FinishPath();

        public bool ToggleMenu;
        public bool ToggleClock;


        public PathFinderMenu()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Prepares the main menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            GlobalStuff._timeMenu.Hide();

            GlobalStuff._loadMenu = new PGMExtremeLoader();
            GlobalStuff._loadMenu.ShowDialog();

            if (GlobalStuff._OriginalImage == null)
                Process.GetCurrentProcess().Kill();


            GlobalStuff.Width = GlobalStuff._OriginalImage.Width;
            GlobalStuff.Height = GlobalStuff._OriginalImage.Height;

            POverlay.Parent = PImage;
            POverlay.BackColor = Color.FromArgb(0, 255, 255, 255);
            POverlay.Dock = DockStyle.Fill;

            if (GlobalStuff._OriginalImage != null)
                PImage.Image = GlobalStuff._OriginalImage;
            

        }

        /// <summary>
        /// Sets the text on the button
        /// </summary>
        /// <param name="text"></param>
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

        /// <summary>
        /// Tells the program that the pathfinding is done.
        /// </summary>
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

        /// <summary>
        /// Changes the pathfinding Image.
        /// Used to Create the path.
        /// </summary>
        /// <param name="img"></param>
        /// 
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

        /// <summary>
        /// Locks all the controls
        /// </summary>
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

            ToggleClock = false;
            GlobalStuff._timeMenu.Hide();
            BTime.Image = Properties.Resources.clock;

            BSettings.Hide();
            BDelete.Hide();
            BTime.Hide();
        }

        /// <summary>
        /// Unlocks the controls
        /// </summary>
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
            BTime.Show();
        }

        /// <summary>
        /// Starts the Finding.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Created on a new thread.
        /// Prepares the pathfinder to find the given paths.
        /// </summary>
        /// <param name="obj"></param>
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

            Node start = new Node(_startPoint);
            Node end = new Node(_endPoint);

            int ExperimentalTimes = 5;
            int MaxSteps = 20;

            GlobalStuff._timeMenu.ClearNodeList();
            GlobalStuff._mediaExperimental = new List<string>();


            while (true)
            {
                if (MaxSteps == 0) break;

                double md = GetAverageCicles(ExperimentalTimes, start, end, MaxSteps);

                GlobalStuff._timeMenu.AddChartPoint(md);
                GlobalStuff._timeMenu.AddNodeInfo(ExperimentalTimes + " * Tests per " + MaxSteps + " -> Average : " + md.ToString("0.000000"));

                MaxSteps -= 4;
            }
            
            Node Tmp = end;

            while (true)
            {
                if (Tmp._parent == null) break;

                _pathPreview.SetPixel(Tmp._pos.X, Tmp._pos.Y, GlobalStuff._pathColor);
                SetImagePreview(_pathPreview);

                Tmp = Tmp._parent;
            }

            SetPathFinished();
        }

        /// <summary>
        /// Generates the Results.
        /// </summary>
        /// <param name="NCicle">Number of experiments</param>
        /// <param name="_startPoint">Start node</param>
        /// <param name="_endPoint">End node</param>
        /// <param name="Step">Steps per experiment</param>
        /// <returns></returns>
        /// 
        private double GetAverageCicles(int NCicle, Node _startPoint, Node _endPoint, int Step)
        {
            double mediaFinal = 0;

            for (int I = 0; I < NCicle; I++)
            {
                double media = AStarPathFinder.FindPath(_startPoint, _endPoint, Step);
                GlobalStuff._mediaExperimental.Add("Cicle " + I + " - Step : " + Step + " - Average Per Step : " + media.ToString("0.000000"));
                mediaFinal += media; 

            }

            return (double)(mediaFinal / NCicle);
        }
        /// <summary>
        /// Closes the menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Opens the settings menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Cleans the Image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BDelete_Click(object sender, EventArgs e)
        {
            Bitmap _pathPreview = new Bitmap(100,100);
            SetImagePreview(_pathPreview);
        }

        /// <summary>
        /// Opens the Time Menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTime_Click(object sender, EventArgs e)
        {
            if (!ToggleClock)
            {
                GlobalStuff._timeMenu.Show();
                GlobalStuff._timeMenu.DoShowAnimation();
                BTime.Image = Properties.Resources.clock_red;
            }
            else
            {
                GlobalStuff._timeMenu.DoHideAnimation();
                BTime.Image = Properties.Resources.clock;
            }

            this.Focus();

            ToggleClock = !ToggleClock;
        }
    }
}
