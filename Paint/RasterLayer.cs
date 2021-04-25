using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    public class RasterLayer : Layer
    {
        public RasterLayer(string title, Bitmap bm, Graphics gI):base(title)
        {
            this.bm = bm;
            this.gI = gI;
            gBM = Graphics.FromImage(bm);
        }

        Bitmap bm;
        public Graphics gBM;
        Graphics gI;

        public override void DrawLayer()
        {
            gI.DrawImage(bm, 0, 0);
        }

        public override Bitmap getBM()
        {
            return bm;
        }
    }
}
