using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    public class MLine : Shape
    {

        public override void OnMouseDown(int X, int Y)
        {
            fX = X;
            fY = Y;
            saved = (Bitmap)Canvas.Image.Clone();
        }

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
            Canvas.Image = (Bitmap)saved.Clone();
            Bitmap Repres = (Bitmap)saved.Clone();
            Graphics RepresG = Graphics.FromImage(Repres);
            RepresG.FillEllipse(new SolidBrush(pen.Color), Utilities.CoordForGI(X, scale, size), Utilities.CoordForGI(Y, scale, size), size, size);
            Canvas.Image = Repres;
        }

        public MLine(Pen pen, int size, double scale, Graphics g, Graphics gI, PictureBox Canvas)
        {
            this.pen = pen;
            this.size = size;
            this.scale = scale;
            this.g = g;
            this.gI = gI;
            this.Canvas = Canvas;
        }
    }
}
