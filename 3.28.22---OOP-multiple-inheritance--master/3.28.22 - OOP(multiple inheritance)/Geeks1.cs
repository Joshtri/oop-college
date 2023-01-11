using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using System.Diagnostics;

namespace _3._28._22___OOP_multiple_inheritance_
{

    internal class Phone
    {
        protected string PhoneName { get; }
        public int Ram { get; set; }
        public int Resolutions { get; }
        public double Camerapixels { get; }

        public Phone()
        {

        }

        public Phone (string Name, int Res, double Campix, int ram)
        {
            PhoneName = Name;
            Ram = ram;
            Resolutions = Res;
            Camerapixels = Campix;

        }

        public void CameraQuality ()
        {
            

            if (Camerapixels >= 13)
            {
                Console.WriteLine($"Camera hp {PhoneName} bagus");
            }

            else if (Camerapixels <= 5)
            {
                Console.WriteLine($"Camera hp {PhoneName} tidak terlalu bagus");
            }

            //misalnya salah input.
            else
            {
                Console.WriteLine("input the number value !");
            }

            
        
        }
        public void GamingTest()
        { 

            if (Ram >= 6)
            {
                Console.WriteLine("Your phone is good for gaming");
            }
            else if (Ram <= 4)
            {
                Console.WriteLine("Your phone not realy good for gaming but okey.");
            }
            else
            {
                Console.WriteLine("Jual saja bro!");
            }
        }
    }
    class Xiaomi : Phone
    {
        //private data field. 
        private string UsbType { get; set;}
        private string Company {
            get
            {
                return Company;
            }

            set
            {
                Company = "Xiaomi";
            }
                
         }
        public Xiaomi(string Nama, int Res, int Campix, int Ram, string Usb) : base(Nama,Res,Campix,Ram)
        {
            Nama = "Xiaomi";
            UsbType = Usb;
        }

        public void UsbModels()
        {
            UsbType.ToLower();
            switch (UsbType)
            {
                case "c": Console.WriteLine("Your phone charging is fast"); break;
                case "b": Console.WriteLine("it's \"old\" reall bro"); break;
                case "a" :  Console.WriteLine("better i think"); break;
                case "micro usb" :  Console.WriteLine("plug in one way, but okay. but it's old"); break;
                case "mini usb" :  Console.WriteLine("plug in one way, but okay. but it's olds"); break;
                case "lighting charger": Console.WriteLine("Easy to break, but okey."); break;
                default:
                    break;
            }
        }

        public object Displaying()
        {
            Console.WriteLine("Test doang");
            return 0;
        }
    }
    class Apple : Phone
    {

    }
}
