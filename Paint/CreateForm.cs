using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class CreateForm : Form
    {
        public CreateForm()
        {
            InitializeComponent();
        }

        public Color CanvasColor = Color.White;
        public int CanvasWidth;
        public int CanvasHeight;

        private void BackColorButton_Click(object sender, EventArgs e)
        {
            if (BackColorDialog.ShowDialog() == DialogResult.OK)
            {
                CanvasColor = BackColorDialog.Color;
                BackColorButton.BackColor = BackColorDialog.Color;
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            CanvasWidth = int.Parse(WidthBox.Text);
            CanvasHeight = int.Parse(HeightBox.Text);
        }
    }
}
