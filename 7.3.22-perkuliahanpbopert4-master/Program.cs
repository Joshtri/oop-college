using System;

namespace _7._3._22_perkuliahanpbopert4
{
    class Program
    {
        static void Main(string[] args)
        {
            



            var Cat1 = new Kucing();

            Cat1.JumlahKaki = 4 ; 
            Cat1.umur = 1 ;
            Cat1.WarnaBulu = "Abu-abu";
            Cat1.Nama = "Jemi";


            Console.WriteLine(Cat1.JumlahKaki);
             Console.WriteLine(Cat1.Nama);
             Console.WriteLine(Cat1.WarnaBulu);
             Console.WriteLine(Cat1.umur);



                    Console.WriteLine("\t\tPerilaku : ");
                    
             Cat1.Makan();
             Cat1.Mencakar();
             Cat1.Berlari();
             Cat1.Tidur();


            

        }
    }

    internal class Kucing {
        //data field // atribute/ karakteristik dari kelas.

        public int JumlahKaki {get; set;}
        public string Nama { get; set; }
        public string WarnaBulu { get; set; }
        public int umur {get; set;}
        

        //perilaku 

        public void Makan(){

        Console.WriteLine($"{Nama} sedang makan");
        }
    
        public void Mencakar(){

            Console.WriteLine($"{Nama} sedang mencakar");
        }
    
        public void Berlari(){

            Console.WriteLine($"{Nama} sedang berlari");
         }


       public void Tidur(){

            Console.WriteLine($"{Nama} sedang tidur");
        }
    }
 }
