using System;
using System.Drawing;
using System.Windows.Forms;
using Accord.Video.VFW;
using System.Collections.Generic;

namespace Paint
{
    public partial class Form1 : Form
    {
        public Form1(Color BackColor, int CanvasWidth, int CanvasHeight)
        {
            InitializeComponent();
            ImgWidth = CanvasWidth;
            ImgHeight = CanvasHeight;
            bm = CreateFrame();
            RefreshGI();
            Canvas.Width = CanvasWidth;
            Canvas.Height = CanvasHeight;
            RefreshG();
            SetBackColor(BackColor);
            this.CanvasColor = BackColor;
            this.CurrentIndex = 0;
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
        List<Bitmap> bitmaps = new List<Bitmap>();
        int LocY = 25;
        int CurrentIndex;
        List<float> FrameDurations= new List<float>();
        int framerate = 24;
        
        private Bitmap CreateFrame()
        {
            return new Bitmap(ImgWidth, ImgHeight);
        }

        private void RefreshGI()
        {
            gI = Graphics.FromImage(bm);
        }

        private void SetBackColor(Color BackColor)
        {
            CanvasColor = BackColor;
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

        private void SaveAnimationButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                AVIWriter aw = new AVIWriter();
                aw.FrameRate = framerate;
                aw.Open(sfd.FileName, bm.Width, bm.Height);
                for (int j =0; j<bitmaps.Count; j++)
                {
                    Bitmap bitmap = bitmaps[j];
                    float secs = FrameDurations[j];
                    for (int i = 0; i < secs*framerate; i++)
                    {
                        aw.AddFrame(bitmap);
                    }
                }
                aw.Close();
            }
        }

        private void PbOnClick(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            int tag = int.Parse(pb.Tag.ToString());
            bm = bitmaps[tag];
            RefreshG();
            RefreshGI();
            Canvas.Image = bm;
            CurrentIndex = tag;
        }

        private void RefreshPB(PictureBox pb, Label Lpb, int tag)
        {
            pb.Image = bitmaps[tag];
            Lpb.Text = FrameDurations[tag].ToString() + " секунд";
        }

        private void AddFrame_Click(object sender, EventArgs e)
        {
            
            float dur;
            if (TryGetFrameDuration(out dur))
            {
                bitmaps.Add((Bitmap)bm.Clone());
                float FrameDuration = float.Parse(FrameDurationBox.Text);
                int pbTag = bitmaps.Count - 1;
                Label pbLabel = new Label();
                pbLabel.Parent = FrameGallery;
                pbLabel.Location = new Point(10, LocY + 60);
                pbLabel.Text = FrameDuration.ToString() + " секунд";
                pbLabel.Name = "Lpb" + pbTag;
                PictureBox pb = new PictureBox();
                pb.Parent = FrameGallery;
                pb.Width = 100;
                pb.Height = 50;
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Location = new Point(10, LocY);
                LocY += 95;
                pb.Image = bitmaps[bitmaps.Count - 1];
                pb.Click += PbOnClick;
                pb.Cursor = Cursors.Hand;
                pb.Tag = pbTag;
                pb.Name = "pb" + pbTag.ToString();
                FrameDurations.Add(FrameDuration);
                CurrentIndex = pbTag;
                RefreshG();
                RefreshGI();
            }
            else
            {
                MessageBox.Show("Введите длительность кадра корректно!");
            }
            

        }

        private bool TryGetFrameDuration(out float dur)
        {
            return float.TryParse(FrameDurationBox.Text, out dur);
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            
            float dur;
            if (TryGetFrameDuration(out dur))
            {
                PictureBox pbCurr = (PictureBox)FrameGallery.Controls.Find("pb" + CurrentIndex, false)[0];
                Label LpbCurr = (Label)FrameGallery.Controls.Find("Lpb" + CurrentIndex, false)[0];
                bitmaps[CurrentIndex] = (Bitmap)bm.Clone();
                FrameDurations[CurrentIndex] = dur;
                RefreshPB(pbCurr, LpbCurr, CurrentIndex);
            }
            else
            {
                MessageBox.Show("Введите длительность кадра корректно!");
            }
            
        }
    }
}
