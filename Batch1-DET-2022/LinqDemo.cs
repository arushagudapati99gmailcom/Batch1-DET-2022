//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Batch1_DET_2022
//{
//    internal class LinqDemo
//    {
//        private static void SampleIntList()
//        {
//            //the three parts of a LinQ Query: deffered execution
//            //1. data source
//            List<int> numbers = new List<int>();
//            numbers.Add(110);
//            numbers.Add(100);
//            numbers.Add(105);
//            numbers.Add(102);

//            //2. query creation.sql type
//            var numQuery = from num in numbers //select num from numbers
//                           select num;

//            //3. Query execution
//            foreach (int num in numQuery)
//            {
//                Console.Write("{0}", num);
//                //num.dump(); // this is for Linqpad not for vs
//            }
//            Console.ReadLine();
//        }
//    }
//}
