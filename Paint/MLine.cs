using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    public class MLine : MShape
    {

        public override void OnMouseMove(int X, int Y, bool isShift)
        {
            Canvas.Image = saved;
            pen.Width = size;
            Bitmap Repres = (Bitmap)saved.Clone();
            Graphics GRepres = Graphics.FromImage(Repres);
            if (isShift)
            {
                if (Math.Abs(X - fX) > Math.Abs(Y - fY))
                {
                    Y = fY;
                }
                else
                {
                    X = fX;
                }
            }
            DrawLineGI(GRepres, X, Y);
            Canvas.Image = Repres;
        }

        public override void OnMouseUp(int X, int Y, bool isShift)
        {
            Canvas.Invalidate();
            pen.Width = size;
            if (isShift)
            {
                if (Math.Abs(X - fX) > Math.Abs(Y - fY))
                {
                    Y = fY;
                }
                else
                {
                    X = fX;
                }
            }
            DrawLineGI(gI, X, Y);
        }

        private void DrawLineGI(Graphics gI, int X, int Y)
        {
            gI.DrawLine(pen, (float)(fX / scale), (float)(fY / scale), (float)(X / scale), (float)(Y / scale));
        }

        public override void OnMouseMoveWP(int X, int Y)
        {
            InstrumentUtilities.OnMouseMoveWPBrush(Canvas, saved, pen, X, Y, scale, size);
        }

        public MLine(Pen pen, int size, double scale, Graphics gI, PictureBox Canvas):base(pen, size, scale, gI, Canvas)
        {
        }
    }
}
