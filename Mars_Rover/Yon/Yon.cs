using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Rover.Yon
{
    public abstract class Yon
    {
        public Koordinat Koordinat { get; set; }
        public Yon(Koordinat koordinat)
        {
            Koordinat = koordinat;
        }
        public abstract Yon Ileri();
        public abstract Yon Sag();
        public abstract Yon Sol();

    }
}
