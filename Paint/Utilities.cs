using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    static class Utilities
    {
        static public float GetSizeCoef(int size, double scale)
        {
            return (float)(size * scale);
        }
        static public float CoordForG(int X, float SizeCoef)
        {
            return X - SizeCoef / 2;
        }

        static public float CoordForGI(int X, double scale, int size)
        {
            return (float)(X / scale - size / 2);
        }
    }
}
