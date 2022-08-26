using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class circle
    {
        int radius;
        public circle(int radius)
        {
            this.radius = radius;
        }
        public double areaofcircle()
        {
            return Math.PI * radius * radius;
        }
    }
}
