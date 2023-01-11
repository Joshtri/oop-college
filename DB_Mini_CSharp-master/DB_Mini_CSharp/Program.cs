using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Mini_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa budi = new Mahasiswa("2022123456", "Budi", true, 2020);
            Mahasiswa dewi = new Mahasiswa("2022123457", "Dewi", false, 2020);
            Mahasiswa tomi = new Mahasiswa("2122123458", "Tomi", true, 2021);

            Mahasiswa.Cetak();

            budi.Nama = "Budi Ilkom";
            budi.Angkatan = 2018;
            Mahasiswa.Edit(budi);
            //Mahasiswa.Edit(dewi);
            //Mahasiswa.Edit(tomi); ==> karena tidak ada perubahan, jdi dikasi komentar. 

            Console.WriteLine();
            Console.WriteLine("Daftar setelah edit");
            Mahasiswa.Cetak();

            Console.WriteLine();
            MataKuliah pbo = new MataKuliah("STKOM01", "PBO", null, 4);
            MataKuliah strukturData = new MataKuliah("STKOM02", "Struktur Data", null, 4);
            MataKuliah agama = new MataKuliah("STKOM03", "Agama", null, 2);
             

            MataKuliah.Cetak();
            Console.WriteLine();
            Console.WriteLine("Daftar setelah edit");

            pbo.KodeMataKuliah = "STKOM4342";
            pbo.JumlahSks = 5;
            MataKuliah.Edit(pbo);

            strukturData.Deskripsi = "Pelajaran paling menyenangkan";
            MataKuliah.Edit(strukturData);
            MataKuliah.Cetak();

            Console.WriteLine();


            Console.WriteLine("Daftar Semester Sebelum edit");
            Semester one = new Semester(1, "Ganjil");
            Semester two = new Semester(4, "Ganjil");

            Semester.Cetak();

            Console.WriteLine("Setelah edit : ");
            two.NamaSemester = "Genap";

            Semester.Cetak();

            Console.WriteLine();
            Console.WriteLine("Daftar Nilai sebelum edit");

            var score1 = new Nilai(3, "STKOM434", "200608020", 75.5, "B");
            var score2 = new Nilai(2, "STKOM3434", "2006080034", 68.5, "A");

            Console.WriteLine("Setelah edit : ");
            Nilai.Cetak();

            score2.NilaiHuruf = "C"; // bisa char. 
            Nilai.Cetak();
        }
    }
}
