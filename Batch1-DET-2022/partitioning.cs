//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Batch1_DET_2022
//{
//    internal class partitioning
//    {
//        private static void Main()
//        {

//            //skip
//            //string[] words = { "apple", "banana", "mango", "pineapple", "watermelon", "orange" };

//            //var result = words.Skip(2);

//            //Console.WriteLine("Skips the first 2 words:");
//            //foreach (string word in result)
//            //    Console.WriteLine(word);



//            //skipwhile

//            //string[] words = { "apple", "banana", "mango", "pineapple", "watermelon", "orange" };

//            //var result = words.SkipWhile(w => w.Length == 5);

//            //Console.WriteLine("Skips words while the condition is met:");
//            //foreach (string word in result)
//            //    Console.WriteLine(word);


//            //take 

//            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//            //var result = numbers.Take(6);

//            //Console.WriteLine("Takes the first 6 numbers only:");
//            //foreach (int number in result)
//            //    Console.WriteLine(number);


//            //take while
//            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//            var result = numbers.TakeWhile(n => n < 5);

//            Console.WriteLine("Takes numbers one by one, and stops when condition is no longer met:");
//            foreach (int number in result)
//                Console.WriteLine(number);

//        }
//    }
//    }

