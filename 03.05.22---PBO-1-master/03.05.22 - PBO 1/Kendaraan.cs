using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._05._22___PBO_1
{
      internal class Kendaraan   // base class, super class, dan parent.
    {
        //karakteristik

        public string NamaPengendara { get; set; }
        public int Umur { get; set; }
        public int JumlahRoda { get; set; }
        public int BahanBakar { get; set; }
        public string NomorPolisi { get; set; }
        public int Transmisi { get; set; }
        public string MerkKendaraan { get; set; }
        public string TipeKendaraan { get; set; }

        //perilaku. 

        public void IzinBerkendara()
        {
            if (Umur >= 19 )
            {
                Console.WriteLine($"Anda berumur {Umur}, sanksi anda ringan.");
            }

            else
            {
                Console.WriteLine($"Anda berumur {Umur}, sanksi anda berat karena umur kurang dari 19 Tahun.");
            }

        }




    }
    //dikatakan child class, derived class, sub class.
    class Mobil : Kendaraan
    {
        //data field. 
            //empty

        public Mobil() {
            this.NamaPengendara = NamaPengendara;
            this.JumlahRoda = 4;
            this.Umur = Umur;
            this.MerkKendaraan = MerkKendaraan;
            this.TipeKendaraan = TipeKendaraan;
            this.Transmisi = Transmisi;
            this.NomorPolisi = NomorPolisi;

        }

    }

    class Motor : Kendaraan
    {
        //data field. 
             //empty

        //default constructor. 
                //artinya parameternya kosong.
        public  Motor()  
        {
            // this itu keyword. kata kunci yang langsung tertuju utk ke objek. 

            this.NamaPengendara = NamaPengendara;
            this.JumlahRoda = 2;
            this.Umur = Umur;
            this.MerkKendaraan = MerkKendaraan;
            this.TipeKendaraan = TipeKendaraan;
            this.Transmisi = Transmisi; 
            this.NomorPolisi = NomorPolisi;
        }

    }
}
