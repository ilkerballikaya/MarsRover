using Mars_Rover.Yon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Rover
{
    public class Rover
    {
        public Yon.Yon RoverYon;
        public string HareketKomutlari;
        public List<int> AlanBuyuklugu;

        public Rover(Koordinat koordinat, string yonString, string hareketKomutlari, List<int> alanBuyuklugu)
        {
            AlanBuyuklugu = alanBuyuklugu;
            HareketKomutlari = hareketKomutlari;
            YonBul(yonString, koordinat);
        }

        public void İleriGit()
        {
            RoverYon = RoverYon.Ileri();
            if (RoverYon.Koordinat.X > AlanBuyuklugu[0] || RoverYon.Koordinat.X < 0 || RoverYon.Koordinat.Y > AlanBuyuklugu[1] || RoverYon.Koordinat.Y < 0)
            {
                Console.WriteLine("Araç alan dışına çıkamaz!");
                throw new  Exception("Araç alan dışına çıkamaz!");
            }
        }

        public void SagaDon()
        {
            RoverYon = RoverYon.Sag();
        }

        public void SolaDon()
        {
            RoverYon = RoverYon.Sol();
        }

        private void YonBul(string yonString, Koordinat koordinat)
        {
            if (yonString == "N")
            {
                RoverYon = new Kuzey(koordinat);
            }
            else if (yonString == "S")
            {
                RoverYon = new Guney(koordinat);
            }
            else if (yonString == "E")
            {
                RoverYon = new Dogu(koordinat);
            }
            else if (yonString == "W")
            {
                RoverYon = new Bati(koordinat);
            }
            else
            {
                throw new Exception("Yön Bulunamadı!");
            }
        }

        public void Hesapla()
        {
            for (int i = 0; i < HareketKomutlari.Length; i++)
            {
                Console.WriteLine(this.ToString());
                if (HareketKomutlari[i] == 'L')
                {
                    SolaDon();
                }
                else if (HareketKomutlari[i] == 'R')
                {
                    SagaDon();
                }
                else if (HareketKomutlari[i] == 'M')
                {
                    İleriGit();
                }
                else
                {
                    Console.WriteLine("Komut Bulunamadı!");
                    throw new Exception("Komut Bulunamadı!");
                }
            }
        }

        public override string ToString()
        {
            return RoverYon.Koordinat.ToString() + " " + RoverYon.ToString();
        }
    }
}
