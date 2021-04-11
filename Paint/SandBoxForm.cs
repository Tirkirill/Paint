using System;
using System.Drawing;
using System.Windows.Forms;
using Accord.Video.VFW;
using System.Collections.Generic;
using System.Drawing.Drawing2D;

namespace Paint
{
    public partial class SandBoxForm : System.Windows.Forms.Form
    {
        public SandBoxForm(Color BackColor, int CanvasWidth, int CanvasHeight)
        {
            InitializeComponent();
            Init(BackColor, CanvasWidth, CanvasHeight);
        }

        public SandBoxForm(string FileName)
        {
            InitializeComponent();
            Init(FileName);
        }
        private void Init(string FileName)
        {
            pen = new Pen(Color.Black);
            brush = new SolidBrush(Color.Black);
            AVIReader aw = new AVIReader();
            aw.Open(FileName);
            framerate = (int)aw.FrameRate;
            Bitmap fr = aw.GetNextFrame();
            FrameWidth = fr.Width;
            FrameHeight = fr.Height;
            CanvasColor = Color.White;
            BackColorButton.BackColor = Color.White;
            
            int awLen = aw.Length;
            double framedur = ((double)(60 / framerate)) / 60;
            bitmaps = new List<Bitmap>();
            FrameDurations = new List<double>();
            bitmaps.Add(fr);
            FrameDurations.Add(framedur);
            LocY = 25;
            AddFrameToGallery(0, LocY);
            LocY += 95;
            for (int i = 1; i < awLen; i++)
            {
                fr = aw.GetNextFrame();
                bitmaps.Add(fr);
                FrameDurations.Add(framedur);
                AddFrameToGallery(bitmaps.Count - 1, LocY);
                LocY += 95;
            }
            CurrentIndex = 0;
            history = new List<Bitmap>();

            
            Canvas.Width = FrameWidth;
            Canvas.Height = FrameHeight;
            SetBrush();
            SelectPB(0);
            RefreshGI();
            RefreshG();
            InitBrushSizeBar();
            SetScale(100);
            ScaleBar.Value = 100;
            paint = false;
            BrushColorButton.BackColor = Color.Black;
            PenColorButton.BackColor = Color.Black;
            SetUndoReturnButtonColor();
        }
        private void InitBrushSizeBar()
        {
            BrushSizeBar.Maximum = Register.MaxBrushSize;
            BrushSizeBar.Minimum = Register.MinBrushSize;
            BrushSizeBar.Value = Register.InitBrushSize;
            BrushSizeValueLabel.Text = Register.InitBrushSize.ToString();
            SetSize(Register.InitBrushSize);
        }
        private void Init(Color BackColor, int CanvasWidth, int CanvasHeight)
        {
            pen = new Pen(Color.Black);
            brush = new SolidBrush(Color.Black);
            FrameWidth = CanvasWidth;
            FrameHeight = CanvasHeight;
            bm = CreateFrame();
            Canvas.Width = CanvasWidth;
            Canvas.Height = CanvasHeight;
            SetBrush();
            RefreshGI();
            RefreshG();
            SetBackColor(BackColor);
            this.CurrentIndex = 0;
            FrameDurations = new List<double>();
            bitmaps =  new List<Bitmap>();
            LocY = 25;
            history = new List<Bitmap>();
            AddToHistory();
            InitBrushSizeBar();
            SetScale(100);
            ScaleBar.Value = 100;
            paint = false;
            framerate = Register.InitFrameRate;
            BrushColorButton.BackColor = Color.Black;
            PenColorButton.BackColor = Color.Black;
            SetUndoReturnButtonColor();
        }

        List<Bitmap> history;
        bool paint;
        SolidBrush brush;
        Pen pen;
        bool isShift = false;

        int size;
        double scale;

        Bitmap bm;
        Graphics g;
        Graphics gI;
        int FrameWidth;
        int FrameHeight;
        Color CanvasColor;
        List<Bitmap> bitmaps;
        int LocY;
        int CurrentIndex;
        List<double> FrameDurations;
        int framerate;
        bool isDragging = false;
        Frame DraggingObj;
        int IndexAfterDrag;
        Instrument CurrentInstrument;
        int CurrentHistoryIndex;
        bool opened = false;

