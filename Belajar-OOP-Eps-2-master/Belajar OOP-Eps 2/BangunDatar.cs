using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belajar_OOP_Eps_2
{
    abstract internal class BangunDatar
    {
        // data field.
        protected string Warna;
        protected string NamaPembuat;
        protected string Status;
        protected int UmurPembuat;

        // ini pilar abstraksi yang artinya melihat objek dari sebanyak ini lebih sederhana.

        public BangunDatar( string w, string namacreate, string status, int umur)
        {
            Warna = w;
            NamaPembuat = namacreate;
            Status = status;
            UmurPembuat = umur;

        }


        // method abstract.tanpa body => {  }
        public abstract double HitungLuas();
        public abstract double HitungKeliling();

        

        

    }
}
