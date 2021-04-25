using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    class MSquareBrush:MBrush
    {
        public MSquareBrush(Pen pen, int size, double scale, Graphics gI, PictureBox Canvas): base(pen, size, scale, gI, Canvas)
        {

        }

        public override void Draw(int X, int Y)
        {
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
    }
}
