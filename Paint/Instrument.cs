using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint
{
    public abstract class Instrument
    {
        public Graphics g;
        public Graphics gI;
        public int size;
        public double scale;
        public Brush brush;
        public Pen pen;
        public abstract void OnMouseDown(int X, int Y);

        public abstract void OnMouseMove(int X, int Y);

        public abstract void OnMouseUp(int X, int Y);
    }
}
