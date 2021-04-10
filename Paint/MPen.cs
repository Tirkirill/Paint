using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    public class MPen:Instrument
    {

        List<Point> pointsG = new List<Point>();
        List<Point> pointsGI = new List<Point>();

        public MPen(Pen pen, int size, double scale, Graphics g, Graphics gI, PictureBox Canvas)
        {
            this.pen = pen;
            this.size = size;
            this.scale = scale;
            this.g = g;
            this.gI = gI;
            this.Canvas = Canvas;
        }

        public MPen(Pen pen, int size, double scale)
        {
            this.pen = pen;
            this.size = size;
            this.scale = scale;
        }

        public override void OnMouseDown(int X, int Y)
        {
            Draw(X, Y);
        }

        public override void OnMouseMove(int X, int Y, bool isShift)
        {
            Draw(X, Y);
        }

        private void Draw(int X, int Y) {
            pointsG.Add(new Point(X, Y));
            pointsGI.Add(new Point((int)(X / scale), (int)(Y / scale)));
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            if (pointsG.Count < 2)
            {
                float SizeCoef = Utilities.GetSizeCoef(size, scale);
                g.FillEllipse(new SolidBrush(pen.Color), Utilities.CoordForG(X, SizeCoef), Utilities.CoordForG(Y, SizeCoef), SizeCoef, SizeCoef);
                gI.FillEllipse(new SolidBrush(pen.Color), Utilities.CoordForGI(X, scale, size), Utilities.CoordForGI(Y, scale, size), size, size);
            }
            else
            {
                pen.Width = (float)(size * scale);
                g.DrawLines(pen, pointsG.ToArray());
                pen.Width = size;
                gI.DrawLines(pen, pointsGI.ToArray());
            }
           
        }

        public override void OnMouseUp(int X, int Y, bool isShift)
        {
            pen.Width = (float)(size * scale);
            if (pointsG.Count < 2)
            {
                float SizeCoef = Utilities.GetSizeCoef(size, scale);
                g.FillEllipse(new SolidBrush(pen.Color), Utilities.CoordForG(X, SizeCoef), Utilities.CoordForG(Y, SizeCoef), SizeCoef, SizeCoef);
                gI.FillEllipse(new SolidBrush(pen.Color), Utilities.CoordForGI(X, scale, size), Utilities.CoordForGI(Y, scale, size), size, size);
            }
            else
            {
                pen.Width = (float)(size * scale);
                g.DrawLines(pen, pointsG.ToArray());
                pen.Width = size;
                gI.DrawLines(pen, pointsGI.ToArray());
            }
            pointsG.Clear();
            pointsGI.Clear();
        }

        public override void OnMouseMoveWP(int X, int Y)
        {
            InstrumentUtilities.OnMouseMoveWPBrush(Canvas, saved, pen, X, Y, scale, size);
        }
    }
}
