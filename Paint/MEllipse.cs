using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    public class MEllipse : Shape
    {
        public override void OnMouseDown(int X, int Y)
        {
            fX = X;
            fY = Y;
            saved = (Bitmap)Canvas.Image.Clone();
        }

        public override void OnMouseMove(int X, int Y)
        {
            Canvas.Image = saved;
            pen.Width = size;
            Bitmap Repres = (Bitmap)saved.Clone();
            Graphics GRepres = Graphics.FromImage(Repres);
            float width = (float)Math.Abs((fX - X) / scale);
            float height = (float)Math.Abs((fY - Y) / scale);
            DrawShapeGI(GRepres, X, Y, width, height);
            Canvas.Image = Repres;
        }

        public override void OnMouseUp(int X, int Y)
        {
            Canvas.Invalidate();
            float SizeCoef = Utilities.GetSizeCoef(size, scale);
            pen.Width = size;
            float width = (float)Math.Abs((fX - X) / scale);
            float height = (float)Math.Abs((fY - Y) / scale);
            DrawShapeGI(gI, X, Y, width, height);
            pen.Width = SizeCoef;
            DrawShapeG(X, Y, SizeCoef);
        }

        public MEllipse(Pen pen, Brush brush, int size, double scale, Graphics g, Graphics gI, PictureBox Canvas)
        {
            this.pen = pen;
            this.brush = brush;
            this.size = size;
            this.scale = scale;
            this.g = g;
            this.gI = gI;
            this.Canvas = Canvas;
        }

        public void DrawShapeGI(Graphics gI, int X, int Y, float width, float height)
        {
            gI.DrawEllipse(pen, (float)(Math.Min(fX, X) / scale), (float)(Math.Min(fY, Y) / scale), width, height);
            gI.FillEllipse(brush, (float)(Math.Min(fX, X) / scale), (float)(Math.Min(fY, Y) / scale), width, height);
        }

        public void DrawShapeG(int X, int Y, float SizeCoef)
        {
            g.DrawRectangle(pen, fX - SizeCoef / 2, fY - SizeCoef / 2, X - SizeCoef / 2, Y - SizeCoef / 2);
            g.FillRectangle(brush, fX - SizeCoef / 2, fY - SizeCoef / 2, X - SizeCoef / 2, Y - SizeCoef / 2);
        }

    }
}
