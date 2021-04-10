using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Paint
{
    static class InstrumentUtilities
    {
        public static void OnMouseMoveWPBrush(PictureBox Canvas, Bitmap saved, Pen pen, int X, int Y, double scale, int size)
        {
            Canvas.Image = (Bitmap)saved.Clone();
            Bitmap Repres = (Bitmap)saved.Clone();
            Graphics RepresG = Graphics.FromImage(Repres);
            RepresG.FillEllipse(new SolidBrush(pen.Color), Utilities.CoordForGI(X, scale, size), Utilities.CoordForGI(Y, scale, size), size, size);
            Canvas.Image = Repres;
        }
    }
}
