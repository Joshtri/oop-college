using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_PBO_Hewan_n_BangunDatar
{
    internal class Hewan
    {
        public string Nama { get; set; }
        public string Species { get; set; }
        public string WarnaBulu { get; set; }
        public int Umur { get; set; }
        public int JmlhMata { get; set; } 
        public int JmlhKaki { get; set; }

        // default ctor
        public Hewan()
        { }
      

       
    }

    class Kucing : Hewan
    {
        // parameterized ctor
        public Kucing( string Name, string Jenis, int Age, string Hair) : base()
        {
            this.Nama = Name ;
            this.Species = Jenis;
            this.JmlhMata = 2;
            this.Species = Species;
            this.Umur = Age;
            this.WarnaBulu = Hair;
            this.JmlhKaki = 4;
        }


        // perilaku
        public void Makan()
        {
            Console.WriteLine($"{Nama} Makannya Lahap");
        }

        public void Tidur()
        {
            Console.WriteLine($"{Nama} sedang Tidur");
        }

        public void Rebahan()
        {
            if (Umur <= 6)
            {
                Console.WriteLine($"{Nama} Hobinya Rebahan di Teras Rumah");
            }
            else if (Umur >= 6)
            {
                Console.WriteLine($"{Nama} Hobinya Rebahan bentar doang di Kantoran");
            }
            
        }

        public void Mengmeow()
        {
            if (Umur < 6)
            {
                Console.WriteLine($"Meownya {Nama} tidak nyaring");
            }
            else if (Umur >= 6)
            {
                Console.WriteLine($"Meownya {Nama} nyaring");
            }

        }
    }

    class Anjing : Hewan
    {
        
    }
}
