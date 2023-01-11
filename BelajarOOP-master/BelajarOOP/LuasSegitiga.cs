using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelajarOOP
{
    internal class LuasSegitiga
    {
        public double Alas;
        public double Tinggi;
        public double Luas;

        public LuasSegitiga(double a, double t, double l)
        {
            Alas = a;
            Tinggi = t;
            Luas = l;
        }
        
        public double Hitung_LuasSegitiga(double a, double t )
        {
            return _= 0.5 * a * t; 
        }

        public double Hitung_LuasJajarGenjang(double a, double t, double l)
        {
            return  a * t;
        }


        public void CetakData()
        {
            Console.WriteLine("Hasil Luas JJR : " + Hitung_LuasJajarGenjang(Alas, Tinggi, Luas));
            Console.WriteLine("Hasil Luas segitiga bermuda : " + Hitung_LuasSegitiga(Alas, Tinggi));
        }


    }
}
