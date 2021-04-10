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
    public partial class CreateForm : System.Windows.Forms.Form
    {
        public CreateForm()
        {
            InitializeComponent();
            HeightBox.Text = Register.InitFrameHeight.ToString();
            WidthBox.Text = Register.InitFrameWidth.ToString();
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
            if (int.TryParse(WidthBox.Text, out CanvasWidth)
                && CanvasWidth <= Register.MaxFrameWidth && CanvasWidth >= Register.MinFrameWidth)
            {
                if (int.TryParse(HeightBox.Text, out CanvasHeight) && CanvasHeight<= Register.MaxFrameHeight && CanvasHeight >= Register.MinFrameHeight) {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show(String.Format(StringResources.IncorrectHeightInputTemplate, Register.MinFrameHeight, Register.MaxFrameHeight));
                }
            }
            else
            {
                MessageBox.Show(String.Format(StringResources.IncorrectWidthInputTemplate, Register.MinFrameWidth, Register.MaxFrameWidth));
            }
        }

        private void CreateForm_Load(object sender, EventArgs e)
        {

        }
    }
}
