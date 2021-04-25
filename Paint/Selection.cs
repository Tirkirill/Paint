using System;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    public class Selection : MShape
    {

        public SelectionArea selectionArea;

        public override void OnMouseMove(int X, int Y, bool isShift)
        {
            Canvas.Image = saved;
            Bitmap Repres = (Bitmap)saved.Clone();
            Graphics GRepres = Graphics.FromImage(Repres);
            float width = (float)Math.Abs((fX - X) / scale);
            float height = (float)Math.Abs((fY - Y) / scale);
            DrawShapeGI(GRepres, X, Y, width, height);
            Canvas.Image = Repres;
        }

        public override void OnMouseUp(int X, int Y, bool isShift)
        {
            Canvas.Invalidate();
            float width = (float)Math.Abs((fX - X) / scale);
            float height = (float)Math.Abs((fY - Y) / scale);
            selectionArea.init((int)(Math.Min(fX, X) / scale), (int)(Math.Min(fY, Y) / scale), width, height);
            DrawShapeGI(gI, X, Y, width, height);
        }

        public Selection(int size, double scale, Graphics gI, PictureBox Canvas, SelectionArea selectionArea):
            base(new Pen(Color.Black, 2), size, scale, gI, Canvas)
        {
            this.selectionArea = selectionArea;
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
        }

        public void DrawShapeGI(Graphics gI, int X, int Y, float width, float height)
        {
            gI.DrawRectangle(pen, (float)(Math.Min(fX, X) / scale), (float)(Math.Min(fY, Y) / scale), width, height);
        }

        public override void OnMouseMoveWP(int X, int Y)
        {

        }
    }
}
