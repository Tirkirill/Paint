using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    public class SelectionArea
    {
        public int x;
        public int y;
        public float width;
        public float height;

        public SelectionArea()
        {
        }

        public SelectionArea(int x, int y, float width, float height)
        {
            init(x, y, width, height);
        }

        public void init(int x, int y, float width, float height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }
    }
}
