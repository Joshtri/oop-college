using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Tesa
{
    internal class Programmer : Person
    {
        // data field / atribut sifat access private. 
        private string Name { get; set; }
        private string JobPosition { get; set; }
        private string IDWorker { get; set; }

        // constructornya.

        //list/ daftar. 
        List<Programmer> ListProgrammer = new List<Programmer>();

        public Programmer(int ag, int eys, int hnd, int leg, string gndr, string name,
            string position, string ID) : base(eys, ag, hnd, leg, gndr)      
        {
            Name = name;
            JobPosition = position;
            IDWorker = ID;

            ListProgrammer.Add(this);
        }


        //perilaku programmer.
        public override void BadBehavior()
        {
            
            Console.WriteLine("Kurang suka jalan-jalan\n");
            Console.WriteLine("Perilaku Bawaan : ");
            base.BadBehavior();
        }
        public override void Routine()
        {
            Console.WriteLine("Ngoding lah.");
        }
        public override void TimeSleep()
        {
            Console.WriteLine("Bangun Malam, Tidur Pagi.");
        }
        public override void Love()
        {
            Console.WriteLine("Lebih cinta Linux atau Laptop.");
        }

        public void DisplayIdentity()
        {
            for (int i = 0; i < ListProgrammer.Count; i++)
            {
                var pro = ListProgrammer[i];
                Console.WriteLine($"Name : {pro.Name}, Job : {pro.JobPosition}, ID : {pro.IDWorker}" +
                    $",Gender : {pro.Gender}, Age : {pro.Age}, Eyes {pro.Eyes}, Legs : {pro.Legs}");
            }
        }

        public void DisplayBehavior()
        {
            Console.WriteLine("Rutinitas : ");
            Routine();
            Console.WriteLine(); // spasi

            Console.WriteLine("Time Sleep : ");
            TimeSleep();
            Console.WriteLine(); // spasi

            Console.WriteLine("Relationship : ");
            Love();
            Console.WriteLine(); // spasi

            Console.WriteLine("Bad Behavior");
            BadBehavior();
          



        }

    }
}
