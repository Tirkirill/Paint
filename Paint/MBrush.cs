using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    public abstract class MBrush : Instrument
    {
        public override void OnMouseDown(int X, int Y)
        {
            Draw(X, Y);
        }

        public override void OnMouseMove(int X, int Y, bool isShift)
        {
            Draw(X, Y);
            Canvas.Invalidate();
        }

        public override void OnMouseMoveWP(int X, int Y)
        {
            InstrumentUtilities.OnMouseMoveWPBrush(Canvas, saved, pen, X, Y, scale, size);
        }

        public override void OnMouseUp(int X, int Y, bool isShift)
        {
            
        }

        abstract public void Draw(int X, int Y);

        public MBrush(Pen pen, int size, double scale, Graphics gI, PictureBox Canvas)
        {
            this.pen = pen;
            this.size = size;
            this.scale = scale;
            this.gI = gI;
            this.Canvas = Canvas;
        }

        public MBrush()
        {

        }
    }
}
