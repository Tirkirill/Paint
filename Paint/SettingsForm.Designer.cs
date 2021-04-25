
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.FrameWidthBox = new System.Windows.Forms.TextBox();
            this.FrameHeightBox = new System.Windows.Forms.TextBox();
            this.FrameRateBox = new System.Windows.Forms.TextBox();
            this.FrameRateLabel = new System.Windows.Forms.Label();
            this.FrameHeightLabel = new System.Windows.Forms.Label();
            this.FrameWidthLabel = new System.Windows.Forms.Label();
            this.SaveSettingsButton = new System.Windows.Forms.Button();
            this.AdditionalForms = new System.Windows.Forms.GroupBox();
            this.LayersCheck = new System.Windows.Forms.CheckBox();
            this.AdditionalForms.SuspendLayout();
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
            this.FrameRateBox.Location = new System.Drawing.Point(12, 71);
            this.FrameRateBox.Name = "FrameRateBox";
            this.FrameRateBox.Size = new System.Drawing.Size(100, 20);
            this.FrameRateBox.TabIndex = 2;
            // 
            // FrameRateLabel
            // 
            this.FrameRateLabel.AutoSize = true;
            this.FrameRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FrameRateLabel.Location = new System.Drawing.Point(118, 71);
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
            this.SaveSettingsButton.Location = new System.Drawing.Point(12, 226);
            this.SaveSettingsButton.Name = "SaveSettingsButton";
            this.SaveSettingsButton.Size = new System.Drawing.Size(239, 23);
            this.SaveSettingsButton.TabIndex = 6;
            this.SaveSettingsButton.Text = "Сохранить изменения";
            this.SaveSettingsButton.UseVisualStyleBackColor = true;
            this.SaveSettingsButton.Click += new System.EventHandler(this.SaveSettingsButton_Click);
            // 
            // AdditionalForms
            // 
            this.AdditionalForms.Controls.Add(this.LayersCheck);
            this.AdditionalForms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdditionalForms.Location = new System.Drawing.Point(13, 105);
            this.AdditionalForms.Name = "AdditionalForms";
            this.AdditionalForms.Size = new System.Drawing.Size(238, 64);
            this.AdditionalForms.TabIndex = 7;
            this.AdditionalForms.TabStop = false;
            this.AdditionalForms.Text = "Дополнительные окна";
            // 
            // LayersCheck
            // 
            this.LayersCheck.AutoSize = true;
            this.LayersCheck.Location = new System.Drawing.Point(7, 26);
            this.LayersCheck.Name = "LayersCheck";
            this.LayersCheck.Size = new System.Drawing.Size(67, 24);
            this.LayersCheck.TabIndex = 0;
            this.LayersCheck.Text = "Слои";
            this.LayersCheck.UseVisualStyleBackColor = true;
            this.LayersCheck.CheckedChanged += new System.EventHandler(this.LayersCheck_CheckedChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 261);
            this.Controls.Add(this.AdditionalForms);
            this.Controls.Add(this.SaveSettingsButton);
            this.Controls.Add(this.FrameWidthLabel);
            this.Controls.Add(this.FrameHeightLabel);
            this.Controls.Add(this.FrameRateLabel);
            this.Controls.Add(this.FrameRateBox);
            this.Controls.Add(this.FrameHeightBox);
            this.Controls.Add(this.FrameWidthBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(270, 300);
            this.MinimumSize = new System.Drawing.Size(270, 300);
            this.Name = "SettingsForm";
            this.ShowInTaskbar = false;
            this.Text = "Настройки";
            this.AdditionalForms.ResumeLayout(false);
            this.AdditionalForms.PerformLayout();
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
        private System.Windows.Forms.GroupBox AdditionalForms;
        private System.Windows.Forms.CheckBox LayersCheck;
    }
}