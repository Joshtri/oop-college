using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Mini_CSharp
{
    internal class Semester
    {
        public int IdSemester { get; set; } //Key
        public string NamaSemester { get; set; }

        //buat list untuk mendapatkan data. 
        private static List<Semester> ListSmster = new List<Semester>();

        public Semester(int idSemester, string namaSemester)
        {
            var smster = ListSmster.Find(x => x.IdSemester == idSemester);

            if (smster != null)
            {
                Console.WriteLine("Mata kuliah dengan KodeMK : {0} sudah ada.", idSemester);

                return;
            }

            IdSemester = idSemester;
            NamaSemester = namaSemester;

            ListSmster.Add(this);
        }

        public static void Cetak()
        {
            Console.WriteLine("Daftar Semester");
            for (int i = 0; i < ListSmster.Count; i++)
            {
                var smster = ListSmster[i];
                Console.WriteLine("IDsmster : {0}, Nama Semester : {1} ", smster.IdSemester, smster.NamaSemester);
            }
        }

        public static void Edit(int id, string namasmster)
        {
            var smster = ListSmster.Find(x => x.IdSemester == id);

            if (smster != null)
            {
                smster.IdSemester = id;
                smster.NamaSemester = namasmster;

            }

        }

        public static void Edit(Semester newData)
        {
            var smster = ListSmster.Find(x => x.IdSemester == newData.IdSemester);

            if (smster != null)
            {
                smster.IdSemester = newData.IdSemester;
                smster.NamaSemester = newData.NamaSemester;


            }

        }

        public static void Hapus(int id)
        {
            var smster = ListSmster.Find(x => x.IdSemester == id);

            if (smster != null)
            {
                ListSmster.Remove(smster);
            }
        }
    }
}
