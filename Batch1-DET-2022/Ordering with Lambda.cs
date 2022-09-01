using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class Ordering_with_Lambda
    {
        private static void Main()


        {

            //int[] numbers = { 9, 10, 12};

            //    var result = numbers.OrderBy(n => n);

            //    Console.WriteLine("Ordered list of numbers:");
            //    foreach (int number in result)
            //        Console.WriteLine(number);




            //descending

            //string[] names = { "aru", "neethu", "aishu", "bhanu" };

            //var result = names.OrderByDescending(n => n);

            //Console.WriteLine("Descending ordered list of names:");
            //foreach (string name in result)
            //    Console.WriteLine(name);



            //reverse

            //char[] characters = { 's', 'a', 'v', 'p', 'p', 'r' };

            //var result = characters.Reverse();

            //Console.WriteLine("Characters in reverse order:");
            //foreach (char character in result)
            //    Console.WriteLine(character);


            //thenby

            //string[] capitals = { "cannada", "Paris", "Aus", "Tokyo", "London",
            //              "Athens", "Beijing", "Seoul" };

            //var result = capitals.OrderBy(c => c.Length).ThenBy(c => c);

            //Console.WriteLine("Ordered list of capitals, first by length and then alphabetical:");
            //foreach (string capital in result)
            //    Console.WriteLine(capital);

            //then bydescending


            var dates = new DateTime[] {
        new DateTime(2017, 4, 1),
        new DateTime(2019, 8, 1),
        new DateTime(2014, 8, 1),
        new DateTime(2018, 6, 1),
        new DateTime(2018, 5, 1)
    };

            var result = dates.OrderByDescending(d => d.Year).ThenByDescending(d => d.Month);

            Console.WriteLine("List of dates first ordered by year descending, and then by month descending:");
            foreach (DateTime dt in result)
                Console.WriteLine(dt.ToString("yyyy/MM/dd"));
        }



    }
}
