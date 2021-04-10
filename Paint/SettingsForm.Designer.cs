
namespace Paint
{
    partial class SettingsForm
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
            this.FrameWidthBox = new System.Windows.Forms.TextBox();
            this.FrameHeightBox = new System.Windows.Forms.TextBox();
            this.FrameRateBox = new System.Windows.Forms.TextBox();
            this.FrameRateLabel = new System.Windows.Forms.Label();
            this.FrameHeightLabel = new System.Windows.Forms.Label();
            this.FrameWidthLabel = new System.Windows.Forms.Label();
            this.SaveSettingsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FrameWidthBox
            // 
            this.FrameWidthBox.Location = new System.Drawing.Point(12, 12);
            this.FrameWidthBox.Name = "FrameWidthBox";
            this.FrameWidthBox.Size = new System.Drawing.Size(100, 20);
            this.FrameWidthBox.TabIndex = 0;
            // 
            // FrameHeightBox
            // 
            this.FrameHeightBox.Location = new System.Drawing.Point(12, 35);
            this.FrameHeightBox.Name = "FrameHeightBox";
            this.FrameHeightBox.Size = new System.Drawing.Size(100, 20);
            this.FrameHeightBox.TabIndex = 1;
            // 
            // FrameRateBox
            // 
            this.FrameRateBox.Location = new System.Drawing.Point(12, 79);
            this.FrameRateBox.Name = "FrameRateBox";
            this.FrameRateBox.Size = new System.Drawing.Size(100, 20);
            this.FrameRateBox.TabIndex = 2;
            // 
            // FrameRateLabel
            // 
            this.FrameRateLabel.AutoSize = true;
            this.FrameRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FrameRateLabel.Location = new System.Drawing.Point(118, 79);
            this.FrameRateLabel.Name = "FrameRateLabel";
            this.FrameRateLabel.Size = new System.Drawing.Size(133, 20);
            this.FrameRateLabel.TabIndex = 3;
            this.FrameRateLabel.Text = "Частота кадров";
            // 
            // FrameHeightLabel
            // 
            this.FrameHeightLabel.AutoSize = true;
            this.FrameHeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FrameHeightLabel.Location = new System.Drawing.Point(118, 35);
            this.FrameHeightLabel.Name = "FrameHeightLabel";
            this.FrameHeightLabel.Size = new System.Drawing.Size(125, 20);
            this.FrameHeightLabel.TabIndex = 4;
            this.FrameHeightLabel.Text = "Высота кадров";
            // 
            // FrameWidthLabel
            // 
            this.FrameWidthLabel.AutoSize = true;
            this.FrameWidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FrameWidthLabel.Location = new System.Drawing.Point(118, 10);
            this.FrameWidthLabel.Name = "FrameWidthLabel";
            this.FrameWidthLabel.Size = new System.Drawing.Size(126, 20);
            this.FrameWidthLabel.TabIndex = 5;
            this.FrameWidthLabel.Text = "Ширина кадров";
            // 
            // SaveSettingsButton
            // 
            this.SaveSettingsButton.Location = new System.Drawing.Point(12, 112);
            this.SaveSettingsButton.Name = "SaveSettingsButton";
            this.SaveSettingsButton.Size = new System.Drawing.Size(239, 23);
            this.SaveSettingsButton.TabIndex = 6;
            this.SaveSettingsButton.Text = "Сохранить изменения";
            this.SaveSettingsButton.UseVisualStyleBackColor = true;
            this.SaveSettingsButton.Click += new System.EventHandler(this.SaveSettingsButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 147);
            this.Controls.Add(this.SaveSettingsButton);
            this.Controls.Add(this.FrameWidthLabel);
            this.Controls.Add(this.FrameHeightLabel);
            this.Controls.Add(this.FrameRateLabel);
            this.Controls.Add(this.FrameRateBox);
            this.Controls.Add(this.FrameHeightBox);
            this.Controls.Add(this.FrameWidthBox);
            this.Name = "SettingsForm";
            this.ShowInTaskbar = false;
            this.Text = "Penгвин: настройки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FrameWidthBox;
        private System.Windows.Forms.TextBox FrameHeightBox;
        private System.Windows.Forms.TextBox FrameRateBox;
        private System.Windows.Forms.Label FrameRateLabel;
        private System.Windows.Forms.Label FrameHeightLabel;
        private System.Windows.Forms.Label FrameWidthLabel;
        private System.Windows.Forms.Button SaveSettingsButton;
    }
}