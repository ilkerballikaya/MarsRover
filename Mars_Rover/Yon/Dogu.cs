using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Rover.Yon
{
    public class Dogu : Yon
    {
        public Dogu(Koordinat koordinat) : base(koordinat)
        {
        }

        public override Yon Ileri()
        {
            Koordinat.X += 1;
            return new Dogu(Koordinat);
        }

        public override Yon Sag()
        {
            return new Guney(Koordinat);
        }

        public override Yon Sol()
        {
            return new Kuzey(Koordinat);
        }

        public override string ToString()
        {
            return "E";
        }
    }
}
