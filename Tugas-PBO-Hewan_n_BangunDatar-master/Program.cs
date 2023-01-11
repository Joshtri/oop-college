using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_PBO_Hewan_n_BangunDatar
{
    class Program
    {
        static void Main(string[] args)
        {

            // instansiasi class Kucing.

            Kucing Cat1 = new Kucing("Mbul", "Kucing Rumahan", 4, "Orange");
            Kucing Cat2 = new Kucing("Ruby", "Kucing Rumahan", 12, "Putih");
            Kucing Cat3 = new Kucing("Pipo", "Kucing Rumahan", 9, "Abu-Abu");


            //Cat1.Makan();
            //Cat1.Mengmeow();
            //Cat1.Rebahan();
            //Cat1.Tidur();

            //Cat2.Makan();
            //Cat2.Mengmeow();
            //Cat2.Rebahan();
            //Cat2.Tidur();

            //Cat3.Makan();
            //Cat3.Mengmeow();
            //Cat3.Rebahan();
            //Cat3.Tidur();



            var CatList = new List<Kucing>();
            CatList.Add(Cat1);
            CatList.Add(Cat2);
            CatList.Add(Cat3);

            for (int i = 0; i  < CatList.Count; i++)
            {
                Console.WriteLine("Data Kucing ke-{0}", i);
                Console.WriteLine($"Nama Kucing : {CatList[i].Nama}\nSpesies Kucing : {CatList[i].Species}\nWarna Bulu : {CatList[i].WarnaBulu}\nUmur : {CatList[i].Umur} Bulan\nJumlah Kaki : {CatList[i].JmlhKaki}\nJumlah Mata : {CatList[i].JmlhMata}" );
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("Perilaku : \n");

                CatList[i].Makan();
                CatList[i].Mengmeow();
                CatList[i].Rebahan();
                CatList[i].Tidur();

                Console.WriteLine();
                Console.WriteLine();
            }

            var Date = DateTime.Now;

            Console.WriteLine(Date);




            Console.WriteLine("Next \n\n");


            Bangun_Datar KelLingkaran = new Bangun_Datar();

            KelLingkaran.r = 4;

            var Final = KelLingkaran.Area(KelLingkaran.r);

            Console.WriteLine($" Hasil {Final}");

















        }
    }
}
