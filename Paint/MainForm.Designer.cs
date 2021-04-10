
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.NewProjectButton = new System.Windows.Forms.Button();
            this.OpenVideoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewProjectButton
            // 
            this.NewProjectButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.NewProjectButton.Location = new System.Drawing.Point(30, 12);
            this.NewProjectButton.Name = "NewProjectButton";
            this.NewProjectButton.Size = new System.Drawing.Size(100, 30);
            this.NewProjectButton.TabIndex = 0;
            this.NewProjectButton.Text = "Новый проект";
            this.NewProjectButton.UseVisualStyleBackColor = true;
            this.NewProjectButton.Click += new System.EventHandler(this.FreePaintButton_Click);
            // 
            // OpenVideoButton
            // 
            this.OpenVideoButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OpenVideoButton.Location = new System.Drawing.Point(140, 12);
            this.OpenVideoButton.Name = "OpenVideoButton";
            this.OpenVideoButton.Size = new System.Drawing.Size(100, 30);
            this.OpenVideoButton.TabIndex = 1;
            this.OpenVideoButton.Text = "Открыть видео";
            this.OpenVideoButton.UseVisualStyleBackColor = true;
            this.OpenVideoButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 54);
            this.Controls.Add(this.OpenVideoButton);
            this.Controls.Add(this.NewProjectButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Penгвин: Главная";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewProjectButton;
        private System.Windows.Forms.Button OpenVideoButton;
    }
}