using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Testemp
    {
        public static void Main()
        {
            emp e = new emp(22795, "arusha", new DateOnly(2020, 8, 1));
            Console.WriteLine($"years of experience{e.GetYearsofExp()}");
        }
    }
}
