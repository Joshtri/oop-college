using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task.Child
{
    internal class Truck : Bus, IHeavyVehicle1
    {

        //private string ;

        List<Truck> ListTruck = new List<Truck>();
        public Truck(int roda, string merk, decimal price, string transmission) : base(roda, merk, price, transmission)
        {
            ListTruck.Add(this); 
        }

        public override void Kategori_Kecepatan()
        {
            base.Kategori_Kecepatan();
        }

        public override void Harga_Pemasaran(decimal price)
        {
            base.Harga_Pemasaran(price);
        }

        public new void CetakData()
        {
            for (int i = 0; i < ListTruck.Count; i++)
            {
                var Data = ListTruck[i];
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Data Truck :\n");
                Console.WriteLine($"Jumlah Roda :{Data.Roda} | Merk :{Data.Merk} | Harga :${Data.Harga} | Transmisi : {Data.Transmisi} ");
                Console.ResetColor();
                Harga_Pemasaran(Data.Harga);

                Data.Kategori_Kecepatan();
            }
        }
    }
}
