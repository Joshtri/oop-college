using OOP_Task.Child;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MainMenu: 
            Console.WriteLine("\n");
            Console.WriteLine("1. Sedan");
            Console.WriteLine("2. Bus");
            Console.WriteLine("3. Truck");

            Console.Write("Ingin menampilkan data apa : ");
            int x = int.Parse(Console.ReadLine());
            
         
                switch (x)
                {
                    case 1:
                        Sedan Mobil1 = new Sedan(4, "Horizon", 200, "Gear");
                        Sedan Mobil2 = new Sedan(4, "Toyota", 1000, "Gear");

                        Console.WriteLine("Spesifikasi \n\n");
                        Mobil1.CetakData();
                        Mobil2.CetakData();
                        goto MainMenu;
                    case 2:

                        Bus Bus1 = new Bus(4, "Emperor Switch", 5000, "Gear");
                        Bus1.CetakData();
                        goto MainMenu;
                    case 3:
                        Truck Truck1 = new Truck(6, "Pomodoro", 5000, "Gear");
                        Truck1.CetakData();
                        goto MainMenu;

                    default:
                        break;
                }
            


           




            



        }
    }
}
