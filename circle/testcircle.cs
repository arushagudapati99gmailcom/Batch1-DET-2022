using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class testcircle
    {
        public static void Main()
        {
            circle c = new circle(50);
            Console.WriteLine($"area of circle is {c.areaofcircle()}");
        }
    }
}
