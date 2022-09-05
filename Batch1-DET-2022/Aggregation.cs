//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

////namespace Batch1_DET_2022
////{
////    internal class Aggregation
////    {
////        public static void Main()

////        {

////            //aggregate simple
////            var numbers = new int[] { 1, 2, 3, 4, 5, 6, };
////            var result = numbers.Aggregate((a, b) => a + b);

////            Console.WriteLine("Aggregated numbers by addition:");
////            Console.WriteLine(result);



//            //average

//            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
//            //var result = numbers.Average();
//            //Console.WriteLine("average is");
//            //Console.WriteLine(result);



//            //count

//            //string[] names = { "neethu", "aishu", "bhanu", "aru" };
//            //var result = names.Count();

//            //Console.WriteLine(" names count");
//            //Console.WriteLine(result);



//            //min

//            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//            //var result = numbers.Min();
//            //Console.WriteLine("the min is");
//            //Console.WriteLine(result);

//            //max

//            //int[] numbers = { 1, 2, 3, 4, 5, 6 };
//            //var result = numbers.Max();
//            //Console.WriteLine("the max is");
//            //Console.WriteLine(result);

//            //sum
//            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//            //var result = numbers.Sum();
//            //Console.WriteLine("sum is");
//            //Console.WriteLine(result);






//            //elements
//            //elements at
//            //string[] words = { "One", "Two", "Three" };

//            //var result = words.ElementAt(1);

//            //Console.WriteLine("Element at index 3 in the array is:");
//            //Console.WriteLine(result);



//            //elementatordefault

//            //string[] colors = { "Red", "Green", "Blue" };

//            //var resultIndex1 = colors.ElementAtOrDefault(1);

//            //var resultIndex10 = colors.ElementAtOrDefault(10);

//            //Console.WriteLine("Element at index 1 in the array contains:");
//            //Console.WriteLine(resultIndex1);

//            //Console.WriteLine("Element at index 10 in the array does not exist:");
//            //Console.WriteLine(resultIndex10 == null);


//            //first simple
//            //string[] fruits = { "Banana", "Apple", "Orange" };

//            //var result = fruits.First();

//            //Console.WriteLine("First element in the array is:");
//            //Console.WriteLine(result);


//            //first condition
//            //string[] countries = { "canada", "london", "paries" };

//            //var result = countries.First(c => c.Length == 6);

//            //Console.WriteLine("first element with a length of 6 characters:");
//            //Console.WriteLine(result);

//            //first or default


//            //string[] countries = { "Denmark", "Sweden", "Norway" };
//            //string[] empty = { };

//            //var result = countries.FirstOrDefault();

//            //var resultEmpty = empty.FirstOrDefault();

//            //Console.WriteLine("First element in the countries array contains:");
//            //Console.WriteLine(result);

//            //Console.WriteLine("First element in the empty array does not exist:");
//            //Console.WriteLine(resultEmpty == null);

//            //last
//            //int[] numbers = { 7, 3, 5 };

//            //var result = numbers.Last();

//            //Console.WriteLine("Last number in array is:");
//            //Console.WriteLine(result);


//            //last or default(simple)


//            //string[] words = { "one", "two", "three" };
//            //string[] empty = { };

//            //var result = words.LastOrDefault();

//            //var resultEmpty = empty.LastOrDefault();

//            //Console.WriteLine("Last element in the words array contains:");
//            //Console.WriteLine(result);

//            //Console.WriteLine("Last element in the empty array does not exist:");
//            //Console.WriteLine(resultEmpty == null);


//            //last or default(condition)
//            //string[] words = { "one", "two", "three" };

//            //var result = words.LastOrDefault(w => w.Length == 3);

//            //var resultNoMatch = words.LastOrDefault(w => w.Length == 2);

//            //Console.WriteLine("Last element in the words array having a length of 3:");
//            //Console.WriteLine(result);

