using System.Drawing;
using System; 

    public class SegiempatBerwarna : Segiempat
    {
        //data dengan tipe akses private. 
        private string Warna; 

        //konstruktor Segiempat Berwarna. 
        public SegiempatBerwarna(double Width, double Length, string color) : base(Width, Length){

            this.Warna = color;

        }

        public void CetakData(){

            //mengakses data panjang dan lebar.
            Console.WriteLine("panjang : {0} ", Panjang);

            Console.WriteLine("lebar : {0}", Lebar);
            Console.WriteLine("warna : {0}\n\n", Warna);


            Console.WriteLine("Hitungan luas {0}", HitungLuas());
        }
        //.....
    
    }
