using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Rover.Yon
{
    public class Bati : Yon
    {
        public Bati(Koordinat koordinat) : base(koordinat)
        {
        }

        public override Yon Ileri()
        {
            Koordinat.X -= 1;
            return new Bati(Koordinat);
        }

        public override Yon Sag()
        {
            return new Kuzey(Koordinat);
        }

        public override Yon Sol()
        {
            return new Guney(Koordinat);
        }

        public override string ToString()
        {
            return "W";
        }
    }
}
