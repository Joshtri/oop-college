using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belajar_OOP_Eps_2
{
    internal class Segitiga : BangunDatar
    {
        //data field. 
        private double Luas;
        private double Alas;
        private double Tinggi;
        private double Sisi; 


        // constructor segitiga harus ada.

        public Segitiga(double l, double a, double t, double s, string d, string f, string k, int u) : base(d,f,k,u)
        {
            this.Luas = l;
            this.Alas = a;
            this.Tinggi = t;
            this.Sisi = s;
        }

        // ini untuk hitung.
        public override double HitungLuas()
        {
            return 0.5 * Alas * Tinggi; 
        }

        public override double HitungKeliling()
        {
            return Sisi + Sisi + Sisi;
        }

        public void CetakData()
        {
            Console.WriteLine("Keliling : " + HitungKeliling());
            Console.WriteLine("Luas : " +HitungLuas());
        }


    }
}
