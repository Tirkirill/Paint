using System;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        public Form1(Color BackColor, int CanvasWidth, int CanvasHeight)
        {
            InitializeComponent();
            bm = new Bitmap(CanvasWidth, CanvasHeight);
            gI = Graphics.FromImage(bm);
            ImgWidth = CanvasWidth;
            ImgHeight = CanvasHeight;
            Canvas.Width = CanvasWidth;
            Canvas.Height = CanvasHeight;
            g = Canvas.CreateGraphics();
            SetBackColor(BackColor);
            this.CanvasColor = BackColor;
        }

        bool paint = false;
        int size = 20;
        SolidBrush color = new SolidBrush(Color.Black);
        Bitmap bm;
        double scale = 1;
        Graphics g;
        Graphics gI;
        int ImgWidth;
        int ImgHeight;
        Color CanvasColor;

        private void SetBackColor(Color BackColor)
        {
            Canvas.BackColor = BackColor;
            g.Clear(BackColor);
            gI.Clear(BackColor);
            BackColorButton.BackColor = BackColor;
        }


        private void ClearButton_Click(object sender, EventArgs e)
        {
            g.Clear(CanvasColor);
            gI.Clear(CanvasColor);
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            float SizeCoef = (float)(size * scale);
            g.FillEllipse(color, e.X - SizeCoef / 2, e.Y - SizeCoef / 2, SizeCoef, SizeCoef);
            gI.FillEllipse(color, (float)((e.X / scale) - size / 2), (float)((e.Y / scale) - size / 2), size, size);
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                float SizeCoef = (float)(size * scale);
                g.FillEllipse(color, e.X - SizeCoef / 2, e.Y - SizeCoef / 2, SizeCoef, SizeCoef);
                gI.FillEllipse(color, (float)((e.X/scale) - size / 2), (float)((e.Y / scale) - size / 2), size, size);
            }
        }

        private void BrushColorButton_Click(object sender, EventArgs e)
        {
            if (ColorDialog.ShowDialog() == DialogResult.OK)
            {
                color.Color = ColorDialog.Color;
                BrushColorButton.BackColor = ColorDialog.Color;
            }
                
        }

        private void BrushSizeBar_Scroll(object sender, EventArgs e)
        {
            int value = BrushSizeBar.Value;
            size = value;
            BrushSizeValueLabel.Text = value.ToString();
        }

        private void BackColorButton_Click(object sender, EventArgs e)
        {
            if (ColorDialog.ShowDialog() == DialogResult.OK)
            {
                SetBackColor(ColorDialog.Color);
            }
        }

        private void CreateNewButton_Click(object sender, EventArgs e)
        {

        }

        private void RefreshG()
        {
            g = Canvas.CreateGraphics();
        }

        private void SaveFile(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                bm.Save(sfd.FileName);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            double coef = (double)trackBar1.Value / 100;
            scale = coef;
            Canvas.Width = (int)(ImgWidth * coef);
            Canvas.Height = (int)(ImgHeight * coef);
            RefreshG();
            Canvas.Image = bm;
        }
    }
}
