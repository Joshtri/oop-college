using System;

    public class KelasDasar
    {
        //datafield tipe akses private. 
        private int Bilangan; 
        
        public KelasDasar()
        {
            Console.WriteLine("KelasDasar.KelasDasar()"); 
        }

        //konstruktor dengan satu parameter. 
        public KelasDasar(int i )
        {
            Bilangan = i ;  
            Console.WriteLine("KelasDasar.KelasDasar(int i)");
        }

        public int GetBilangan()
        {
            return Bilangan; 
        }
        
    }
