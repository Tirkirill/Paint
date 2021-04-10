using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint
{
    public static class Register
    {
        public static int MinFrameWidth = 300;
        public static int MaxFrameWidth = 2000;

        public static int MinFrameHeight = 200;
        public static int MaxFrameHeight = 2000;

        public static Color NormalFrameBackColor = Color.Black;
        public static Color DroppableFrameBackColor = Color.Green;
        public static Color CurrentFrameBackColor = Color.Blue;

        public static int MinBrushSize = 1;
        public static int MaxBrushSize = 100;
        public static int InitBrushSize = 25;

        public static int MaxScaleSize = 200;
        public static int MinScaleSize = 25;
        public static int InitScaleSize = 100;

        public static int InitFrameWidth = 900;
        public static int InitFrameHeight = 600;

        public static int MaxFrameRate = 24;
        public static int MinFrameRate = 2;
        public static int InitFrameRate = 5;

        public enum ProgramRegimes
        {
            NewProject, OpenVideo
        }
    }
}
