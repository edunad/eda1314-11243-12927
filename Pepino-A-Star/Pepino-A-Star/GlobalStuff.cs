using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pepino_A_Star
{
    public static class GlobalStuff
    {

        public static PGMExtremeLoader _loadMenu;
        public static PathFinderMenu _pathMenu;
        public static PathSettings _panelSettings;

        public static PathTime _timeMenu;

        public static Bitmap _OriginalImage;
        public static Bitmap _OverlayImage;

        public static int Width;
        public static int Height;

        public static bool IsImageLoaded;
        public static byte[] _pgmData;

        public static Color _pathColor;
        public static bool _drawNeigbor;

        public static int _heuristicMODE;
    }
}
