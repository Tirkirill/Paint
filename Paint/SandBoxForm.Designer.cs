
namespace Paint
{
    partial class SandBoxForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SandBoxForm));
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.ClearButton = new System.Windows.Forms.Button();
            this.PenColorButton = new System.Windows.Forms.Button();
            this.BrushColorLabel = new System.Windows.Forms.Label();
            this.BrushSizeBar = new System.Windows.Forms.TrackBar();
            this.BrushSizeBarLabel = new System.Windows.Forms.Label();
            this.BackColorLabel = new System.Windows.Forms.Label();
            this.BackColorButton = new System.Windows.Forms.Button();
            this.BrushSizeValueLabel = new System.Windows.Forms.Label();
            this.CreateNewButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.CanvasPanel = new System.Windows.Forms.Panel();
            this.ScaleBar = new System.Windows.Forms.TrackBar();
            this.GalleryLabel = new System.Windows.Forms.Label();
            this.SaveAnimationButton = new System.Windows.Forms.Button();
            this.AddFrame = new System.Windows.Forms.Button();
            this.FrameGallery = new System.Windows.Forms.Panel();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.FrameDurationBox = new System.Windows.Forms.TextBox();
            this.DeleteFrameButton = new System.Windows.Forms.Button();
            this.ScaleLabel = new System.Windows.Forms.Label();
            this.LineButton = new System.Windows.Forms.Button();
            this.PenButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.RectangleButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BrushColorButton = new System.Windows.Forms.Button();
            this.EllipseButton = new System.Windows.Forms.Button();
            this.TriangleButton = new System.Windows.Forms.Button();
            this.FrameDurationLabel = new System.Windows.Forms.Label();
            this.Eraser = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.CircleBrushButton = new System.Windows.Forms.Button();
            this.SquareBrushButton = new System.Windows.Forms.Button();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.ShapesButton = new System.Windows.Forms.GroupBox();
            this.BrushesButtons = new System.Windows.Forms.GroupBox();
            this.WorkPanel = new System.Windows.Forms.Panel();
            this.ProjectPanel = new System.Windows.Forms.Panel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.BrushSizeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            this.CanvasPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleBar)).BeginInit();
            this.FrameGallery.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.ShapesButton.SuspendLayout();
            this.BrushesButtons.SuspendLayout();
            this.WorkPanel.SuspendLayout();
            this.ProjectPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(548, 39);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(100, 23);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // PenColorButton
            // 
            this.PenColorButton.BackColor = System.Drawing.Color.Black;
            this.PenColorButton.Location = new System.Drawing.Point(10, 39);
            this.PenColorButton.Name = "PenColorButton";
            this.PenColorButton.Size = new System.Drawing.Size(26, 23);
            this.PenColorButton.TabIndex = 2;
            this.PenColorButton.UseVisualStyleBackColor = false;
            this.PenColorButton.Click += new System.EventHandler(this.PenColorButton_Click);
            // 
            // BrushColorLabel
            // 
            this.BrushColorLabel.AutoSize = true;
            this.BrushColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BrushColorLabel.Location = new System.Drawing.Point(40, 39);
            this.BrushColorLabel.Name = "BrushColorLabel";
            this.BrushColorLabel.Size = new System.Drawing.Size(163, 20);
            this.BrushColorLabel.TabIndex = 3;
            this.BrushColorLabel.Text = "Цвет обводки/кисти";
            // 
            // BrushSizeBar
            // 
            this.BrushSizeBar.BackColor = System.Drawing.SystemColors.Control;
            this.BrushSizeBar.Location = new System.Drawing.Point(3, 3);
            this.BrushSizeBar.Maximum = 100;
            this.BrushSizeBar.Minimum = 1;
            this.BrushSizeBar.Name = "BrushSizeBar";
            this.BrushSizeBar.Size = new System.Drawing.Size(146, 45);
            this.BrushSizeBar.TabIndex = 4;
            this.BrushSizeBar.Value = 20;
            this.BrushSizeBar.Scroll += new System.EventHandler(this.BrushSizeBar_Scroll);
            // 
            // BrushSizeBarLabel
            // 
            this.BrushSizeBarLabel.AutoSize = true;
            this.BrushSizeBarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BrushSizeBarLabel.Location = new System.Drawing.Point(155, 12);
            this.BrushSizeBarLabel.Name = "BrushSizeBarLabel";
            this.BrushSizeBarLabel.Size = new System.Drawing.Size(112, 20);
            this.BrushSizeBarLabel.TabIndex = 5;
            this.BrushSizeBarLabel.Text = "Размер кисти";
            // 
            // BackColorLabel
            // 
            this.BackColorLabel.AutoSize = true;
            this.BackColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackColorLabel.Location = new System.Drawing.Point(580, 9);
            this.BackColorLabel.Name = "BackColorLabel";
            this.BackColorLabel.Size = new System.Drawing.Size(94, 20);
            this.BackColorLabel.TabIndex = 7;
            this.BackColorLabel.Text = "Цвет фона";
            // 
            // BackColorButton
            // 
            this.BackColorButton.BackColor = System.Drawing.Color.White;
            this.BackColorButton.Location = new System.Drawing.Point(548, 9);
            this.BackColorButton.Name = "BackColorButton";
            this.BackColorButton.Size = new System.Drawing.Size(26, 23);
            this.BackColorButton.TabIndex = 6;
            this.BackColorButton.UseVisualStyleBackColor = false;
            this.BackColorButton.Click += new System.EventHandler(this.BackColorButton_Click);
            // 
            // BrushSizeValueLabel
            // 
            this.BrushSizeValueLabel.AutoSize = true;
            this.BrushSizeValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BrushSizeValueLabel.Location = new System.Drawing.Point(118, 45);
            this.BrushSizeValueLabel.Name = "BrushSizeValueLabel";
            this.BrushSizeValueLabel.Size = new System.Drawing.Size(22, 16);
            this.BrushSizeValueLabel.TabIndex = 8;
            this.BrushSizeValueLabel.Text = "20";
            // 
            // CreateNewButton
            // 
            this.CreateNewButton.Location = new System.Drawing.Point(5, 3);
            this.CreateNewButton.Name = "CreateNewButton";
            this.CreateNewButton.Size = new System.Drawing.Size(91, 23);
            this.CreateNewButton.TabIndex = 9;
            this.CreateNewButton.Text = "Новый";
            this.CreateNewButton.UseVisualStyleBackColor = true;
            this.CreateNewButton.Click += new System.EventHandler(this.CreateNewButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(654, 39);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(140, 23);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Сохранить кадр  как...";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveFile);
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.Color.White;
            this.Canvas.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Canvas.Location = new System.Drawing.Point(3, 3);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(162, 146);
            this.Canvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Canvas.TabIndex = 11;
            this.Canvas.TabStop = false;
            this.Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.Canvas.MouseEnter += new System.EventHandler(this.Canvas_MouseEnter);
            this.Canvas.MouseLeave += new System.EventHandler(this.Canvas_MouseLeave);
            this.Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.Canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            // 
            // CanvasPanel
            // 
            this.CanvasPanel.AutoScroll = true;
            this.CanvasPanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CanvasPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CanvasPanel.Controls.Add(this.Canvas);
            this.CanvasPanel.Location = new System.Drawing.Point(3, 3);
            this.CanvasPanel.Name = "CanvasPanel";
            this.CanvasPanel.Size = new System.Drawing.Size(794, 470);
            this.CanvasPanel.TabIndex = 13;
            // 
            // ScaleBar
            // 
            this.ScaleBar.LargeChange = 25;
            this.ScaleBar.Location = new System.Drawing.Point(587, 476);
            this.ScaleBar.Maximum = 200;
            this.ScaleBar.Minimum = 25;
            this.ScaleBar.Name = "ScaleBar";
            this.ScaleBar.Size = new System.Drawing.Size(207, 45);
            this.ScaleBar.SmallChange = 13;
            this.ScaleBar.TabIndex = 16;
            this.ScaleBar.Value = 100;
            this.ScaleBar.Scroll += new System.EventHandler(this.ScaleBar_Scroll);
            // 
            // GalleryLabel
            // 
            this.GalleryLabel.AutoSize = true;
            this.GalleryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GalleryLabel.Location = new System.Drawing.Point(2, 0);
            this.GalleryLabel.Name = "GalleryLabel";
            this.GalleryLabel.Size = new System.Drawing.Size(59, 20);
            this.GalleryLabel.TabIndex = 17;
            this.GalleryLabel.Text = "Кадры";
            // 
            // SaveAnimationButton
            // 
            this.SaveAnimationButton.Location = new System.Drawing.Point(104, 73);
            this.SaveAnimationButton.Name = "SaveAnimationButton";
            this.SaveAnimationButton.Size = new System.Drawing.Size(92, 23);
            this.SaveAnimationButton.TabIndex = 19;
            this.SaveAnimationButton.Text = "Создать мульт";
            this.SaveAnimationButton.UseVisualStyleBackColor = true;
            this.SaveAnimationButton.Click += new System.EventHandler(this.SaveAnimationButton_Click);
            // 
            // AddFrame
            // 
            this.AddFrame.Location = new System.Drawing.Point(6, 44);
            this.AddFrame.Name = "AddFrame";
            this.AddFrame.Size = new System.Drawing.Size(92, 23);
            this.AddFrame.TabIndex = 20;
            this.AddFrame.Text = "Добавить";
            this.AddFrame.UseVisualStyleBackColor = true;
            this.AddFrame.Click += new System.EventHandler(this.AddFrame_Click);
            // 
            // FrameGallery
            // 
            this.FrameGallery.AutoScroll = true;
            this.FrameGallery.Controls.Add(this.GalleryLabel);
            this.FrameGallery.Location = new System.Drawing.Point(6, 106);
            this.FrameGallery.Name = "FrameGallery";
            this.FrameGallery.Size = new System.Drawing.Size(190, 470);
            this.FrameGallery.TabIndex = 21;
            this.FrameGallery.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(6, 73);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(92, 23);
            this.ChangeButton.TabIndex = 22;
            this.ChangeButton.Text = "Изменить";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // FrameDurationBox
            // 
            this.FrameDurationBox.Location = new System.Drawing.Point(6, 18);
            this.FrameDurationBox.Name = "FrameDurationBox";
            this.FrameDurationBox.Size = new System.Drawing.Size(92, 20);
            this.FrameDurationBox.TabIndex = 23;
            this.FrameDurationBox.Text = "0,5";
            // 
            // DeleteFrameButton
            // 
            this.DeleteFrameButton.Location = new System.Drawing.Point(104, 44);
            this.DeleteFrameButton.Name = "DeleteFrameButton";
            this.DeleteFrameButton.Size = new System.Drawing.Size(92, 23);
            this.DeleteFrameButton.TabIndex = 24;
            this.DeleteFrameButton.Text = "Удалить";
            this.DeleteFrameButton.UseVisualStyleBackColor = true;
            this.DeleteFrameButton.Click += new System.EventHandler(this.DeleteFrameButton_Click);
            // 
            // ScaleLabel
            // 
            this.ScaleLabel.AutoSize = true;
            this.ScaleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScaleLabel.Location = new System.Drawing.Point(551, 476);
            this.ScaleLabel.Name = "ScaleLabel";
            this.ScaleLabel.Size = new System.Drawing.Size(41, 16);
            this.ScaleLabel.TabIndex = 25;
            this.ScaleLabel.Text = "100%";
            // 
            // LineButton
            // 
            this.LineButton.BackColor = System.Drawing.Color.Transparent;
            this.LineButton.ForeColor = System.Drawing.Color.Black;
            this.LineButton.Location = new System.Drawing.Point(6, 19);
            this.LineButton.Name = "LineButton";
            this.LineButton.Size = new System.Drawing.Size(61, 23);
            this.LineButton.TabIndex = 26;
            this.LineButton.Text = "Линия";
            this.LineButton.UseVisualStyleBackColor = false;
            this.LineButton.Click += new System.EventHandler(this.LineButton_Click);
            // 
            // PenButton
            // 
            this.PenButton.BackColor = System.Drawing.Color.Transparent;
            this.PenButton.ForeColor = System.Drawing.Color.Black;
            this.PenButton.Location = new System.Drawing.Point(6, 48);
            this.PenButton.Name = "PenButton";
            this.PenButton.Size = new System.Drawing.Size(80, 23);
            this.PenButton.TabIndex = 27;
            this.PenButton.Text = "Перо";
            this.PenButton.UseVisualStyleBackColor = false;
            this.PenButton.Click += new System.EventHandler(this.PenButton_Click);
            // 
            // RectangleButton
            // 
            this.RectangleButton.BackColor = System.Drawing.Color.Transparent;
            this.RectangleButton.ForeColor = System.Drawing.Color.Black;
            this.RectangleButton.Location = new System.Drawing.Point(73, 19);
            this.RectangleButton.Name = "RectangleButton";
            this.RectangleButton.Size = new System.Drawing.Size(98, 23);
            this.RectangleButton.TabIndex = 28;
            this.RectangleButton.Text = "Прямоугольник";
            this.RectangleButton.UseVisualStyleBackColor = false;
            this.RectangleButton.Click += new System.EventHandler(this.RectangleButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(42, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Цвет заполнения";
            // 
            // BrushColorButton
            // 
            this.BrushColorButton.BackColor = System.Drawing.Color.Black;
            this.BrushColorButton.Location = new System.Drawing.Point(10, 64);
            this.BrushColorButton.Name = "BrushColorButton";
            this.BrushColorButton.Size = new System.Drawing.Size(26, 23);
            this.BrushColorButton.TabIndex = 29;
            this.BrushColorButton.UseVisualStyleBackColor = false;
            this.BrushColorButton.Click += new System.EventHandler(this.BrushColorButton_Click);
            // 
            // EllipseButton
            // 
            this.EllipseButton.BackColor = System.Drawing.Color.Transparent;
            this.EllipseButton.ForeColor = System.Drawing.Color.Black;
            this.EllipseButton.Location = new System.Drawing.Point(6, 48);
            this.EllipseButton.Name = "EllipseButton";
            this.EllipseButton.Size = new System.Drawing.Size(61, 23);
            this.EllipseButton.TabIndex = 31;
            this.EllipseButton.Text = "Овал";
            this.EllipseButton.UseVisualStyleBackColor = false;
            this.EllipseButton.Click += new System.EventHandler(this.EllipseButton_Click);
            // 
            // TriangleButton
            // 
            this.TriangleButton.BackColor = System.Drawing.Color.Transparent;
            this.TriangleButton.ForeColor = System.Drawing.Color.Black;
            this.TriangleButton.Location = new System.Drawing.Point(73, 48);
            this.TriangleButton.Name = "TriangleButton";
            this.TriangleButton.Size = new System.Drawing.Size(98, 23);
            this.TriangleButton.TabIndex = 32;
            this.TriangleButton.Text = "Треугольник";
            this.TriangleButton.UseVisualStyleBackColor = false;
            this.TriangleButton.Click += new System.EventHandler(this.TriangleButton_Click);
            // 
            // FrameDurationLabel
            // 
            this.FrameDurationLabel.AutoSize = true;
            this.FrameDurationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FrameDurationLabel.Location = new System.Drawing.Point(3, 5);
            this.FrameDurationLabel.Name = "FrameDurationLabel";
            this.FrameDurationLabel.Size = new System.Drawing.Size(140, 13);
            this.FrameDurationLabel.TabIndex = 33;
            this.FrameDurationLabel.Text = "Длительность кадра(сек.)";
            // 
            // Eraser
            // 
            this.Eraser.BackColor = System.Drawing.Color.Transparent;
            this.Eraser.ForeColor = System.Drawing.Color.Black;
            this.Eraser.Location = new System.Drawing.Point(92, 48);
            this.Eraser.Name = "Eraser";
            this.Eraser.Size = new System.Drawing.Size(80, 23);
            this.Eraser.TabIndex = 34;
            this.Eraser.Text = "Ластик";
            this.Eraser.UseVisualStyleBackColor = false;
            this.Eraser.Click += new System.EventHandler(this.Eraser_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(102, 3);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(91, 23);
            this.SettingsButton.TabIndex = 35;
            this.SettingsButton.Text = "Настройки";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // CircleBrushButton
            // 
            this.CircleBrushButton.BackColor = System.Drawing.Color.Transparent;
            this.CircleBrushButton.ForeColor = System.Drawing.Color.Black;
            this.CircleBrushButton.Location = new System.Drawing.Point(6, 19);
            this.CircleBrushButton.Name = "CircleBrushButton";
            this.CircleBrushButton.Size = new System.Drawing.Size(80, 23);
            this.CircleBrushButton.TabIndex = 36;
            this.CircleBrushButton.Text = "Круглая кисть";
            this.CircleBrushButton.UseVisualStyleBackColor = false;
            this.CircleBrushButton.Click += new System.EventHandler(this.CircleBrushButton_Click);
            // 
            // SquareBrushButton
            // 
            this.SquareBrushButton.BackColor = System.Drawing.Color.Transparent;
            this.SquareBrushButton.ForeColor = System.Drawing.Color.Black;
            this.SquareBrushButton.Location = new System.Drawing.Point(92, 19);
            this.SquareBrushButton.Name = "SquareBrushButton";
            this.SquareBrushButton.Size = new System.Drawing.Size(80, 23);
            this.SquareBrushButton.TabIndex = 37;
            this.SquareBrushButton.Text = "Квадратная кисть";
            this.SquareBrushButton.UseVisualStyleBackColor = false;
            this.SquareBrushButton.Click += new System.EventHandler(this.SquareBrushButton_Click);
            // 
            // BottomPanel
            // 
            this.BottomPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BottomPanel.Controls.Add(this.BrushSizeBar);
            this.BottomPanel.Controls.Add(this.BrushSizeValueLabel);
            this.BottomPanel.Controls.Add(this.BrushSizeBarLabel);
            this.BottomPanel.Controls.Add(this.BackColorButton);
            this.BottomPanel.Controls.Add(this.BackColorLabel);
            this.BottomPanel.Controls.Add(this.ClearButton);
            this.BottomPanel.Controls.Add(this.SaveButton);
            this.BottomPanel.Location = new System.Drawing.Point(18, 101);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(797, 65);
            this.BottomPanel.TabIndex = 38;
            // 
            // ShapesButton
            // 
            this.ShapesButton.Controls.Add(this.LineButton);
            this.ShapesButton.Controls.Add(this.RectangleButton);
            this.ShapesButton.Controls.Add(this.EllipseButton);
            this.ShapesButton.Controls.Add(this.TriangleButton);
            this.ShapesButton.Location = new System.Drawing.Point(209, 5);
            this.ShapesButton.Name = "ShapesButton";
            this.ShapesButton.Size = new System.Drawing.Size(181, 82);
            this.ShapesButton.TabIndex = 12;
            this.ShapesButton.TabStop = false;
            this.ShapesButton.Text = "Фигуры";
            // 
            // BrushesButtons
            // 
            this.BrushesButtons.Controls.Add(this.CircleBrushButton);
            this.BrushesButtons.Controls.Add(this.SquareBrushButton);
            this.BrushesButtons.Controls.Add(this.PenButton);
            this.BrushesButtons.Controls.Add(this.Eraser);
            this.BrushesButtons.Location = new System.Drawing.Point(396, 5);
            this.BrushesButtons.Name = "BrushesButtons";
            this.BrushesButtons.Size = new System.Drawing.Size(183, 82);
            this.BrushesButtons.TabIndex = 39;
            this.BrushesButtons.TabStop = false;
            this.BrushesButtons.Text = "Кисти";
            // 
            // WorkPanel
            // 
            this.WorkPanel.Controls.Add(this.CanvasPanel);
            this.WorkPanel.Controls.Add(this.ScaleLabel);
            this.WorkPanel.Controls.Add(this.ScaleBar);
            this.WorkPanel.Location = new System.Drawing.Point(18, 172);
            this.WorkPanel.Name = "WorkPanel";
            this.WorkPanel.Size = new System.Drawing.Size(797, 526);
            this.WorkPanel.TabIndex = 40;
            // 
            // ProjectPanel
            // 
            this.ProjectPanel.Controls.Add(this.CreateNewButton);
            this.ProjectPanel.Controls.Add(this.SettingsButton);
            this.ProjectPanel.Location = new System.Drawing.Point(3, 5);
            this.ProjectPanel.Name = "ProjectPanel";
            this.ProjectPanel.Size = new System.Drawing.Size(200, 28);
            this.ProjectPanel.TabIndex = 41;
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.ProjectPanel);
            this.TopPanel.Controls.Add(this.ShapesButton);
            this.TopPanel.Controls.Add(this.BrushesButtons);
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Controls.Add(this.BrushColorLabel);
            this.TopPanel.Controls.Add(this.BrushColorButton);
            this.TopPanel.Controls.Add(this.PenColorButton);
            this.TopPanel.Location = new System.Drawing.Point(18, 5);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(797, 90);
            this.TopPanel.TabIndex = 42;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FrameDurationLabel);
            this.panel1.Controls.Add(this.FrameDurationBox);
            this.panel1.Controls.Add(this.AddFrame);
            this.panel1.Controls.Add(this.DeleteFrameButton);
            this.panel1.Controls.Add(this.FrameGallery);
            this.panel1.Controls.Add(this.SaveAnimationButton);
            this.panel1.Controls.Add(this.ChangeButton);
            this.panel1.Location = new System.Drawing.Point(821, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 579);
            this.panel1.TabIndex = 43;
            // 
            // SandBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1205, 725);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.WorkPanel);
            this.Controls.Add(this.BottomPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "SandBoxForm";
            this.Text = "Penгвин";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.BrushSizeBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.CanvasPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ScaleBar)).EndInit();
            this.FrameGallery.ResumeLayout(false);
            this.FrameGallery.PerformLayout();
            this.BottomPanel.ResumeLayout(false);
            this.BottomPanel.PerformLayout();
            this.ShapesButton.ResumeLayout(false);
            this.BrushesButtons.ResumeLayout(false);
            this.WorkPanel.ResumeLayout(false);
            this.WorkPanel.PerformLayout();
            this.ProjectPanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColorDialog ColorDialog;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button PenColorButton;
        private System.Windows.Forms.Label BrushColorLabel;
        private System.Windows.Forms.TrackBar BrushSizeBar;
        private System.Windows.Forms.Label BrushSizeBarLabel;
        private System.Windows.Forms.Label BackColorLabel;
        private System.Windows.Forms.Button BackColorButton;
        private System.Windows.Forms.Label BrushSizeValueLabel;
        private System.Windows.Forms.Button CreateNewButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.PictureBox Canvas;
        private System.Windows.Forms.Panel CanvasPanel;
        private System.Windows.Forms.TrackBar ScaleBar;
        private System.Windows.Forms.Label GalleryLabel;
        private System.Windows.Forms.Button SaveAnimationButton;
        private System.Windows.Forms.Button AddFrame;
        private System.Windows.Forms.Panel FrameGallery;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.TextBox FrameDurationBox;
        private System.Windows.Forms.Button DeleteFrameButton;
        private System.Windows.Forms.Label ScaleLabel;
        private System.Windows.Forms.Button LineButton;
        private System.Windows.Forms.Button PenButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button RectangleButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BrushColorButton;
        private System.Windows.Forms.Button EllipseButton;
        private System.Windows.Forms.Button TriangleButton;
        private System.Windows.Forms.Label FrameDurationLabel;
        private System.Windows.Forms.Button Eraser;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button CircleBrushButton;
        private System.Windows.Forms.Button SquareBrushButton;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.GroupBox ShapesButton;
        private System.Windows.Forms.GroupBox BrushesButtons;
        private System.Windows.Forms.Panel WorkPanel;
        private System.Windows.Forms.Panel ProjectPanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel panel1;
    }
}

