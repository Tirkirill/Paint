using System;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    public class Selection : Shape
    {
        public override void OnMouseDown(int X, int Y)
        {
            fX = X;
            fY = Y;
            saved = (Bitmap)Canvas.Image.Clone();
        }

        public SelectionArea selectionArea;

        public override void OnMouseMove(int X, int Y, bool isShift)
        {
            Canvas.Image = saved;
            Bitmap Repres = (Bitmap)saved.Clone();
            Graphics GRepres = Graphics.FromImage(Repres);
            float width = (float)Math.Abs((fX - X) / scale);
            float height;
            if (isShift)
            {
                height = width;
                if (fY < Y) Y = (int)(fY + height);
                else Y = (int)(fY - height);
            }
            else
            {
                height = (float)Math.Abs((fY - Y) / scale);
            }
            DrawShapeGI(GRepres, X, Y, width, height);
            Canvas.Image = Repres;
        }

        public override void OnMouseUp(int X, int Y, bool isShift)
        {
            Canvas.Invalidate();
            float SizeCoef = Utilities.GetSizeCoef(size, scale);
            float width = (float)Math.Abs((fX - X) / scale);
            float height;
            if (isShift)
            {
                height = width;
                if (fY < Y) Y = (int)(fY + height);
                else Y = (int)(fY - height);
            }
            else
            {
                height = (float)Math.Abs((fY - Y) / scale);
            }
            this.selectionArea.init(X, Y, width, height);
            DrawShapeGI(gI, X, Y, width, height);
        }

        public Selection(int size, double scale, Graphics gI, PictureBox Canvas, SelectionArea selectionArea)
        {
            this.size = size;
            this.scale = scale;
            this.gI = gI;
            this.Canvas = Canvas;
            this.selectionArea = selectionArea;
            pen = new Pen(Color.Black, 2);
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
