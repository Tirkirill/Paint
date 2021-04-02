
namespace Paint
{
    partial class Form1
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
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.ClearButton = new System.Windows.Forms.Button();
            this.BrushColorButton = new System.Windows.Forms.Button();
            this.BrushColorLabel = new System.Windows.Forms.Label();
            this.BrushSizeBar = new System.Windows.Forms.TrackBar();
            this.BrushSizeBarLabel = new System.Windows.Forms.Label();
            this.BackColorLabel = new System.Windows.Forms.Label();
            this.BackColorButton = new System.Windows.Forms.Button();
            this.BrushSizeValueLabel = new System.Windows.Forms.Label();
            this.CreateNewButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.GalleryLabel = new System.Windows.Forms.Label();
            this.SaveAnimationButton = new System.Windows.Forms.Button();
            this.AddFrame = new System.Windows.Forms.Button();
            this.FrameGallery = new System.Windows.Forms.Panel();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.FrameDurationBox = new System.Windows.Forms.TextBox();
            this.DeleteFrameButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BrushSizeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.FrameGallery.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(541, 38);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(100, 32);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // BrushColorButton
            // 
            this.BrushColorButton.BackColor = System.Drawing.Color.Black;
            this.BrushColorButton.Location = new System.Drawing.Point(284, 41);
            this.BrushColorButton.Name = "BrushColorButton";
            this.BrushColorButton.Size = new System.Drawing.Size(26, 23);
            this.BrushColorButton.TabIndex = 2;
            this.BrushColorButton.UseVisualStyleBackColor = false;
            this.BrushColorButton.Click += new System.EventHandler(this.BrushColorButton_Click);
            // 
            // BrushColorLabel
            // 
            this.BrushColorLabel.AutoSize = true;
            this.BrushColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BrushColorLabel.Location = new System.Drawing.Point(316, 44);
            this.BrushColorLabel.Name = "BrushColorLabel";
            this.BrushColorLabel.Size = new System.Drawing.Size(95, 20);
            this.BrushColorLabel.TabIndex = 3;
            this.BrushColorLabel.Text = "Цвет кисти";
            // 
            // BrushSizeBar
            // 
            this.BrushSizeBar.Location = new System.Drawing.Point(24, 38);
            this.BrushSizeBar.Maximum = 100;
            this.BrushSizeBar.Minimum = 5;
            this.BrushSizeBar.Name = "BrushSizeBar";
            this.BrushSizeBar.Size = new System.Drawing.Size(146, 45);
            this.BrushSizeBar.TabIndex = 4;
            this.BrushSizeBar.Value = 5;
            this.BrushSizeBar.Scroll += new System.EventHandler(this.BrushSizeBar_Scroll);
            // 
            // BrushSizeBarLabel
            // 
            this.BrushSizeBarLabel.AutoSize = true;
            this.BrushSizeBarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BrushSizeBarLabel.Location = new System.Drawing.Point(155, 44);
            this.BrushSizeBarLabel.Name = "BrushSizeBarLabel";
            this.BrushSizeBarLabel.Size = new System.Drawing.Size(112, 20);
            this.BrushSizeBarLabel.TabIndex = 5;
            this.BrushSizeBarLabel.Text = "Размер кисти";
            // 
            // BackColorLabel
            // 
            this.BackColorLabel.AutoSize = true;
            this.BackColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackColorLabel.Location = new System.Drawing.Point(437, 44);
            this.BackColorLabel.Name = "BackColorLabel";
            this.BackColorLabel.Size = new System.Drawing.Size(94, 20);
            this.BackColorLabel.TabIndex = 7;
            this.BackColorLabel.Text = "Цвет фона";
            // 
            // BackColorButton
            // 
            this.BackColorButton.BackColor = System.Drawing.Color.White;
            this.BackColorButton.Location = new System.Drawing.Point(411, 41);
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
            this.BrushSizeValueLabel.Location = new System.Drawing.Point(141, 67);
            this.BrushSizeValueLabel.Name = "BrushSizeValueLabel";
            this.BrushSizeValueLabel.Size = new System.Drawing.Size(15, 16);
            this.BrushSizeValueLabel.TabIndex = 8;
            this.BrushSizeValueLabel.Text = "5";
            // 
            // CreateNewButton
            // 
            this.CreateNewButton.Location = new System.Drawing.Point(12, 9);
            this.CreateNewButton.Name = "CreateNewButton";
            this.CreateNewButton.Size = new System.Drawing.Size(91, 23);
            this.CreateNewButton.TabIndex = 9;
            this.CreateNewButton.Text = "Создать";
            this.CreateNewButton.UseVisualStyleBackColor = true;
            this.CreateNewButton.Click += new System.EventHandler(this.CreateNewButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(648, 38);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(110, 32);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Сохранить как...";
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
            this.Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.Canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.Canvas);
            this.panel1.Location = new System.Drawing.Point(12, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 470);
            this.panel1.TabIndex = 13;
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 25;
            this.trackBar1.Location = new System.Drawing.Point(605, 560);
            this.trackBar1.Maximum = 200;
            this.trackBar1.Minimum = 25;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(207, 45);
            this.trackBar1.SmallChange = 13;
            this.trackBar1.TabIndex = 16;
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
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
            this.SaveAnimationButton.Location = new System.Drawing.Point(765, 38);
            this.SaveAnimationButton.Name = "SaveAnimationButton";
            this.SaveAnimationButton.Size = new System.Drawing.Size(92, 32);
            this.SaveAnimationButton.TabIndex = 19;
            this.SaveAnimationButton.Text = "Создать мульт";
            this.SaveAnimationButton.UseVisualStyleBackColor = true;
            this.SaveAnimationButton.Click += new System.EventHandler(this.SaveAnimationButton_Click);
            // 
            // AddFrame
            // 
            this.AddFrame.Location = new System.Drawing.Point(667, 13);
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
            this.FrameGallery.Location = new System.Drawing.Point(835, 89);
            this.FrameGallery.Name = "FrameGallery";
            this.FrameGallery.Size = new System.Drawing.Size(146, 470);
            this.FrameGallery.TabIndex = 21;
            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(765, 13);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(92, 23);
            this.ChangeButton.TabIndex = 22;
            this.ChangeButton.Text = "Изменить";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // FrameDurationBox
            // 
            this.FrameDurationBox.Location = new System.Drawing.Point(896, 13);
            this.FrameDurationBox.Name = "FrameDurationBox";
            this.FrameDurationBox.Size = new System.Drawing.Size(100, 20);
            this.FrameDurationBox.TabIndex = 23;
            this.FrameDurationBox.Text = "0,5";
            // 
            // DeleteFrameButton
            // 
            this.DeleteFrameButton.Location = new System.Drawing.Point(569, 13);
            this.DeleteFrameButton.Name = "DeleteFrameButton";
            this.DeleteFrameButton.Size = new System.Drawing.Size(92, 23);
            this.DeleteFrameButton.TabIndex = 24;
            this.DeleteFrameButton.Text = "Удалить";
            this.DeleteFrameButton.UseVisualStyleBackColor = true;
            this.DeleteFrameButton.Click += new System.EventHandler(this.DeleteFrameButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1154, 595);
            this.Controls.Add(this.DeleteFrameButton);
            this.Controls.Add(this.FrameDurationBox);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.FrameGallery);
            this.Controls.Add(this.AddFrame);
            this.Controls.Add(this.SaveAnimationButton);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CreateNewButton);
            this.Controls.Add(this.BrushSizeValueLabel);
            this.Controls.Add(this.BackColorLabel);
            this.Controls.Add(this.BackColorButton);
            this.Controls.Add(this.BrushSizeBarLabel);
            this.Controls.Add(this.BrushSizeBar);
            this.Controls.Add(this.BrushColorLabel);
            this.Controls.Add(this.BrushColorButton);
            this.Controls.Add(this.ClearButton);
            this.Name = "Form1";
            this.Text = "Penгвин";
            ((System.ComponentModel.ISupportInitialize)(this.BrushSizeBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.FrameGallery.ResumeLayout(false);
            this.FrameGallery.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog ColorDialog;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button BrushColorButton;
        private System.Windows.Forms.Label BrushColorLabel;
        private System.Windows.Forms.TrackBar BrushSizeBar;
        private System.Windows.Forms.Label BrushSizeBarLabel;
        private System.Windows.Forms.Label BackColorLabel;
        private System.Windows.Forms.Button BackColorButton;
        private System.Windows.Forms.Label BrushSizeValueLabel;
        private System.Windows.Forms.Button CreateNewButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.PictureBox Canvas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label GalleryLabel;
        private System.Windows.Forms.Button SaveAnimationButton;
        private System.Windows.Forms.Button AddFrame;
        private System.Windows.Forms.Panel FrameGallery;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.TextBox FrameDurationBox;
        private System.Windows.Forms.Button DeleteFrameButton;
    }
}

