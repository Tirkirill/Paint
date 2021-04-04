﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    class MTriangle : Shape
    {
        public override void OnMouseDown(int X, int Y)
        {
            fX = X;
            fY = Y;
            saved = (Bitmap)Canvas.Image.Clone();
        }

        public override void OnMouseMove(int X, int Y)
        {
            Canvas.Image = saved;
            pen.Width = size;
            Bitmap Repres = (Bitmap)saved.Clone();
            Graphics GRepres = Graphics.FromImage(Repres);
            float width = fX - X;
            float height = Y - fY;
            DrawShapeGI(GRepres, X, Y, width, height);
            Canvas.Image = Repres;
        }

        public override void OnMouseUp(int X, int Y)
        {
            Canvas.Invalidate();
            float SizeCoef = Utilities.GetSizeCoef(size, scale);
            pen.Width = size;
            float width = fX - X;
            float height = Y - fY;
            DrawShapeGI(gI, X, Y, width, height);
            pen.Width = SizeCoef;
            DrawShapeG(X, Y, SizeCoef);
        }

        public MTriangle(Pen pen, Brush brush, int size, double scale, Graphics g, Graphics gI, PictureBox Canvas)
        {
            this.pen = pen;
            this.brush = brush;
            this.size = size;
            this.scale = scale;
            this.g = g;
            this.gI = gI;
            this.Canvas = Canvas;
        }

        public void DrawShapeGI(Graphics gI, int X, int Y, float width, float height)
        {
            Point[] points = new Point[]
            {
                new Point((int)(fX / scale), (int)(fY / scale)),
                new Point((int)((fX + width)/scale), (int)(Y/scale)),
                new Point((int)((fX- width)/scale), (int)(Y/scale))
            };
            gI.DrawPolygon(pen, points);
            gI.FillPolygon(brush, points);
        }

        public void DrawShapeG(int X, int Y, float SizeCoef)
        {
            g.DrawRectangle(pen, fX - SizeCoef / 2, fY - SizeCoef / 2, X - SizeCoef / 2, Y - SizeCoef / 2);
            g.FillRectangle(brush, fX - SizeCoef / 2, fY - SizeCoef / 2, X - SizeCoef / 2, Y - SizeCoef / 2);
        }
    }
}