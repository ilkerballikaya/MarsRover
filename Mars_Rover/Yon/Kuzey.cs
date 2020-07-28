using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Rover.Yon
{
    public class Kuzey : Yon
    {
        public Kuzey(Koordinat koordinat) : base(koordinat)
        {
        }

        public override Yon Ileri()
        {
            Koordinat.Y += 1;
            return new Kuzey(Koordinat);
        }

        public override Yon Sag()
        {
            return new Dogu(Koordinat);
        }

        public override Yon Sol()
        {
            return new Bati(Koordinat);
        }

        public override string ToString()
        {
            return "N";
        }
    }
}
