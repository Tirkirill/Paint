using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    public class MLine : Instrument
    {
        private int fX;
        private int fY;
        private Bitmap saved;


        public override void OnMouseDown(int X, int Y)
        {
            fX = X;
            fY = Y;
            saved = (Bitmap)Canvas.Image.Clone();
        }

        public override void OnMouseMove(int X, int Y)
        {
            Canvas.Image = saved;
            float SizeCoef = Utilities.GetSizeCoef(size, scale);
            pen.Width = SizeCoef;
            Bitmap Repres = (Bitmap)saved.Clone();
            Graphics GRepres = Graphics.FromImage(Repres);
            GRepres.DrawLine(pen, Utilities.CoordForG(fX, SizeCoef), Utilities.CoordForG(fY, SizeCoef), Utilities.CoordForG(X, SizeCoef), Utilities.CoordForG(Y, SizeCoef));
            Canvas.Image = Repres;
        }

        public override void OnMouseUp(int X, int Y)
        {
            Canvas.Invalidate();
            float SizeCoef = Utilities.GetSizeCoef(size, scale);
            pen.Width = size;
            gI.DrawLine(pen, (float)(fX / scale - size / 2), (float)(fY / scale - size / 2), (float)(X / scale - size / 2), (float)(Y / scale - size / 2));
            pen.Width = SizeCoef;
            g.DrawLine(pen, fX - SizeCoef / 2, fY - SizeCoef / 2, X - SizeCoef / 2, Y - SizeCoef / 2);
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
