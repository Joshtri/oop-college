using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Mini_CSharp
{
    internal class MataKuliah
    {
        public string KodeMataKuliah { get; set; } //Key
        public string NamaMataKuliah { get; set; }
        public string Deskripsi { get; set; }
        public double JumlahSks { get; set; }


        // buat list agar terangkum dengan baik.
        private static List<MataKuliah> ListMK = new List<MataKuliah>();
        public MataKuliah(string kodeMk, string namaMk, string deskripsi, double jumlahSks)
        {
            var mk = ListMK.Find(x => x.KodeMataKuliah == kodeMk);

            if (mk != null)
            {
                Console.WriteLine("Mata kuliah dengan KodeMK : {0} sudah ada.", kodeMk);

                return;
            }

            KodeMataKuliah = kodeMk;
            NamaMataKuliah = namaMk;
            Deskripsi = deskripsi;
            JumlahSks = jumlahSks;

            ListMK.Add(this);
        }
        public static void Cetak()
        {
            Console.WriteLine("Daftar MK");
            for (int i = 0; i < ListMK.Count; i++)
            {
                var mk = ListMK[i];
                Console.WriteLine("KodeMK : {0}, Nama MK : {1}, Deskripsi : {2}, SKS : {3}", mk.KodeMataKuliah, mk.NamaMataKuliah, mk.Deskripsi, mk.JumlahSks);
            }
        }

        public static void Edit(string code, string namamk, string desc, int jmlhsks)
        {
            var mk = ListMK.Find(x => x.KodeMataKuliah == code);

            if (mk != null)
            {
                mk.NamaMataKuliah = namamk;
                mk.Deskripsi = desc;
                mk.JumlahSks = jmlhsks;
            }

        }

        public static void Edit(MataKuliah newData)
        {
            var mk = ListMK.Find(x => x.KodeMataKuliah == newData.KodeMataKuliah);

            if (mk != null)
            {
                mk.NamaMataKuliah = newData.NamaMataKuliah;
                mk.Deskripsi = newData.Deskripsi;
                mk.JumlahSks = newData.JumlahSks;

            }

        }

        public static void Hapus(string code)
        {
            var mk = ListMK.Find(x => x.KodeMataKuliah == code);

            if (mk != null)
            {
                ListMK.Remove(mk);
            }
        }
    }
}
