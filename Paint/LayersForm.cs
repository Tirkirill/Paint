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
    public partial class LayersForm : Form
    {
        public LayersForm(List<Layer> layers)
        {
            InitializeComponent();
            this.layers = layers;
        }

        public LayersForm() { }
        private void LayersPanelTitle_Click(object sender, EventArgs e)
        {

        }
        List<Layer> layers;
        int LocY = 10;

        public void DrawLayerGallery()
        {
            for (int i = 0; i < layers.Count; i++)
            {
                LayerFrame lF = new LayerFrame(LayersPanel, LocY - LayersPanel.VerticalScroll.Value, i.ToString(), layers[i].title, layers[i].getBM());
                LocY += 50;
            }
        }

        private void AddLayerButton_Click(object sender, EventArgs e)
        {

        }

        private void LayersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.OpenLayersForm = false;
        }

        private void LayersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form fr1 = Owner;
        }
    }
}
