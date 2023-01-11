using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelajarOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instansiasi. 
            //Singa obj1 = new Singa();
            //obj1.SeleraMakan();
            //obj1.Nakal();

            //Kucing obj2 = new Kucing();
            //obj2.SeleraMakan();
            //obj2.Nakal();


            //Anjing obj3 = new Anjing();
            //obj3.SeleraMakan();
            //obj3.Nakal();


            LuasSegitiga math1 = new LuasSegitiga(3,5,0);

            //Console.WriteLine(math1.Hitung_LuasSegitiga(math1.Tinggi, math1.Alas, math1.Luas));

            math1.CetakData();

            // Lanjut untuk ctor. 
            // instansiasi banyak cara. 

            var obj = new Singa("Deni","Singa Tengah Utara","Janda",36, 1 + 1, 4);

            //statis input.
            //obj.Nama = "Andre";
            //obj.Spesies = "Singa Pulau Komodo";
            //obj.Status = "Single";
            //obj.Umur = 4;
            //obj.JmlhMata = 2;
            //obj.JmlhKaki = 4;

            

            Console.WriteLine("Nama : " +obj.Nama);
            Console.WriteLine("Umur : " +obj.Umur);
            Console.WriteLine("Status : " +obj.Status);
            Console.WriteLine("Jmlh Kaki : " +obj.JmlhKaki);
            Console.WriteLine("Jmlh Mata " +obj.JmlhMata);
            Console.WriteLine("Spesies : " +obj.Spesies);

            Console.WriteLine("\n\n");
            //var obj2 = new Anjing();


            //Console.WriteLine(obj2.Nama);
            //Console.WriteLine(obj2.Umur);
            //Console.WriteLine(obj2.Status);
            //Console.WriteLine(obj2.JmlhKaki);
            //Console.WriteLine(obj2.JmlhMata);
            //Console.WriteLine(obj2.Spesies);




        }

        //perbedaan antara construktor (method khusus) dan function / method yang biasanya. 
        
        // ini function non-void
        public static string HitungMantan( int [] arr, int luassegicinta)
        {
            return null;
        }

        // ini function void
        public static void NamaPreman ()
        {


        }

        // constructor ( method khusus)
        // bisa pake tipe data dari kelasnya sendiri.
        public Program()
        {

        }
    }
    
}
