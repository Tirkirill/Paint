using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    class MTriangle : MShape
    {

        public override void OnMouseMove(int X, int Y, bool isShift)
        {
            Canvas.Image = saved;
            pen.Width = size;
            Bitmap Repres = (Bitmap)saved.Clone();
            Graphics GRepres = Graphics.FromImage(Repres);
            float width = fX - X;
            DrawShapeGI(GRepres, X, Y, width);
            Canvas.Image = Repres;
        }

        public override void OnMouseUp(int X, int Y, bool isShift)
        {
            Canvas.Invalidate();
            pen.Width = size;
            float width = fX - X;
            DrawShapeGI(gI, X, Y, width);
        }

        public MTriangle(Pen pen, Brush brush, int size, double scale, Graphics gI, PictureBox Canvas)
            :base(pen, size, scale, gI, Canvas)
        {
            this.brush = brush;
        }

        public void DrawShapeGI(Graphics gI, int X, int Y, float width)
        {
            Point[] points = new Point[]
            {
                new Point((int)(fX / scale), (int)(fY / scale)),
                new Point((int)((fX + width)/scale), (int)(Y/scale)),
                new Point((int)((fX- width)/scale), (int)(Y/scale))
            };
            float height = Math.Abs(fY - Y);
            if ((size >= width) || (size >= height))
            {
                Pen new_pen = (Pen)pen.Clone();
                new_pen.Width = Math.Min(Math.Abs(width), height);
                gI.DrawPolygon(new_pen, points);
                gI.FillPolygon(brush, points);
            }
            else
            {
                gI.DrawPolygon(pen, points);
                gI.FillPolygon(brush, points);
            }
        }

        public override void OnMouseMoveWP(int X, int Y)
        {
            Pen new_pen = (Pen)pen.Clone();
            float coef = 7;
            float new_width = size / coef;
            new_pen.Width = new_width;
            Canvas.Image = (Bitmap)saved.Clone();
            Bitmap Repres = (Bitmap)saved.Clone();
            Graphics RepresG = Graphics.FromImage(Repres);
            Point[] points = new Point[]
            {
                new Point((int)(X / scale), (int)(Y / scale)),
                new Point((int)((X + 10)/scale), (int)((Y+5)/scale)),
                new Point((int)((X - 10)/scale), (int)((Y+5)/scale))
            };
            RepresG.DrawPolygon(new_pen, points);
            RepresG.FillPolygon(brush, points);
            Canvas.Image = Repres;
        }
    }
}
