using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint
{
    public class MLine : Instrument
    {
        private int fX;
        private int fY;


        public override void OnMouseDown(int X, int Y)
        {
            fX = X;
            fY = Y;
        }

        public override void OnMouseMove(int X, int Y)
        {
            
        }

        public override void OnMouseUp(int X, int Y)
        { 
            float SizeCoef = (float)(size * scale);
            pen.Width = size;
            gI.DrawLine(pen, (float)(fX / scale - size / 2), (float)(fY / scale - size / 2), (float)(X / scale - size / 2), (float)(Y / scale - size / 2));
            pen.Width = SizeCoef;
            g.DrawLine(pen, fX - SizeCoef / 2, fY - SizeCoef / 2, X - SizeCoef / 2, Y - SizeCoef / 2);
            
        }

        public MLine(Pen pen, int size, double scale, Graphics g, Graphics gI)
        {
            this.pen = pen;
            this.size = size;
            this.scale = scale;
            this.g = g;
            this.gI = gI;
        }
    }
}
