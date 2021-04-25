using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    public class MPen:MBrush
    {

        List<Point> pointsGI = new List<Point>();

        public MPen(Pen pen, int size, double scale, Graphics gI, PictureBox Canvas) : base(pen, size, scale, gI, Canvas)
        {

        }

        public MPen(Pen pen, int size, double scale):base()
        {
            this.pen = pen;
            this.size = size;
            this.scale = scale;
        }

        public override void Draw(int X, int Y) 
        {
            pointsGI.Add(new Point((int)(X / scale), (int)(Y / scale)));
            Pen new_pen = (Pen)pen.Clone();
            new_pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            new_pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            if (pointsGI.Count < 2)
            {
                gI.FillEllipse(new SolidBrush(new_pen.Color), Utilities.CoordForGI(X, scale, size), Utilities.CoordForGI(Y, scale, size), size, size);
            }
            else
            {
                new_pen.Width = size;
                gI.DrawLines(new_pen, pointsGI.ToArray());
            }
           
        }

        public override void OnMouseUp(int X, int Y, bool isShift)
        {
            pointsGI.Clear();
        }
    }
}
