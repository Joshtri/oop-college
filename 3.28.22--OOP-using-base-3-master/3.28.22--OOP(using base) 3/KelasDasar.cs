using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._28._22__OOP_using_base__3
{
    internal class KelasDasar
    {
        //data field. 
        protected int Bilangan; 

        public KelasDasar( int i)
        {
            Bilangan = i; 
        }
    }
    class KelasTurunan : KelasDasar
    {
        protected new int Bilangan; 

        public KelasTurunan(int i , int i2) : base(i)
        {
            Bilangan = i2; 
        }

        public void CetakData()
        {
            Console.WriteLine("Kelasdasar.bilangan \t {0}\n\n", base.Bilangan);
            Console.WriteLine("kelasturunan.bilangan \t {0}", Bilangan);

        }


    }
    
}
