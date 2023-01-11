using System; 

    public class Segiempat
    {
        // data dengan tipe akses protected.
        protected double Panjang; 
        protected double Lebar; 

        //konstruktor segiempat. 
        public Segiempat(double P, double L ){

            this.Panjang = P; 
            this.Lebar = L;
        }

        //metode dengan tipe akses protected. 
        protected double HitungLuas(){

            return Panjang * Lebar;
        }
        
    }
