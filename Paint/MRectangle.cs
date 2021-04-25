using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    public class MRectangle : ColoredShape
    {

        public MRectangle(Pen pen, Brush brush, int size, double scale, Graphics gI, PictureBox Canvas)
            :base(pen, brush, size, scale, gI, Canvas)
        {

        }

        public override void DrawShape(Graphics gI, int X, int Y)
        {
            float width = (float)(Math.Abs(fX - X)/scale);
            float height = (float)(Math.Abs(fY - Y) / scale);
            pen.Width = new float[] { width, height, size }.Min();
            gI.DrawRectangle(pen, (float)(Math.Min(fX, X) / scale), (float)(Math.Min(fY, Y) / scale), width, height);
            gI.FillRectangle(brush, (float)(Math.Min(fX, X) / scale), (float)(Math.Min(fY, Y) / scale), width, height);
        }

        public override void OnMouseMoveWP(int X, int Y)
        {
            Pen new_pen = (Pen)pen.Clone();
            float coef = 4;
            float new_width = size / coef;
            new_pen.Width = new_width;
            Canvas.Image = (Bitmap)saved.Clone();
            Bitmap Repres = (Bitmap)saved.Clone();
            Graphics RepresG = Graphics.FromImage(Repres);
            float new_size = new_width / coef + 15;
            RepresG.DrawRectangle(new_pen, (float)(X / scale), (float)(Y / scale), new_size, new_size);
            RepresG.FillRectangle(brush, (float)(X / scale), (float)(Y / scale), new_size, new_size);
            Canvas.Image = Repres;
        }
    }
}
