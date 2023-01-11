using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task.Child
{
    public interface IHeavyVehicle1
    {
        void Kategori_Kecepatan();
        void Harga_Pemasaran(decimal price);

    }
    internal class Bus : Kendaraan, IHeavyVehicle1
    {

        List<Bus> ListBus = new List<Bus>(); 
        public Bus(int roda, string merk, decimal price, string transmission) : base(roda, merk, price, transmission)
        {
 
            ListBus.Add(this); 
        }

        public virtual new void Kategori_Kecepatan()
        {
            Console.WriteLine("Kecepatan kendaraan ini cukup berat karena memiliki daya angkut yang banyak");
        }
        public virtual void Harga_Pemasaran(decimal price)
        {
            // saya ibaratkan Bus dengan harga ini sudah termasuk tinggi,rendah,dan seterusnya. 
            // sekedar pemisalan saja. 
            if (Harga >= 7000 && Harga <= 10000)
            {
                Console.WriteLine("High Rage dalam pemasaran\n");
            }

            else if (Harga >= 3000 && Harga <= 6000)
            {
                Console.WriteLine("Mid Range dalam pemasaran\n");
            }

            else if (Harga <= 2900)
            {
                Console.WriteLine("Low Range dalam pemasaran \n");
            }
            else
            {
                Console.WriteLine("Very low Range\n");
            }
        }

        public void CetakData()
        {
            for (int i = 0; i < ListBus.Count; i++)
            {
                var Data = ListBus[i];
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Data Bus :");
                Console.WriteLine($"Jumlah Roda :{Data.Roda} | Merk :{Data.Merk} | Harga :${Data.Harga} | Transmisi : {Data.Transmisi} ");
                Harga_Pemasaran(Data.Harga);
                Kategori_Kecepatan();

                Console.ResetColor();

            }
        }
    }
}
