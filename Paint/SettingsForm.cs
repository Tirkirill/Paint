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
    public partial class SettingsForm : Form
    {
        public int FrameWidth;
        public int FrameHeight;
        public int FrameRate;
        public bool OpenLayersForm;
        public SettingsForm(int FrameWidth, int FrameHeight)
        {
            InitializeComponent();
            FrameHeightBox.Text = FrameHeight.ToString();
            FrameWidthBox.Text = FrameWidth.ToString();
            FrameRateBox.Text = Settings.framerate.ToString();
            LayersCheck.Checked = Settings.OpenLayersForm;
        }

        private void SaveSettingsButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(FrameWidthBox.Text, out FrameWidth)
    && FrameWidth <= Register.MaxFrameWidth && FrameWidth >= Register.MinFrameWidth)
            {
                if (int.TryParse(FrameHeightBox.Text, out FrameHeight) && FrameHeight <= Register.MaxFrameHeight && FrameHeight >= Register.MinFrameHeight)
                {
                    if (int.TryParse(FrameRateBox.Text, out FrameRate) && FrameRate <= Register.MaxFrameRate && FrameRate >= Register.MinFrameRate)
                    {
                        DialogResult = DialogResult.OK;
                    }
                    else MessageBox.Show(String.Format(StringResources.IncorrectFrameRateInputTemplate, Register.MinFrameRate, Register.MaxFrameRate));
                }
                else MessageBox.Show(String.Format(StringResources.IncorrectHeightInputTemplate, Register.MinFrameHeight, Register.MaxFrameHeight));
            }
            else MessageBox.Show(String.Format(StringResources.IncorrectWidthInputTemplate, Register.MinFrameWidth, Register.MaxFrameWidth));
        }

        private void LayersCheck_CheckedChanged(object sender, EventArgs e)
        {
            OpenLayersForm = LayersCheck.Checked;
        }
    }
}
