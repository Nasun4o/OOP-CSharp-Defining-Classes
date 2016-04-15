using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopShop
{
    class Program
    {
        static void Main()
        {
            Laptop poorLaptop = new Laptop("shiban", 10);
            Battery poorBatery = new Battery("Li-on", 5.4);
            Laptop goodLaptop = new Laptop("Accer",new Battery("Li-lon", 4.5), "Nai dobrata firma", "Intel i5 3200+", "8GB", "nVidia", "128GB SSD", "62 full HD", 15123);


            //(string model, Battery battery, string manufacturer, string processor,
            //string ram, string graphicsCard, string hdd, string screen, decimal price)  :this(model, price)

           
            Console.WriteLine(goodLaptop.ToString());

        }
    }
}
