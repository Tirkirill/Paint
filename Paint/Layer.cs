using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint
{
    public abstract class Layer
    {
        public string title;

        protected Layer(string title)
        {
            this.title = title;
        }

        abstract public void DrawLayer();

        abstract public Bitmap getBM();
    }
}