        Point LastMouseMovePosition;
        
        private Bitmap CreateFrame()
        {
            return new Bitmap(FrameWidth, FrameHeight);
        }

        private void RefreshGI()
        {
            gI = Graphics.FromImage(bm);
            if (CurrentInstrument != null) CurrentInstrument.gI = gI;
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
            RefreshCanvas();
        }


        private void ClearButton_Click(object sender, EventArgs e)
        {
            g.Clear(CanvasColor);
            gI.Clear(CanvasColor);
            RefreshCanvas();
            ClearHistory();
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (opened)
            {
                opened = false;
                return;
            }
            paint = false;
            RefreshCanvas();
            CurrentInstrument.OnMouseUp(e.X, e.Y, isShift);
            RefreshCanvas();
            AddToHistory();
        }

        private void AddToHistory()
        {
            if (CurrentHistoryIndex != history.Count - 1 && history.Count != 0)
            {
                history.RemoveRange(CurrentHistoryIndex+1, history.Count - CurrentHistoryIndex - 1);
            }
            history.Add((Bitmap)bm.Clone());
            CurrentHistoryIndex = history.Count - 1;
            if (history.Count > 100)
            {
                history.RemoveAt(0);
            }
            SetUndoReturnButtonColor();
        }

        private void SetUndoButtonColor()
        {
            UndoButton.Enabled = CurrentHistoryIndex != 0;
        }

        private void SetReturnButtonColor()
        {
            ReturnButton.Enabled = CurrentHistoryIndex != history.Count - 1;
        }

        private void SetUndoReturnButtonColor()
        {
            SetUndoButtonColor();
            SetReturnButtonColor();
        }

        private void ClearHistory()
        {
            history.Clear();
            AddToHistory();
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            RefreshCanvas();
            CurrentInstrument.OnMouseDown(e.X, e.Y);
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            LastMouseMovePosition = new Point(e.X, e.Y);
            if (paint)
            {
                CurrentInstrument.OnMouseMove(e.X, e.Y, isShift);
            }
            else
            {
                CurrentInstrument.OnMouseMoveWP(e.X, e.Y);
            }
        }

        private void PenColorButton_Click(object sender, EventArgs e)
        {
            ChoosePenColor();
        }

        private void ChoosePenColor()
        {
            if (ColorDialog.ShowDialog() == DialogResult.OK)
            {
                pen.Color = ColorDialog.Color;
                PenColorButton.BackColor = ColorDialog.Color;
            }
        }

        private void BrushSizeBar_Scroll(object sender, EventArgs e)
        {
            int value = BrushSizeBar.Value;
            SetSize(value);
        }

        private void SetSize(int value)
        {
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
            CreateForm cr = new CreateForm();
            if (cr.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i<bitmaps.Count; i++)
                {
                    getPb(i).Dispose();
                }
                Init(cr.CanvasColor, cr.CanvasWidth, cr.CanvasHeight);
            }
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
            SetScale(val);
        }

        private void SetScale(int value)
        {
            double coef = (double)value / 100;
            CurrentInstrument.scale = coef;
            scale = coef;
            Canvas.Width = (int)(FrameWidth * coef);
            Canvas.Height = (int)(FrameHeight * coef);
            ScaleLabel.Text = value.ToString() + "%";
            RefreshCanvas();
        }

