
namespace Paint
{
    partial class CreateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateForm));
            this.CreateButton = new System.Windows.Forms.Button();
            this.BackColorDialog = new System.Windows.Forms.ColorDialog();
            this.BackColorLabel = new System.Windows.Forms.Label();
            this.BackColorButton = new System.Windows.Forms.Button();
            this.WidthBox = new System.Windows.Forms.TextBox();
            this.HeightBox = new System.Windows.Forms.TextBox();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(203, 115);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(68, 37);
            this.CreateButton.TabIndex = 0;
            this.CreateButton.Text = "Создать";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // BackColorLabel
            // 
            this.BackColorLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BackColorLabel.AutoSize = true;
            this.BackColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackColorLabel.Location = new System.Drawing.Point(41, 90);
            this.BackColorLabel.Name = "BackColorLabel";
            this.BackColorLabel.Size = new System.Drawing.Size(94, 20);
            this.BackColorLabel.TabIndex = 9;
            this.BackColorLabel.Text = "Цвет фона";
            // 
            // BackColorButton
            // 
            this.BackColorButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BackColorButton.BackColor = System.Drawing.Color.White;
            this.BackColorButton.Location = new System.Drawing.Point(15, 87);
            this.BackColorButton.Name = "BackColorButton";
            this.BackColorButton.Size = new System.Drawing.Size(26, 23);
            this.BackColorButton.TabIndex = 8;
            this.BackColorButton.UseVisualStyleBackColor = false;
            this.BackColorButton.Click += new System.EventHandler(this.BackColorButton_Click);
            // 
            // WidthBox
            // 
            this.WidthBox.Location = new System.Drawing.Point(15, 26);
            this.WidthBox.Name = "WidthBox";
            this.WidthBox.Size = new System.Drawing.Size(100, 20);
            this.WidthBox.TabIndex = 10;
            // 
            // HeightBox
            // 
            this.HeightBox.Location = new System.Drawing.Point(15, 52);
            this.HeightBox.Name = "HeightBox";
            this.HeightBox.Size = new System.Drawing.Size(100, 20);
            this.HeightBox.TabIndex = 11;
            // 
            // WidthLabel
            // 
            this.WidthLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WidthLabel.Location = new System.Drawing.Point(121, 26);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(67, 20);
            this.WidthLabel.TabIndex = 12;
            this.WidthLabel.Text = "Ширина";
            // 
            // HeightLabel
            // 
            this.HeightLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeightLabel.Location = new System.Drawing.Point(121, 52);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(66, 20);
            this.HeightLabel.TabIndex = 13;
            this.HeightLabel.Text = "Высота";
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 154);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.HeightBox);
            this.Controls.Add(this.WidthBox);
            this.Controls.Add(this.BackColorLabel);
            this.Controls.Add(this.BackColorButton);
            this.Controls.Add(this.CreateButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateForm";
            this.Text = "Создание";
            this.Load += new System.EventHandler(this.CreateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.ColorDialog BackColorDialog;
        private System.Windows.Forms.Label BackColorLabel;
        private System.Windows.Forms.Button BackColorButton;
        private System.Windows.Forms.TextBox WidthBox;
        private System.Windows.Forms.TextBox HeightBox;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label HeightLabel;
    }
}