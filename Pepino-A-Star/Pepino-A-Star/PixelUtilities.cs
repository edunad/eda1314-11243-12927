using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Pepino_A_Star
{
    /// <summary>
    /// @author Eduardo Fernandes nº12927

    {
        /// <summary>
        /// Faster Method to get the Color from the given pixel
        /// </summary>
        /// <param name="bmp">The Bitmap</param>
        /// <param name="x">X Position</param>
        /// <param name="y">Y Position</param>
        /// <returns>Pixel Color</returns>
        public static Color GetPixel(Bitmap bmp, int x, int y)
        {
            lock (bmp)
            {
                Rectangle _rct = new Rectangle(0, 0, bmp.Width, bmp.Height);
                BitmapData _data = bmp.LockBits(_rct, ImageLockMode.ReadWrite, bmp.PixelFormat);

                IntPtr btpPointer = _data.Scan0;
                int _byts = (bmp.Width * bmp.Height) * 4;
                byte[] rgbValues = new byte[_byts - 1];

                Marshal.Copy(btpPointer, rgbValues, 0, rgbValues.Length);

                int Index = ((y * bmp.Width) + x) * 4;

                int b = rgbValues[Index];
                int g = rgbValues[Index + 1];
                int r = rgbValues[Index + 2];
                int a = rgbValues[Index + 3];

                bmp.UnlockBits(_data);

                return Color.FromArgb(r, g, b);
            }
        }

        /// <summary>
        /// Draws a square on the bitmap
        /// </summary>
        /// <param name="bmp">The Image</param>
        /// <param name="_pos">Position to Draw</param>
        /// <param name="_size">Size</param>
        /// <param name="cl">Color</param>
        public static void DrawSquare(Bitmap bmp, Vector2 _pos, Vector2 _size, Color cl)
        {
            Graphics gStored = Graphics.FromImage(bmp);

            gStored.FillRectangle(new SolidBrush(cl), new Rectangle(_pos.X - _size.X / 2, _pos.Y - _size.Y / 2, _size.X, _size.Y));
            gStored.Save();
        }

        /// <summary>
        /// Faster Method to set the Pixel Color
        /// </summary>
        /// <param name="bmp">The Image</param>
        /// <param name="x">X Position</param>
        /// <param name="y">Y Position</param>
        /// <param name="c">Color</param>
        public static void SetPixel(Bitmap bmp, int x, int y, Color c)
        {
            lock (bmp)
            {
                try
                {
                    Rectangle _rct = new Rectangle(0, 0, bmp.Width, bmp.Height);
                    BitmapData _data = bmp.LockBits(_rct, ImageLockMode.ReadWrite, bmp.PixelFormat);

                    IntPtr btpPointer = _data.Scan0;
                    int _byts = (bmp.Width * bmp.Height) * 4;
                    byte[] rgbValues = new byte[_byts - 1];

                    Marshal.Copy(btpPointer, rgbValues, 0, rgbValues.Length);

                    int Index = ((y * bmp.Width) + x) * 4;

                    rgbValues[Index] = c.B;
                    rgbValues[Index + 1] = c.G;
                    rgbValues[Index + 2] = c.R;
                    rgbValues[Index + 3] = c.A;

                    Marshal.Copy(rgbValues, 0, btpPointer, rgbValues.Length);
                    bmp.UnlockBits(_data);
                }
                catch { }
            }
        }

    }
}
