using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Rover.Yon
{
    public class Guney : Yon
    {
        public Guney(Koordinat koordinat) : base(koordinat)
        {
        }

        public override Yon Ileri()
        {
            Koordinat.Y -= 1;
            return new Guney(Koordinat);
        }

        public override Yon Sag()
        {
            return new Bati(Koordinat);
        }

        public override Yon Sol()
        {
            return new Dogu(Koordinat);
        }

        public override string ToString()
        {
            return "S";
        }
    }
}
