using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace _03._05._22___PBO_1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Cara Instansiasi.
            Mobil Car1 = new Mobil();

            Console.WriteLine("\"Kasus !\"Penilangan di Eltari Sebanyak 10 Motor dan 5 Mobil\n\n");

            Console.WriteLine("\t\tJawaban :");


            Console.Write("Berapa jumlah mobil yang ditilang = ");
            int n = int.Parse(Console.In.ReadLine());


   

            // loop for car.
            for (int i =  1; i <= n; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\t\tObjek Mobil ke-{0}\n", i );
                Console.ResetColor();

                Console.Write("Masukkan Nama : ");
                Car1.NamaPengendara = Console.ReadLine();

                Console.Write("Masukkan Umur : ");
                Car1.Umur = int.Parse(Console.ReadLine());

                Console.Write("Masukkan transmisi :");
                Car1.Transmisi = int.Parse(Console.ReadLine());

                Console.Write("Masukkan Bahan Bakar :");
                Car1.BahanBakar = int.Parse(Console.ReadLine());

                Console.WriteLine("Masukkan Jumlah Roda : {0}", Car1.JumlahRoda);


                Console.Write("Masukkan Merk Kendaraan :");
                Car1.MerkKendaraan = Console.ReadLine();

                Console.Write("Masukkan Tipe Kendaraan : ");
                Car1.TipeKendaraan = Console.ReadLine();

                Console.Write("Masukkan Nomor Polisi :");
                Car1.NomorPolisi = Console.ReadLine();


                // tambahan plot. 
                Car1.IzinBerkendara();

            

                



            }




            // Cara Instansiasi.
            Motor Biycle1 = new Motor();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\t\tObjek Motor 1\n");
            Console.ResetColor();

            Console.Write("Masukkan Nama : ");
            Biycle1.NamaPengendara = Console.ReadLine();

            Console.Write("Masukkan Umur : ");
            Biycle1.Umur = int.Parse(Console.ReadLine());

            Console.Write("Masukkan transmisi :");
            Biycle1.Transmisi = int.Parse(Console.ReadLine());

            Console.Write("Masukkan Bahan Bakar :");
            Biycle1.BahanBakar = int.Parse(Console.ReadLine());
 

            Console.WriteLine("Masukkan Jumlah Roda : {0}\n", Biycle1.JumlahRoda);
           

            Console.Write("Masukkan Merk Kendaraan :");
            Biycle1.MerkKendaraan = Console.ReadLine();

            Console.Write("Masukkan Tipe Kendaraan : ");
            Biycle1.TipeKendaraan = Console.ReadLine();

            Console.Write("Masukkan Nomor Polisi :");
            Biycle1.NomorPolisi = Console.ReadLine();


        }

        static int LuasSegitiga()  // method non void.
        {
            int hasil = 1344; 

            return hasil; 
        }

        static void LuasLingkaran() // method void
        {
            // tidak perlu return value.
        }

     
        
    }


}
