using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Program
    {
        static void Main()
        {
            Person ivan = new Person("Atanas", 23, "arst@abv.bg");

            ivan.ToString();
            ivan.ShowInfo();

        }
    }
}
