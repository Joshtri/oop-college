using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace OOP_Task
{
    internal class Kendaraan
    {
        //property in c#
        protected int Roda { get; set; }
        protected string Merk { get; set; }
        protected decimal Harga { get; set; }
        protected string Transmisi { get; set; }

        //List<Kendaraan> kendaraan { get; set; }

        public Kendaraan(int roda, string merk, decimal price, string transmission)
        {
            Roda = roda;
            Merk = merk;
            Harga = price;
            Transmisi = transmission;

            //kendaraan.Add(this);
        }
      

        public virtual void HargaPasaran(decimal Harga)
        {
         //nominal normal untuk kendaraan seperti mobil lainnya. salah satunya avanza kijang.
         //bus dan truck tidak mewarisi base ini.
            if (Harga >= 2000 && Harga <= 3000)
            {
                Console.WriteLine("High Rage dalam pemasaran");
            }

            else if (Harga >= 1000 && Harga <= 1900)
            {
                Console.WriteLine("Mid Range dalam pemasaran");
            }

            else if(Harga <= 900)
            {
                Console.WriteLine("Low Range dalam pemasaran ");
            }
            else
            {
                Console.WriteLine("Very low Range");
            }
        }

        public virtual void Kategori_Kecepatan()
        {

            Console.WriteLine("Kecepatan Kendaraan ini memenuhi standar berkendara karena ramah");
        }

    
         
    }
}
