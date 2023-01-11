using System;

namespace _3._27._22___OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Lingkaran obj = new Lingkaran();
            obj.Panjang = 4; 
            obj.Lebar = 3 ; 

            
            // hitung luas.
            Console.WriteLine(obj.HitungLuas(obj.Panjang, obj.Lebar)); 


            //hitung luas segitiga. 
             Segitiga obj1 = new Segitiga(); 

             obj1.Alas = 4 ; 
             obj1.Tinggi = 3 ; 


             Console.WriteLine(obj1.HitungLuasSegitiga(obj1.Alas, obj1.Tinggi));

             obj.Jari_jari = 3; 

             System.Console.WriteLine(obj.HitungKeliling(obj.Jari_jari));
        }
    }
}