        private void SaveAnimationButton_Click(object sender, EventArgs e)
        { 
            if (bitmaps.Count == 0)
            {
                MessageBox.Show(StringResources.NoFrame);
                return;
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "avi";
            sfd.AddExtension = true;
            sfd.Filter = "(*.avi)|*.avi";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                AVIWriter aw = new AVIWriter("MSVC");
                aw.FrameRate = framerate;
                aw.Open(sfd.FileName, FrameWidth, FrameHeight);
                for (int j =0; j<bitmaps.Count; j++)
                {
                    Bitmap bitmap = (Bitmap)bitmaps[j].Clone();
                    double secs = FrameDurations[j];
                    for (int i = 0; i < secs*framerate; i++)
                    {
                        aw.AddFrame(bitmap);
                    }
                }
                aw.Quality = 1;
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
            ClearHistory();
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
            double SwapFd = FrameDurations[currentInd];

            bitmaps[currentInd] = (Bitmap)bitmaps[newInd].Clone();
            FrameDurations[currentInd] = FrameDurations[newInd];

            bitmaps[newInd] = SwapBm;
            FrameDurations[newInd] = SwapFd;
            RefreshPB(currentInd);
            RefreshPB(newInd);
        }

        public void AddFrameToGallery(int index, int Loc)
        {
            double FrameDuration = FrameDurations[index];
            Frame pb = new Frame(FrameGallery, Loc, index.ToString(), FrameDuration, (Bitmap)bitmaps[index].Clone());
            pb.Click += PbOnClick;
            pb.DoubleClick += PbOnDoubleClick;
            pb.MouseMove += OnMouseMove;
            pb.Border.MouseMove += OnMouseMove;
            
            pb.FrameLabel.MouseMove += OnMouseMove;
        }
            private void AddFrame_Click(object sender, EventArgs e)
        {
            double dur;
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

        private bool TryGetFrameDuration(out double dur)
        {
            return double.TryParse(FrameDurationBox.Text, out dur) && dur > 0;
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (bitmaps.Count == 0)
            {
                MessageBox.Show(StringResources.NoFrame);
                return;
            }
            double dur;
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
            if (CurrentInstrument != null)
            {
                RefreshG();
                CurrentInstrument.OnMouseEnter();
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            RefreshCanvas();
        }

        

        private void LineButton_Click(object sender, EventArgs e)
        {
            CurrentInstrument = new MLine(pen, size, scale, g, gI, Canvas);
        }

        private void PenButton_Click(object sender, EventArgs e)
        {
            SetBrush();
        }

        private void SetBrush()
        {
            CurrentInstrument = new MPen(pen, size, scale, g, gI, Canvas);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BrushColorButton_Click(object sender, EventArgs e)
        {
            ChooseBrushColor();
        }

        private void ChooseBrushColor()
        {
            if (ColorDialog.ShowDialog() == DialogResult.OK)
            {
                brush.Color = ColorDialog.Color;
                BrushColorButton.BackColor = ColorDialog.Color;
            }
        }

        private void RectangleButton_Click(object sender, EventArgs e)
        {
            CurrentInstrument = new MRectangle(pen, brush, size, scale, g, gI, Canvas);
        }

        private void EllipseButton_Click(object sender, EventArgs e)
        {
            CurrentInstrument = new MEllipse(pen, brush, size, scale, g, gI, Canvas);
        }

        private void TriangleButton_Click(object sender, EventArgs e)
        {
            CurrentInstrument = new MTriangle(pen, brush, size, scale, g, gI, Canvas);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Eraser_Click(object sender, EventArgs e)
        {
            Pen new_pen = new Pen(CanvasColor);
            CurrentInstrument = new MCircleBrush(new_pen, size, scale, g, gI, Canvas);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 16:
                    isShift = false;
                    if (paint) CurrentInstrument.OnMouseMove(LastMouseMovePosition.X, LastMouseMovePosition.Y, false);
                    break;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode) {
                case Keys.Escape:
                    if (isDragging)
                    {
                        if (IndexAfterDrag != -1 && IndexAfterDrag != CurrentIndex)
                        {
                            getPb(IndexAfterDrag).Border.BackColor = Register.NormalFrameBackColor;
                        }

                        StopDrag();
                    }
                    break;
                case Keys.Z:
                    if (e.Modifiers == Keys.Control)
                    {
                        Undo();
                    }
                    break;
                case Keys.Y:
                    if (e.Modifiers == Keys.Control)
                    {
                        ReturnHistory();
                    }
                    break;
                case Keys.ShiftKey:
                    isShift = true;
                    if (paint) CurrentInstrument.OnMouseMove(LastMouseMovePosition.X, LastMouseMovePosition.Y, true);
                    break;
                case Keys.Add:
                    if (e.Modifiers == Keys.Control)
                    {
                        int new_size = size + 5;
                        if (new_size <= Register.MaxBrushSize)
                        {
                            BrushSizeBar.Value = new_size;
                            SetSize(new_size);
                            CurrentInstrument.OnMouseMoveWP(LastMouseMovePosition.X, LastMouseMovePosition.Y);
                        }
                    }
                    if (e.Modifiers == Keys.Shift)
                    {
                        int new_scale = (int)(scale* 100) + 5;
                        if (new_scale <= Register.MaxScaleSize)
                        {
                            ScaleBar.Value = new_scale;
                            SetScale(new_scale);
                        }
                    }
                    break;
                case Keys.Subtract:
                    if (e.Modifiers == Keys.Control)
                    {
                        int new_size = size - 5;
                        if (new_size >= Register.MinBrushSize)
                        {
                            BrushSizeBar.Value = new_size;
                            SetSize(new_size);
                        }
                        CurrentInstrument.OnMouseMoveWP(LastMouseMovePosition.X, LastMouseMovePosition.Y);
                    }
                    if (e.Modifiers == Keys.Shift)
                    {
                        int new_scale = (int)(scale * 100) - 5;
                        if (new_scale >= Register.MinScaleSize)
                        {
                            ScaleBar.Value = new_scale;
                            SetScale(new_scale);
                        }
                    }
                    break;
                case Keys.D1:
                    if (e.Modifiers == Keys.Control) ChoosePenColor();
                    break;
                case Keys.D2:
                    if (e.Modifiers == Keys.Control) ChooseBrushColor();
                    break;
            }
        }

        private void Canvas_MouseEnter(object sender, EventArgs e)
        {
            CurrentInstrument.OnMouseEnter();
        }

        private void Canvas_MouseLeave(object sender, EventArgs e)
        {
            CurrentInstrument.OnMouseLeave();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm sf = new SettingsForm(FrameWidth, FrameHeight, framerate);
            if (sf.ShowDialog() == DialogResult.OK)
            {
                int new_width = sf.FrameWidth;
                int new_height = sf.FrameHeight;
                framerate = sf.FrameRate;
                Canvas.Width = new_width;
                Canvas.Height = new_height;
                FrameWidth = new_width;
                FrameHeight = new_height;
                
                for (int i = 0; i < bitmaps.Count; i++)
                {
                    bitmaps[i] = new Bitmap(bitmaps[i], new Size(new_width, new_height));
                }
            }
        }

        private void CircleBrushButton_Click(object sender, EventArgs e)
        {
            CurrentInstrument = new MCircleBrush(pen, size, scale, g, gI, Canvas);
        }

        private void SquareBrushButton_Click(object sender, EventArgs e)
        {
            CurrentInstrument = new MSquareBrush(pen, size, scale, g, gI, Canvas);
        }

        private void Undo()
        {
            if (history.Count == 0 || CurrentHistoryIndex == 0) return;
            CurrentHistoryIndex -= 1;
            bm = (Bitmap)history[CurrentHistoryIndex].Clone();
            RefreshCanvas();
            RefreshGI();
            SetUndoReturnButtonColor();
        }

        private void UndoButton_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void ReturnHistory()
        {
            if (history.Count == 0) return;
            if (history.Count <= CurrentHistoryIndex + 1) return;
            CurrentHistoryIndex += 1;
            bm = (Bitmap)history[CurrentHistoryIndex].Clone();
            RefreshCanvas();
            RefreshGI();
            SetUndoReturnButtonColor();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            ReturnHistory();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFD = new OpenFileDialog();
            oFD.Filter = "(*.avi)|*.avi";
            if (oFD.ShowDialog() == DialogResult.OK)
            {
                Init(oFD.FileName);
            }
            opened = true;
        }
    }
}
