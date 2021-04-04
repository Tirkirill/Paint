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

        public override void OnMouseMove(int X, int Y)
        {
            Canvas.Image = saved;
            pen.Width = size;
            Bitmap Repres = (Bitmap)saved.Clone();
            Graphics GRepres = Graphics.FromImage(Repres);
            DrawLineGI(GRepres, X, Y);
            Canvas.Image = Repres;
        }

        public override void OnMouseUp(int X, int Y)
        {
            Canvas.Invalidate();
            float SizeCoef = Utilities.GetSizeCoef(size, scale);
            pen.Width = size;
            DrawLineGI(gI, X, Y);
            pen.Width = SizeCoef;
            g.DrawLine(pen, fX, fY, X, Y);
        }

        private void DrawLineGI(Graphics gI, int X, int Y)
        {
            gI.DrawLine(pen, (float)(fX / scale), (float)(fY / scale), (float)(X / scale), (float)(Y / scale));
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
