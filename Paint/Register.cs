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

        public enum ProgramRegimes
        {
            FreePaint, Tests
        }
    }
}
