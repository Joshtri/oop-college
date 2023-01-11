using System;

namespace _3._27._22___OOP_Protected_
{
    class Program
    {
        static void Main(string[] args)
        {
            A obj = new A();

            //baris kode dibawah ini akan menyebabkan kesalahan karena a bersifat protected.
            // obj.a = 5 ; // salah. 

            obj.l = 4 ; // tidak error karena access modifier public.

            obj.SetA(5);
            Console.WriteLine("Object 1 ");
            System.Console.WriteLine(obj.GetA());

            B obj2 = new B();

            obj2.SetA(44); 
            obj2.SetB(100);

        


            Console.WriteLine("Object 2 ");
            obj2.PrintData();


        }
    }

    class A {
        
        //mendeklarasikan data protected 
        public int l ; 
        protected int a ;
        // {

        //     get{
        //         return a;
        //     }
        //     set{
        //         this.a = a;
        //     }
        // }



         

        
        public void SetA(int A){
            this.a = A;
        }

        public int GetA(){
            
            return a;
        }

        // ada cara cepat sih ketimbang harus buat method :v
    }
    
    class B : A{

        protected int b ;
        // {
        //     get
        //     {
        //         return b;
        //     }
        //     set
        //     {
        //         this.b = b;
        //     }
        // }
        public void SetB(int B){
        
        checked
        {
            this.b = B;
        }

             
         
        }

        public int GetB(){
            
            return b;
        }

        public void PrintData()
        {
            // mengakses data a dari kelas A. 
            Console.WriteLine(a); 

            //mengakses data milik sendiri. 
            Console.WriteLine(b);
        }

    }

    class C {

    }
}
