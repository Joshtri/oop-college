using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._05._22___PBO_1
{
    class Hero
    {
        //data field. 
        public string Name;
        public int Health;

        public void Display()
        {

            Console.WriteLine($"Hero Name : {Name}");
            Console.WriteLine($"Health    : {Health}");

        }
    }

    class Batman : Hero
    {

        //data field == attribute. 
        //empty.

        public Batman()
        {

            this.Name = "Aldo";
            this.Health = 100;
        }
    }

    class Spiderman : Hero
    {

        //data field == attribute 
        //empty. 

        public Spiderman()
        {
            this.Name = "Edy";
            this.Health = 100;
        }
    }
}

