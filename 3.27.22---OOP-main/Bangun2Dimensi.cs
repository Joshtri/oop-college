using System;

    internal  class Bangun2Dimensi
    {
       
        
        public double HitungLuas(double p , double l  )
        {
            double luas;
            return luas = p * l ; 
        }

        public  double HitungLuasSegitiga(double a , double t)
        {
            double result ; 
            return result =  1/2 * a * t; 
        }
        public double HitungKeliling(double r)
        {
            double hasil;

            return hasil = Math.PI * r *r;
        }

        
       
        
    }

    class Segiempat : Bangun2Dimensi
    {
        public double Panjang ; 
        public double Lebar ; 
        

    
    }

    class Segitiga : Segiempat
    {
        public double Alas ; 
        public double Tinggi ;

    }

    class Lingkaran : Segiempat
    {
        public double Jari_jari;

    }
