
namespace Paint
{
    partial class LayersForm
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
            this.LayersPanel = new System.Windows.Forms.Panel();
            this.LayersPanelTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddLayerButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LayersPanel
            // 
            this.LayersPanel.AutoScroll = true;
            this.LayersPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.LayersPanel.Location = new System.Drawing.Point(3, 23);
            this.LayersPanel.Name = "LayersPanel";
            this.LayersPanel.Size = new System.Drawing.Size(204, 342);
            this.LayersPanel.TabIndex = 0;
            // 
            // LayersPanelTitle
            // 
            this.LayersPanelTitle.AutoSize = true;
            this.LayersPanelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LayersPanelTitle.Location = new System.Drawing.Point(3, 0);
            this.LayersPanelTitle.Name = "LayersPanelTitle";
            this.LayersPanelTitle.Size = new System.Drawing.Size(48, 20);
            this.LayersPanelTitle.TabIndex = 0;
            this.LayersPanelTitle.Text = "Слои";
            this.LayersPanelTitle.Click += new System.EventHandler(this.LayersPanelTitle_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LayersPanelTitle);
            this.panel1.Controls.Add(this.LayersPanel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 368);
            this.panel1.TabIndex = 1;
            // 
            // AddLayerButton
            // 
            this.AddLayerButton.Location = new System.Drawing.Point(12, 386);
            this.AddLayerButton.Name = "AddLayerButton";
            this.AddLayerButton.Size = new System.Drawing.Size(100, 23);
            this.AddLayerButton.TabIndex = 2;
            this.AddLayerButton.Text = "Добавить";
            this.AddLayerButton.UseVisualStyleBackColor = true;
            this.AddLayerButton.Click += new System.EventHandler(this.AddLayerButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(122, 386);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(100, 23);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // LayersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 419);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddLayerButton);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(400, 600);
            this.MinimumSize = new System.Drawing.Size(200, 400);
            this.Name = "LayersForm";
            this.Text = "Слои";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LayersForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LayersForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LayersPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LayersPanelTitle;
        private System.Windows.Forms.Button AddLayerButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}