//            //Console.WriteLine("Last element in the empty array having a length of 2 does not exist:");
//            //Console.WriteLine(resultNoMatch == null);


//            //single


//            //string[] names1 = { "Peter" };
//            //string[] names3 = { "Peter", "Joe", "Wilma" };
//            //string[] empty = { };

//            //var result1 = names1.Single();

//            //Console.WriteLine("The only name in the array is:");
//            //Console.WriteLine(result1);

//            //try
//            //{
//            //    // This will throw an exception because array contains no elements
//            //    var resultEmpty = empty.Single();
//            //}
//            //catch (Exception e)
//            //{
//            //    Console.WriteLine(e.Message);
//            //}

//            //try
//            //{
//            //    // This will throw an exception as well because array contains more than one element
//            //    var result3 = names3.Single();
//            //}
//            //catch (Exception e)
//            //{
//            //    Console.WriteLine(e.Message);
//            //}


//            //single or default

//            //string[] names1 = { "Peter" };
//            //string[] names3 = { "Peter", "Joe", "Wilma" };
//            //string[] empty = { };

//            //var result1 = names1.SingleOrDefault();

//            //var resultEmpty = empty.SingleOrDefault();

//            //Console.WriteLine("The only name in the array is:");
//            //Console.WriteLine(result1);

//            //Console.WriteLine("As array is empty, SingleOrDefault yields null:");
//            //Console.WriteLine(resultEmpty == null);

//            //try
//            //{
//            //    // This will throw an exception as well because array contains more than one element
//            //    var result3 = names3.SingleOrDefault();
//            //}
//            //catch (Exception e)
//            //{
//            //    Console.WriteLine(e.Message);
//            //}




//            //quantifiers


//            //all
//            //string[] names = { "Bob", "Ned", "Amy", "Bill" };

//            //var result = names.All(n => n.StartsWith("A"));

//            //Console.WriteLine("Does all of the names start with the letter 'A':");
//            //Console.WriteLine(result);


//            //any
//            //string[] names = { "Bob", "Ned", "Amy", "Bill" };

//            //var result = names.Any(n => n.StartsWith("B"));

//            //Console.WriteLine("Does any of the names start with the letter 'B':");
//            //Console.WriteLine(result);


//            ////contains
//            //int[] numbers = { 1, 3, 5, 7, 9 };

//            //var result1 = numbers.Contains(5);

//            //Console.WriteLine("sequence contains the value 5:");
//            //Console.WriteLine(result1);



//            //set
//            //distinct
//            //int[] numbers = { 1, 2, 2, 3, 5, 6, 6, 6, 8, 9 };

//            //var result = numbers.Distinct();

//            //Console.WriteLine("Distinct removes duplicate elements:");
//            //foreach (int number in result)
//            //    Console.WriteLine(number);



//            //except
//            //int[] numbers = { 1, 2, 2, 3, 5, 6, 6, 6, 8, 9 };

//            //var result = numbers.Distinct();

//            //Console.WriteLine("Distinct removes duplicate elements:");
//            //foreach (int number in result)
//            //    Console.WriteLine(number);

//            //intersects
//            //int[] numbers1 = { 1, 2, 3 };
//            //int[] numbers2 = { 3, 4, 5 };

//            //var result = numbers1.Intersect(numbers2);

//            //Console.WriteLine("Intersect creates a single sequence with only the duplicates:");
//            //foreach (int number in result)
//            //    Console.WriteLine(number);


//            //string[] names = { "jhon", "bob", "alex", "bill" ,"jackson"};

//            //var result = from name in names
//            //             where name.Contains("o")
//            //             select name;
//            //foreach (var name in result)

//            //Console.WriteLine(name);






//            //string[] words = { "blueberry", "blackberry", "abacus" };
//            //var result = words.Reverse();
//            //Console.WriteLine("names in reverse order");
//            //foreach (string word in result)
////            //    Console.WriteLine(result);
////        }
////    }
    
////}




