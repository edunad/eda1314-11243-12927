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
    /// The Loader and Image creator
    /// </summary>
    /// 

    public partial class PGMExtremeLoader : Form
    {

        public Thread _loadThread;

        public PGMExtremeLoader()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads the PGMLoader
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PGMExtremeLoader_Load(object sender, EventArgs e)
        {

            _loadThread = new Thread(LoadingThead);
            _loadThread.Start();

        }


        public delegate void SetProgressHandler(int i);
        public delegate void SetTextHandler(string txt);
        public delegate void SetContinueProgram();

        /// <summary>
        /// Shows the Conversion Progress
        /// </summary>
        /// <param name="pVal"></param>
        public void SetProgress(int pVal)
        {
            SetProgressHandler SPH = new SetProgressHandler(SetProgress);

            if (this.InvokeRequired)
            {
                this.Invoke(SPH, (int)pVal);
            }
            else
            {
                if (pVal <= 100)
   ﻿                BarProg.Value = pVal;
            }

        }

        /// <summary>
        /// Shows the Conversion Percentage and information
        /// </summary>
        /// <param name="text"></param>
        public void SetText(string text)
        {
            try
            {
                SetTextHandler SPH = new SetTextHandler(SetText);

                if (this.InvokeRequired)
                {
                    this.Invoke(SPH, (string)text);
                }
                else
                {
   ﻿             LStatus.Text = text;
                }
            }
            catch { }

        }

        /// <summary>
        /// Continues Program
        /// </summary>
        public void ContinueProgram()
        {
            SetContinueProgram SPH = new SetContinueProgram(ContinueProgram);

            if (this.InvokeRequired)
            {
                this.Invoke(SPH);
            }
            else
            {
   ﻿             this.Close();
            }

        }

        /// <summary>
        /// Checks if the PGM Exists
        /// Checks if the bmp Exists
        /// If not, creates it.
        /// </summary>
        public void LoadingThead()
        {

            if (!Directory.Exists("Texture"))
                Directory.CreateDirectory("Texture");

            if (File.Exists("Texture/el_pepino.bmp"))
            {
                SetText("Image Found!");
                Thread.Sleep(1000);

                GlobalStuff._OriginalImage = new Bitmap("Texture/el_pepino.bmp");
                ContinueProgram();

                return;
            }

            SetText("Image Not Found! Checking peppersgrad.pgm ..");
            Thread.Sleep(2000);

            if (!File.Exists("Texture/peppersgrad.pgm"))
            {
                SetText("PGM Not Found! Impossible to Continue!");
                Thread.Sleep(2000);
                Process.GetCurrentProcess().Kill();
            }

            SetText("Creating el_pepino.bmp ..");
            Thread.Sleep(2000);

            #region CreateImage

            int Width = 0;
            int Height = 0;

            int X = 0;
            int Y = 0;

            Bitmap _image = null;

            string[] lines = File.ReadAllLines("Texture/peppersgrad.pgm");
            int Indx = 0;

            foreach (string line in lines)
            {

                if (line == "") continue;

                if (Indx == 2)
                {
                    string[] size = line.Split(' ');
                    Width = Convert.ToInt32(size[0]);
                    Height = Convert.ToInt32(size[1]);

                    _image = new Bitmap(Width, Height);
                }
                else if (Indx > 4)
                {
                    if (_image == null) break;

                    if (X < Width - 1)
                        X += 1;
                    else
                    {
                        X = 0;
                        Y += 1;
                    }

                    if (Y > Height - 1) break;

                    byte Clr = Convert.ToByte(line);
                    _image.SetPixel(X, Y, Color.FromArgb(Clr, Clr, Clr));
                }

                Indx += 1;
                int Prog = (Indx * 100) / lines.Count();

                SetText("Creating el_pepino.bmp ( " + Prog + "% )");
                SetProgress(Prog);
            }

            if (_image != null)
                if (!_image.Size.IsEmpty)
                    _image.Save("Texture/el_pepino.bmp", System.Drawing.Imaging.ImageFormat.Bmp);


            GlobalStuff._OriginalImage = _image;
            ContinueProgram();

            #endregion

        }

    }
}
