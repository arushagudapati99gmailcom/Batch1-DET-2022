//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

////namespace Batch1_DET_2022
////{
////    internal class String_GroupBy_Linq
////    {
////        public static void Main()
////        {
////            List<String> words = new List<String> { "basket", "blueberry", " chimpanzw", "abacus", "banana", "apple", "chesse" };
////            var wordsGroups = words.GroupBy(x => x[0]).Select
////                (y => new { FirstLetter = y.Key, Words = y });

////            foreach (var item in wordsGroups)
////            {
////                Console.WriteLine(" words that starts with the" +
////                    "letter '{o}':", item.FirstLetter);

////                foreach (var w in item.Words)
////                {
////                    Console.WriteLine(w);
////                }
////            }
////        }
////    }
////}
