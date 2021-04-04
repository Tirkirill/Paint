using System;
using System.Drawing;
using System.Windows.Forms;
using Accord.Video.VFW;
using System.Collections.Generic;
using System.Drawing.Drawing2D;

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
            CurrentInstrument = new MBrush(pen, 20, 1);
            RefreshGI();
            Canvas.Width = CanvasWidth;
            Canvas.Height = CanvasHeight; 
            RefreshG();
            SetBackColor(BackColor);
            this.CanvasColor = BackColor;
            this.CurrentIndex = 0;
        }

        bool paint = false;
        SolidBrush brush = new SolidBrush(Color.Black);
        Pen pen = new Pen(Color.Black);

        int size = 20;
        double scale = 1;

        Bitmap bm;
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
        bool isDragging = false;
        Frame DraggingObj;
        int IndexAfterDrag;
        Instrument CurrentInstrument;
        
        private Bitmap CreateFrame()
        {
            return new Bitmap(ImgWidth, ImgHeight);
        }

        private void RefreshGI()
        {
            gI = Graphics.FromImage(bm);
            CurrentInstrument.gI = gI;
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
            RefreshCanvas();
            CurrentInstrument.OnMouseUp(e.X, e.Y);
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            RefreshCanvas();
            CurrentInstrument.OnMouseDown(e.X, e.Y);
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                CurrentInstrument.OnMouseMove(e.X, e.Y);
            }
        }

        private void BrushColorButton_Click(object sender, EventArgs e)
        {
            if (ColorDialog.ShowDialog() == DialogResult.OK)
            {
                pen.Color = ColorDialog.Color;
                BrushColorButton.BackColor = ColorDialog.Color;
            }
                
        }

        private void BrushSizeBar_Scroll(object sender, EventArgs e)
        {
            int value = BrushSizeBar.Value;
            CurrentInstrument.size = value;
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
            CurrentInstrument.g = g;
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
            CurrentInstrument.scale = coef;
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
            SelectPB(tag);
        }

        private void PbOnDoubleClick(object sender, EventArgs e)
        {
            if (isDragging)
            {
                isDragging = false;
            }
            else
            {
                isDragging = true;
                DraggingObj = getPb(CurrentIndex).Clone();
                DraggingObj.Click += DragOnClick;
                DraggingObj.BringToFront();
            }
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                if (sender is Panel)
                {
                    DraggingObj.Location = new Point(e.X - Frame.FrameWidth / 2, e.Y - Frame.FrameHeight / 2);
                }
                else
                {
                    Control send = (Control)sender;
                    Frame frsend;
                    if (sender is Frame)
                    {
                        frsend = (Frame)sender;
                    }
                    else
                    {
                        frsend = getPb(int.Parse(send.Tag.ToString()));
                    }

                    if (IndexAfterDrag != CurrentIndex && IndexAfterDrag != -1) {
                        getPb(IndexAfterDrag).Border.BackColor = Register.NormalFrameBackColor;
                    }
                    
                    IndexAfterDrag = int.Parse(frsend.Tag.ToString());
                    if (!(IndexAfterDrag == CurrentIndex))
                    {
                        frsend.Border.BackColor = Register.DroppableFrameBackColor;
                    }
                    DraggingObj.Location = new Point(send.Location.X + e.X - Frame.FrameWidth / 2, send.Location.Y + e.Y - Frame.FrameHeight / 2);

                }
            }
        }

        private void DragOnClick(object sender, EventArgs e)
        {
            if (IndexAfterDrag != -1)
            {
                SwapFrames(CurrentIndex, IndexAfterDrag);
                SelectPB(IndexAfterDrag);
            }
            StopDrag();
        }

        private void SelectPB(int tag)
        {
            bm = (Bitmap)bitmaps[tag].Clone();
            SetGalleryFrameBorder(CurrentIndex, tag);
            CurrentIndex = tag;
            RefreshCanvas();
            RefreshGI();
        }

        private void StopDrag()
        {
            if (IndexAfterDrag != -1)
            {
                getPb(IndexAfterDrag).BackColor = Register.NormalFrameBackColor;
            }
            isDragging = false;
            DraggingObj.Dispose();
            DraggingObj = null;
            IndexAfterDrag = -1;
        }

        private void RefreshPB(int tag)
        {
            Frame pb = getPb(tag);
            pb.Image = (Bitmap)bitmaps[tag].Clone();
            pb.FrameLabel.Text = FrameDurations[tag].ToString() + " секунд";
        }

        private void SetGalleryFrameBorder(int prev, int index)
        {
            FrameGallery.Controls.Find(StringResources.BorderNamePrefix + prev.ToString(), false)[0].BackColor = Register.NormalFrameBackColor;
            FrameGallery.Controls.Find(StringResources.BorderNamePrefix + index.ToString(), false)[0].BackColor = Register.CurrentFrameBackColor;
        }

        private void SwapFrames(int currentInd, int newInd)
        {
            Bitmap SwapBm = (Bitmap)bitmaps[currentInd].Clone();
            float SwapFd = FrameDurations[currentInd];

            bitmaps[currentInd] = (Bitmap)bitmaps[newInd].Clone();
            FrameDurations[currentInd] = FrameDurations[newInd];

            bitmaps[newInd] = SwapBm;
            FrameDurations[newInd] = SwapFd;
            RefreshPB(currentInd);
            RefreshPB(newInd);
        }

        public void AddFrameToGallery(int index, int Loc)
        {
            float FrameDuration = FrameDurations[index];
            Frame pb = new Frame(FrameGallery, Loc, index.ToString(), FrameDuration, (Bitmap)bitmaps[index].Clone());
            pb.Click += PbOnClick;
            pb.DoubleClick += PbOnDoubleClick;
            pb.MouseMove += OnMouseMove;
            pb.Border.MouseMove += OnMouseMove;
            
            pb.FrameLabel.MouseMove += OnMouseMove;
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
                SetGalleryFrameBorder(CurrentIndex, pbTag);
                CurrentIndex = pbTag;
                RefreshG();
                RefreshGI();
            }
            else
            {
                MessageBox.Show(StringResources.IncorrectFrameDurationInput);
            }
        }

        private bool TryGetFrameDuration(out float dur)
        {
            return float.TryParse(FrameDurationBox.Text, out dur) && dur > 0;
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (bitmaps.Count == 0)
            {
                MessageBox.Show(StringResources.NoFrame);
                return;
            }
            float dur;
            if (TryGetFrameDuration(out dur))
            {
                bitmaps[CurrentIndex] = (Bitmap)bm.Clone();
                FrameDurations[CurrentIndex] = dur;
                RefreshPB(CurrentIndex);
            }
            else
            {
                MessageBox.Show(StringResources.IncorrectFrameDurationInput);
            }
            
        }

        private Frame getPb(int index)
        {
            return (Frame)FrameGallery.Controls.Find(StringResources.FrameNamePrefix + index, false)[0];
        }

        private void DeleteFrameButton_Click(object sender, EventArgs e)
        {
            if (bitmaps.Count == 0)
            {
                MessageBox.Show(StringResources.NoFrame);
                return;
            }
            getPb(CurrentIndex).Dispose();
            for (int i=CurrentIndex+1; i<bitmaps.Count; i++)
            {
                Frame pb = getPb(i);
                pb.ChangeLocationY(-95);
                pb.ChangeTag(-1);
            }
            LocY -= 95;
            bitmaps.RemoveAt(CurrentIndex);
            FrameDurations.RemoveAt(CurrentIndex);
            CurrentIndex = 0;
            if (bitmaps.Count > 0)
            {
                SelectPB(0);
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

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 27:
                    if (IndexAfterDrag != -1 && IndexAfterDrag!=CurrentIndex)
                    {
                        getPb(IndexAfterDrag).Border.BackColor = Register.NormalFrameBackColor;
                    }
                    
                    StopDrag();
                    break;
            }
        }

        private void LineButton_Click(object sender, EventArgs e)
        {
            CurrentInstrument = new MLine(pen, size, scale, g, gI, Canvas);
        }

        private void BrushButton_Click(object sender, EventArgs e)
        {
            CurrentInstrument = new MBrush(pen, size, scale, g, gI);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
