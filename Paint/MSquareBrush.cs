using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    class MSquareBrush:Instrument
    {
        public MSquareBrush(Pen pen, int size, double scale, Graphics g, Graphics gI, PictureBox Canvas)
        {
            this.pen = pen;
            this.size = size;
            this.scale = scale;
            this.g = g;
            this.gI = gI;
            this.Canvas = Canvas;
        }

        public override void OnMouseDown(int X, int Y)
        {
            Draw(X, Y);
        }

        public override void OnMouseMove(int X, int Y, bool isShift)
        {
            Draw(X, Y);
        }

        private void Draw(int X, int Y)
        {
            float SizeCoef = Utilities.GetSizeCoef(size, scale);
            g.FillRectangle(new SolidBrush(pen.Color), Utilities.CoordForG(X, SizeCoef), Utilities.CoordForG(Y, SizeCoef), SizeCoef, SizeCoef);
            gI.FillRectangle(new SolidBrush(pen.Color), Utilities.CoordForGI(X, scale, size), Utilities.CoordForGI(Y, scale, size), size, size);
        }

        public override void OnMouseMoveWP(int X, int Y)
        {
            Canvas.Image = (Bitmap)saved.Clone();
            Bitmap Repres = (Bitmap)saved.Clone();
            Graphics RepresG = Graphics.FromImage(Repres);
            RepresG.FillRectangle(new SolidBrush(pen.Color), Utilities.CoordForGI(X, scale, size), Utilities.CoordForGI(Y, scale, size), size, size);
            Canvas.Image = Repres;
        }

        public override void OnMouseUp(int X, int Y, bool isShift)
        {

        }
    }
}
