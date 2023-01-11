using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Tesa
{
    internal class Person
    {
        // Jadi Diagram untuk OOP, itu disebut UML (Unified Modeling Language)

        //character Person.
        protected int Eyes { get; set; }
        protected int Age { get; set; } 
        protected int Hands { get; set; }
        protected int Legs { get; set; }
        protected string Gender { get; set;}


        //default constructor - tanpa parameter. 
        //public Person()
        //{
        //    // ini sonde rekomended. karena ini mau dipake lagi utk object lain.
        //    Eyes = 2;
        //    Age = 10;
        //    Hands = 2;
        //    Legs = 2;
        //    Gender = "L";
        //}


        // constructor parameter alias ada isinya di parameter.
        public Person(int eye, int age, int hand, int leg, string gndr)
        {
            Eyes = eye;
            Age = age;
            Hands = hand;
            Legs = leg;
            Gender = gndr;
        }

        public virtual void Routine()
        {
            Console.WriteLine("Makan");  
        }

        public virtual void Love()
        {

            Console.WriteLine("Malas Pacaran");
        }

        public virtual void TimeSleep()
        {

            Console.WriteLine("Begadang Tross");
        }

        public virtual void BadBehavior()
        {
            Console.WriteLine("Sering Lupa dan Pesimis");
        }

    }
}
