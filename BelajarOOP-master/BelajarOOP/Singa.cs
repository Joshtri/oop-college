using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelajarOOP
{
    internal class Singa
    {
        //penerapan abstrak. 
        public string Nama { get; set; }
        public string Spesies{ get; set; }
        public string Status { get; set; }
        public int Umur { get; set; }
        public int JmlhMata { get; set; }
        public int JmlhKaki { get; set; }

        //constructor default. 
        //public Singa()
        //{
        //    //statis input.
        //    Nama = "Andre";
        //    Spesies = "Singa Pulau Komodo";
        //    Status = "Single";
        //    Umur = 4;
        //    JmlhMata = 2;
        //    JmlhKaki = 4; 
        //}

        // default ctor using same equals.
        //public Singa()
        //{
        //    Nama = Nama;
        //    Spesies = Spesies;
        //    Status = Status;
        //    Umur = Umur;
        //    JmlhMata = JmlhMata;
        //    JmlhKaki = JmlhKaki;
        //}


        //parameter constructor. 
        //public Singa(string s, string species, string statuo, int age, int eyes, int leg)
        //{
        //    Nama = s;
        //    Spesies = species;
        //    Status = statuo;
        //    Umur = age;
        //    JmlhMata = eyes;
        //    JmlhKaki = leg;


        //}

        //menggunakan keyword this. 
        public Singa(string s, string species, string statuo, int age, int eyes, int leg)
        {
            this.Nama = s;
            this.Spesies = species;
            this.Status = statuo;
            this.Umur = age;
            this.JmlhMata = eyes;
            this.JmlhKaki = leg;


        }





        // penerapan pewarisan. 
        public virtual void Nakal()
        {
            Console.WriteLine("Iya, singa ini nakal bet dah.");
        }

        public virtual void SeleraMakan()
        {
            Console.WriteLine("Hewan ini lahap bangettt, mah sn sadar diri makan manusia");
        }
    }
}
