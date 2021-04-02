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
            bm = CreateFrame();
            RefreshG();
            g.Clear(BackColor);
            RefreshGI();
            gI.Clear(BackColor);
            BackColorButton.BackColor = BackColor;
            Canvas.Image = null;
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

        private void ScaleBar_Scroll(object sender, EventArgs e)
        {
            int val = ScaleBar.Value;
            double coef = (double)val / 100;
            scale = coef;
            Canvas.Width = (int)(ImgWidth * coef);
            Canvas.Height = (int)(ImgHeight * coef);
            ScaleLabel.Text = val.ToString() + "%";
            RefreshCanvas();
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
                    Bitmap bitmap = (Bitmap)bitmaps[j].Clone();
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
            SelectPB(tag, pb);
        }

        private void SelectPB(int tag, PictureBox pb)
        {
            bm = (Bitmap)bitmaps[tag].Clone();
            CurrentIndex = tag;
            SetGalleryFrameBorder(tag);

            RefreshCanvas();
            RefreshGI();
        }

        private void RefreshPB(PictureBox pb, Label Lpb, int tag)
        {
            pb.Image = (Bitmap)bitmaps[tag].Clone();
            Lpb.Text = FrameDurations[tag].ToString() + " секунд";
        }

        private void SetGalleryFrameBorder(int index)
        {
            for (int i = 0; i < bitmaps.Count; i++)
            {
                FrameGallery.Controls.Find("pbb" + i.ToString(), false)[0].BackColor = Color.Black;
            }
            FrameGallery.Controls.Find("pbb" + index.ToString(), false)[0].BackColor = Color.Blue;
        }
        public void AddFrameToGallery(int index, int Loc)
        {
            Label pbLabel = new Label();
            Label pbBorder = new Label();
            float FrameDuration = FrameDurations[index];
            pbLabel.Parent = FrameGallery;
            pbBorder.Parent = FrameGallery;
            pbBorder.Location = new Point(8, Loc - 2);
            pbBorder.BackColor = Color.Black;
            pbBorder.Name = "pbb" + index.ToString();

            pbLabel.Location = new Point(10, Loc + 60);
            pbLabel.Text = FrameDuration.ToString() + " секунд";
            pbLabel.Name = "Lpb" + index;
            PictureBox pb = new PictureBox();
            pb.Parent = FrameGallery;
            pbBorder.Width = 104;
            pbBorder.Height = 54;
            pb.Width = 100;
            pb.Height = 50;
            pb.SizeMode = PictureBoxSizeMode.StretchImage;

            pb.Location = new Point(10, Loc);

            pb.Image = (Bitmap)bitmaps[index].Clone();
            pb.Click += PbOnClick;
            pb.Cursor = Cursors.Hand;
            pb.Tag = index;
            pb.Name = "pb" + index.ToString();
            pb.BringToFront();
        }

        private void AddFrame_Click(object sender, EventArgs e)
        {
            float dur;
            if (TryGetFrameDuration(out dur))
            {
                bitmaps.Add((Bitmap)bm.Clone());
                FrameDurations.Add(dur);
                int pbTag = bitmaps.Count - 1;
                AddFrameToGallery(pbTag, LocY-FrameGallery.VerticalScroll.Value);
                LocY += 95;
                CurrentIndex = pbTag;
                SetGalleryFrameBorder(CurrentIndex);
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
                PictureBox pbCurr = getPb(CurrentIndex);
                Label LpbCurr = getLpb(CurrentIndex);
                bitmaps[CurrentIndex] = (Bitmap)bm.Clone();
                FrameDurations[CurrentIndex] = dur;
                RefreshPB(pbCurr, LpbCurr, CurrentIndex);
            }
            else
            {
                MessageBox.Show("Введите длительность кадра корректно!");
            }
            
        }

        private void DisposeFrame(int index)
        {
            getPb(index).Dispose();
            getPbb(index).Dispose();
            getLpb(index).Dispose();
        }

        private PictureBox getPb(int index)
        {
            return (PictureBox)FrameGallery.Controls.Find("pb" + index, false)[0];
        }

        private Label getPbb(int index)
        {
            return (Label)FrameGallery.Controls.Find("pbb" + index, false)[0];
        }

        private Label getLpb(int index)
        {
            return (Label)FrameGallery.Controls.Find("Lpb" + index, false)[0];
        }

        

        private void ChangeTagFrame(int index, int z)
        {
            int NewTag = index + z;
            PictureBox pb = getPb(index);
            pb.Name = "pb" + NewTag;
            pb.Tag = NewTag;
            getPbb(index).Name = "pbb" + NewTag;
            getLpb(index).Name = "Lpb" + NewTag;
        }

        private void ChangeFrameLocation(int index, int z)
        {
            PictureBox pb = getPb(index);
            Label pbb = getPbb(index);
            Label Lpb = getLpb(index);
            pb.Location = new Point(pb.Location.X, pb.Location.Y + z);
            pbb.Location = new Point(pbb.Location.X, pbb.Location.Y + z);
            Lpb.Location = new Point(Lpb.Location.X, Lpb.Location.Y + z);
        }

        private void DeleteFrameButton_Click(object sender, EventArgs e)
        {
            DisposeFrame(CurrentIndex);
            for (int i=CurrentIndex+1; i<bitmaps.Count; i++)
            {
                ChangeFrameLocation(i, -95);
                ChangeTagFrame(i, -1);
            }
            LocY -= 95;
            bitmaps.RemoveAt(CurrentIndex);
            FrameDurations.RemoveAt(CurrentIndex);
            CurrentIndex = 0;
            if (bitmaps.Count > 0)
            {
                SelectPB(0, getPb(0));
            }
        }

        private void RefreshCanvas()
        {
            Canvas.Image = bm;
            RefreshG();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            RefreshCanvas();
        }
    }
}
