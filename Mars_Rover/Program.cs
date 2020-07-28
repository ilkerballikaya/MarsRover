using Mars_Rover.Yon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Rover
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Rover> araclar = new List<Rover>();
            bool devam = true;

            Console.WriteLine("Alanın kaça kaç olacağını giriniz: ");
            List<int> alanBuyuklugu = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
            
            while (devam)
            {
                Console.WriteLine("Aracın koordinatını ve baktığı yönü giriniz: ");
                string[] konum = Console.ReadLine().Trim().ToUpper().Split(' ');
                Console.WriteLine("Komutları giriniz: ");

                string hareketKomutlari = Console.ReadLine().ToUpper();
                Koordinat rKoordinat = new Koordinat(Convert.ToInt32(konum[0]), Convert.ToInt32(konum[1]));
                Rover rover = new Rover(rKoordinat, konum[2].ToString(), hareketKomutlari, alanBuyuklugu);
                araclar.Add(rover);

                Console.WriteLine("Başka araç eklemek ister misin?");
                string aracEkle = Console.ReadLine();

                if (aracEkle.ToUpper() != "E")
                {
                    devam = false;
                }
            }

            foreach (Rover r in araclar)
            {
                r.Hesapla();
                Console.WriteLine("Son Durum: " + r.ToString());
                Console.WriteLine("------------------------------");
            }

            Console.ReadLine();
        }


    }
}
