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

        public override void OnMouseMove(int X, int Y, bool isShift)
        {
            Canvas.Image = saved;
            pen.Width = size;
            Bitmap Repres = (Bitmap)saved.Clone();
            Graphics GRepres = Graphics.FromImage(Repres);
            float width = (float)Math.Abs((fX - X) / scale);
            float height;
            if (isShift)
            {
                height = width;
                if (fY < Y) Y = (int)(fY + height);
                else Y = (int)(fY - height);
            }
            else
            {
                height = (float)Math.Abs((fY - Y) / scale);
            }
            DrawShapeGI(GRepres, X, Y, width, height);
            Canvas.Image = Repres;
        }

        public override void OnMouseUp(int X, int Y, bool isShift)
        {
            Canvas.Invalidate();
            pen.Width = size;
            float width = (float)Math.Abs((fX - X) / scale);
            float height;
            if (isShift)
            {
                height = width;
                if (fY < Y) Y = (int)(fY + height);
                else Y = (int)(fY - height);
            }
            else
            {
                height = (float)Math.Abs((fY - Y) / scale);
            }
            DrawShapeGI(gI, X, Y, width, height);
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
            if ((size >= width) || (size >= height))
            {
                Pen new_pen = (Pen)pen.Clone();
                new_pen.Width = Math.Min(width, height);
                gI.DrawEllipse(new_pen, (float)(Math.Min(fX, X) / scale), (float)(Math.Min(fY, Y) / scale), width, height);
                gI.DrawEllipse(new_pen, (float)(Math.Min(fX, X) / scale), (float)(Math.Min(fY, Y) / scale), width, height);
            }
            else
            {
                gI.DrawEllipse(pen, (float)(Math.Min(fX, X) / scale), (float)(Math.Min(fY, Y) / scale), width, height);
                gI.FillEllipse(brush, (float)(Math.Min(fX, X) / scale), (float)(Math.Min(fY, Y) / scale), width, height);
            }
            
        }

        public override void OnMouseMoveWP(int X, int Y)
        {

        }
    }
}
