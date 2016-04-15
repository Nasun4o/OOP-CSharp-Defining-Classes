using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcCatalog
{
    class Program
    {
        static void Main()
        {
            var newComp = new Computer("Accer", new List<Components>
            {
             new Components("nVidia", "Lenova", 3200M),
            new Components("i5-4400U", "Intel", 300M),
              new Components("2GB RAM gForce", "nVidia", 500M)
        });

            Console.WriteLine(newComp.ToString());
        }
    }
}

