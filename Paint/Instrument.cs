using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

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
        public PictureBox Canvas;
        public Bitmap saved;

        public abstract void OnMouseDown(int X, int Y);

        public abstract void OnMouseMove(int X, int Y, bool isShift);

        public abstract void OnMouseUp(int X, int Y, bool isShift);

        public abstract void OnMouseMoveWP(int X, int Y);

        public virtual void OnMouseEnter()
        {
            saved = (Bitmap)Canvas.Image.Clone();
        }

        public virtual void OnMouseLeave()
        {
            Canvas.Image = (Bitmap)saved.Clone();
        }
    }
}
