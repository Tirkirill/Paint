using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    public class MRectangle : Shape
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
            GRepres.DrawRectangle(pen, (float)(Math.Min(fX, X) / scale), (float)(Math.Min(fY, Y) / scale),width ,height);
            Canvas.Image = Repres;
        }

        public override void OnMouseUp(int X, int Y)
        {
            Canvas.Invalidate();
            float SizeCoef = Utilities.GetSizeCoef(size, scale);
            pen.Width = size;
            float width = (float)Math.Abs((fX - X) / scale);
            float height = (float)Math.Abs((fY - Y) / scale);
            gI.DrawRectangle(pen, (float)(Math.Min(fX, X) / scale), (float)(Math.Min(fY, Y) / scale), width, height);
            pen.Width = SizeCoef;
            g.DrawRectangle(pen, fX - SizeCoef / 2, fY - SizeCoef / 2, X - SizeCoef / 2, Y - SizeCoef / 2);
        }

        public MRectangle(Pen pen, int size, double scale, Graphics g, Graphics gI, PictureBox Canvas)
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
