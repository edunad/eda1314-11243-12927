using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pepino_A_Star
{
    /// <summary>
    /// @author Eduardo Fernandes nº12927
    /// @author Damien Fialho nº11243
    /// 
    /// @date 06/06/1024
    /// @code https://code.google.com/p/eda1314-11243-12927/
    /// 
    /// Global Variables to store data.
    /// </summary>
    /// 
    public static class GlobalStuff
    {

        public static PGMExtremeLoader _loadMenu;
        public static PathFinderMenu _pathMenu;
        public static PathSettings _panelSettings;

        public static PathTime _timeMenu;

        public static Bitmap _OriginalImage;
        public static Bitmap _OverlayImage;

        public static List<string> _mediaExperimental;

        public static int Width;
        public static int Height;

        public static bool IsImageLoaded;
        public static byte[] _pgmData;

        public static Color _pathColor;
        public static bool _drawNeigbor;

        public static int _heuristicMODE;
    }
}
