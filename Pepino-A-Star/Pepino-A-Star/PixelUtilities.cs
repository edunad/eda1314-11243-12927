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
    public static class PixelUtilities
    {
        public static Color GetPixel(Bitmap bmp, int x, int y)
        {
            Rectangle _rct = new Rectangle(0,0,bmp.Width,bmp.Height);
            BitmapData _data = bmp.LockBits(_rct, ImageLockMode.ReadWrite, bmp.PixelFormat);

            IntPtr btpPointer = _data.Scan0;
            int _byts = (bmp.Width * bmp.Height) * 4;
            byte[] rgbValues = new byte[_byts - 1];

            Marshal.Copy(btpPointer,rgbValues,0,rgbValues.Length);

            int Index = ((y * bmp.Width) + x) * 4;

            int b = rgbValues[Index];
            int g = rgbValues[Index + 1];
            int r = rgbValues[Index + 2];
            int a = rgbValues[Index + 3];

            bmp.UnlockBits(_data);

            return Color.FromArgb(r,g,b);
        }

        public static void DrawSquare(Bitmap bmp, Vector2 _pos, Vector2 _size, Color cl)
        {
            Graphics gStored = Graphics.FromImage(bmp);

            gStored.FillRectangle(new SolidBrush(cl), new Rectangle(_pos.X, _pos.Y, _size.X, _size.Y));
            gStored.Save();
        }

        public static void SetPixel(Bitmap bmp, int x, int y, Color c)
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

    }
}
