using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint
{
    public class MBrush:Instrument
    {

        public MBrush(Pen pen, int size, double scale, Graphics g, Graphics gI)
        {
            this.pen = pen;
            this.size = size;
            this.scale = scale;
            this.g = g;
            this.gI = gI;
        }

        public MBrush(Pen pen, int size, double scale)
        {
            this.pen = pen;
            this.size = size;
            this.scale = scale;
        }

        public override void OnMouseDown(int X, int Y)
        {
            Draw(X, Y);
        }

        public override void OnMouseMove(int X, int Y)
        {
            Draw(X, Y);
        }

        private void Draw(int X, int Y) {
            float SizeCoef = Utilities.GetSizeCoef(size, scale);
            g.FillEllipse(new SolidBrush(pen.Color), Utilities.CoordForG(X, SizeCoef), Utilities.CoordForG(Y, SizeCoef), SizeCoef, SizeCoef);
            gI.FillEllipse(new SolidBrush(pen.Color), Utilities.CoordForGI(X, scale, size), Utilities.CoordForGI(Y, scale, size), size, size);
        }

        public override void OnMouseUp(int X, int Y)
        {
            
        }
    }
}
