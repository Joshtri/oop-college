using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Mini_CSharp
{
    internal class Mahasiswa
    {
        //data field
        public string Nim { get; set; } //Key
        public string Nama { get; set; }
        public bool JenisKelamin { get; set; }
        public int Angkatan { get; set; }

        // list
        private static List<Mahasiswa> ListMahasiwa = new List<Mahasiswa>();

        public Mahasiswa(string nim, string nama, bool jenisKelamin, int angkatan)
        {
            var mahasiswa = ListMahasiwa.Find(x => x.Nim == nim);

            if (mahasiswa != null)
            {
                Console.WriteLine("Mahasiswa dengan nim : {0} sudah ada.", nim);

                return;
            }

            Nim = nim;
            Nama = nama;
            JenisKelamin = jenisKelamin;
            Angkatan = angkatan;

            ListMahasiwa.Add(this);
        }

        public static void Cetak()
        {
            Console.WriteLine("Daftar Mahasiswa");
            for (int i = 0; i < ListMahasiwa.Count; i++)
            {
                var mahasiswa = ListMahasiwa[i];
                Console.WriteLine("Nim : {0}, Nama : {1}, JK : {2}, Angkatan : {3}", mahasiswa.Nim, mahasiswa.Nama, mahasiswa.JenisKelamin, mahasiswa.Angkatan);
            }
        }

        public static void Edit(string nim, string namaBaru, bool jkBaru, int angkatanBaru)
        {
            var mahasiswa = ListMahasiwa.Find(x => x.Nim == nim);

            if (mahasiswa != null)
            {
                mahasiswa.Nama = namaBaru;
                mahasiswa.JenisKelamin = jkBaru;
                mahasiswa.Angkatan = angkatanBaru;
            }

        }

        public static void Edit(Mahasiswa newData)
        {
            var mahasiswa = ListMahasiwa.Find(x => x.Nim == newData.Nim);

            if (mahasiswa != null)
            {
                mahasiswa.Nama = newData.Nama;
                mahasiswa.JenisKelamin = newData.JenisKelamin;
                mahasiswa.Angkatan = newData.Angkatan;
            }

        }

        public static void Hapus(string nim)
        {
            var mahasiswa = ListMahasiwa.Find(x => x.Nim == nim);

            if (mahasiswa != null)
            {
                ListMahasiwa.Remove(mahasiswa);
            }
        }
    }
}

