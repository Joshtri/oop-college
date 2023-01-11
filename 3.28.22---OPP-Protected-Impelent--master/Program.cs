using System;
using System.Collections; 
using System.Collections.Generic; 
using System.Diagnostics; 
using System.IO;

namespace _3._28._22___OPP_Protected_Impelent_
{
    class Program
    {
        static void Main(string[] args)
        {

            // membuat objek dari kelas segiempat berwarna. 

            SegiempatBerwarna obj = new SegiempatBerwarna(7,7,"pink");
            
            obj.CetakData();



            /* 
                Kesimpulan : 
                             data panjang dan lebar serta metode hitungluas() dalam kelas segiempat
                             dideklarasikan dengan tipe akses protected. Ini menyebabkan data dan metode tersebut 
                             dapat diakses oleh kelas SegiempatBerwarna, tapi tidak oleh kelas lain ( yang bukan merupakan 
                             kelas turunan dari kelas segiempat)
            */
        }
    }
}
