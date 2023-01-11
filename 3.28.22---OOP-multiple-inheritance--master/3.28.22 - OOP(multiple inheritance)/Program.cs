using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._28._22___OOP_multiple_inheritance_
{
    class Program
    {
        static void Main(string[] args)
        {

            Xiaomi obj = new Xiaomi("Xiaomi 11T",2490,13,6,"c");

            var XiaomiPhoneList = new List<Xiaomi>();
            XiaomiPhoneList.Add(obj);
       
            foreach (var item in XiaomiPhoneList)
            {
                Console.WriteLine(" " + item.Camerapixels +" "+item.Ram +" "+item.Resolutions );
            }

            obj.UsbModels();
            obj.GamingTest();
            obj.CameraQuality();
        }
    }
}
