using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task.Child
{
    internal class Sedan : Kendaraan
    {

        List<Sedan> ListSedan = new List<Sedan>();
        public Sedan(int roda, string merk, decimal price, string transmission) : base(roda, merk, price, transmission)
        {

            ListSedan.Add(this);
        }

        



        public override void HargaPasaran(decimal Harga)
        {
            base.HargaPasaran(Harga);
        }

        public void CetakData()
        {
            Console.WriteLine("Data Mobil Sedan\n");
            for (int i = 0; i < ListSedan.Count; i++)
            {
                 
                var Data = ListSedan[i];
                Console.WriteLine($"Jumlah Roda :{Data.Roda} | Merk :{Data.Merk} | Harga :${Data.Harga} | Transmisi : {Data.Transmisi} ");
                HargaPasaran(Data.Harga);
                Kategori_Kecepatan();

            }  
        }
    }
}
