using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    abstract public class ColoredShape:Shape
    {
        abstract public void DrawShape(Graphics gI, int X, int Y);

        public override void OnMouseMove(int X, int Y, bool isShift)
        {
            Canvas.Image = saved;
            Bitmap Repres = (Bitmap)saved.Clone();
            Graphics GRepres = Graphics.FromImage(Repres);
            if (isShift)
            {
                float width = Math.Abs(fX - X);
                if (Y > fY) Y = fY + (int)width;
                else Y = fY - (int)width;
            }
            DrawShape(GRepres, X, Y);
            Canvas.Image = Repres;
        }

        public override void OnMouseUp(int X, int Y, bool isShift)
        {
            Canvas.Invalidate();
            if (isShift)
            {
                float width = Math.Abs(fX - X);
                if (Y > fY) Y = fY + (int)width;
                else Y = fY - (int)width;
            }
            DrawShape(gI, X, Y);
        }

        public ColoredShape(Pen pen, Brush brush, int size, double scale, Graphics gI, PictureBox Canvas)
        {
            this.pen = pen;
            this.brush = brush;
            this.size = size;
            this.scale = scale;
            this.gI = gI;
            this.Canvas = Canvas;
        }
    }
}
