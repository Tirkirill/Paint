using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    class MTriangle : Shape
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

        public MTriangle(Pen pen, Brush brush, int size, double scale, Graphics g, Graphics gI, PictureBox Canvas)
        {
            this.pen = pen;
            this.brush = brush;
            this.size = size;
            this.scale = scale;
            this.g = g;
            this.gI = gI;
            this.Canvas = Canvas;
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
            
        }
    }
}
