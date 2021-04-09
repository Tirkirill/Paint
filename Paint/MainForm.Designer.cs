
namespace Paint
{
    partial class MainForm
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
            this.FreePaintButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FreePaintButton
            // 
            this.FreePaintButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.FreePaintButton.Location = new System.Drawing.Point(98, 12);
            this.FreePaintButton.Name = "FreePaintButton";
            this.FreePaintButton.Size = new System.Drawing.Size(80, 30);
            this.FreePaintButton.TabIndex = 0;
            this.FreePaintButton.Text = "Песочница";
            this.FreePaintButton.UseVisualStyleBackColor = true;
            this.FreePaintButton.Click += new System.EventHandler(this.FreePaintButton_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Тесты";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 52);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FreePaintButton);
            this.Name = "MainForm";
            this.Text = "Penгвин: Главная";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FreePaintButton;
        private System.Windows.Forms.Button button1;
    }
}