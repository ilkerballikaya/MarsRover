using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Rover
{
    public class Koordinat
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Koordinat(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return X + " " + Y; 
        }
    }
}
