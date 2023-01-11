using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._28._22___OOP_using_base__2
{
    internal class SegiEmpat
    {
        protected double Panjang;
        protected double Lebar;

        public SegiEmpat()
        {
            Panjang = 0;
            Lebar = 0;
        }

        public SegiEmpat(double p, double l)
        {
            Panjang = p;
            Lebar = l; 
        }

        protected double HitungLuas()
        {
            return Panjang * Lebar; 
        }
    }
    class SegiEmpatBerwarna : SegiEmpat
    {
        private string warna;

        public SegiEmpatBerwarna() : base()
        {
            warna = "";
        }

        public SegiEmpatBerwarna(double p, double l, string color) : base(p, l)
        {
            warna = color;
        }


        public void CetakData()
        {
            Console.WriteLine("\tPanjang : {0}", Panjang);
            Console.WriteLine("\tLebar : {0}", Lebar);
            Console.WriteLine("\tWarna : {0}\n\n", warna);

            Console.WriteLine("Luas : {0}", HitungLuas());
        }
    }
}
