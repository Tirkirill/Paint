using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    class MCircleBrush : MBrush
    {
        public MCircleBrush(Pen pen, int size, double scale, Graphics gI, PictureBox Canvas) : base(pen, size, scale, gI, Canvas)
        {

        }

        public override void Draw(int X, int Y)
        {
            gI.FillEllipse(new SolidBrush(pen.Color), Utilities.CoordForGI(X, scale, size), Utilities.CoordForGI(Y, scale, size), size, size);
        }
    }
}
