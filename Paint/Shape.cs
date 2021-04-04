using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint
{
    abstract public class Shape:Instrument
    {
        public int fX;
        public int fY;
        public Bitmap saved;
    }
}
