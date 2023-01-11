using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Mini_CSharp
{
    internal class Nilai
    {
        public int IdSemester { get; set; } //Key
        public string KodeMataKuliah { get; set; } //Key
        public string Nim { get; set; } //Key
        public double NilaiAngka { get; set; }
        public string NilaiHuruf { get; set; }

        //buat list 
        private static List<Nilai> ListNilai = new List<Nilai>();
        public Nilai(int idSmstr, string kodemk, string nim, double nilainumber, string nilaihuruf)
        {
            var score = ListNilai.Find(x => x.IdSemester == idSmstr);

            if (score != null)
            {
                Console.WriteLine("Mata kuliah dengan KodeMK : {0} sudah ada.", idSmstr);

                return;
            }

            IdSemester = idSmstr;
            KodeMataKuliah = kodemk;
            Nim = nim;
            NilaiAngka = nilainumber;
            NilaiHuruf = nilaihuruf;

            ListNilai.Add(this);
        }

        public static void Cetak()
        {
            Console.WriteLine("Daftar Nilai");
            for (int i = 0; i < ListNilai.Count; i++)
            {
                var score = ListNilai[i];
                Console.WriteLine("IDSmster : {0}, KodeMK : {1}, Nim : {2}, NilaiAngka : {3}, NilaiHuruf : {4} ", score.IdSemester, score.KodeMataKuliah, score.Nim, score.NilaiAngka, score.NilaiHuruf);
            }
        }

        public static void Edit(int idsmst, string nilaihrf, string nim, double nilaiangka, string kodemk)
        {
            var score = ListNilai.Find(x => x.Nim == nim);

            if (score != null)
            {
                score.IdSemester = idsmst;
                score.NilaiHuruf = nilaihrf;
                score.KodeMataKuliah = kodemk;
                score.NilaiAngka = nilaiangka;



            }

        }

        public static void Edit(Nilai newData)
        {
            var score = ListNilai.Find(x => x.Nim == newData.Nim);

            if (score != null)
            {
                score.IdSemester = newData.IdSemester;
                score.NilaiHuruf = newData.NilaiHuruf;
                score.KodeMataKuliah = newData.KodeMataKuliah;
                score.NilaiAngka = newData.NilaiAngka;
            }

        }

        public static void Hapus(string nim)
        {
            var score = ListNilai.Find(x => x.Nim == nim);

            if (score != null)
            {
                ListNilai.Remove(score);
            }
        }
    }
}
