using System; 

    public class KelasTurunan : KelasDasar
    {
        // konstruktor ini akan memanggil KelasDasar.KelasDasar()

        public KelasTurunan() : base()
        {
            Console.WriteLine("KelasTurunan.KelasTurunan()");
        }

        //konstruktor ini akan memanggil KelasDasar.KelasDasar()

        public KelasTurunan(int j ) : base(j)
        {
            Console.WriteLine("KelasTurunan.KelasTuruna(int i )");
        } 
    }
