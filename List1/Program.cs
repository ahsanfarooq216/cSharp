using System;
using System.Collections.Generic;

namespace List1
{
    class Program
    {
        public static void WorkingWithLists()
        {
            var names = new List<string> { "Ahsan", "aNA", "pHeLiPe"}; //new list
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            //Add and remove
            Console.WriteLine();
            names.Add("Bill");
            names.Add("Maria");
            names.Remove("aNA");

            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name}");
            }

            Console.WriteLine($"My name is {names[0]}");
            Console.WriteLine($"I've added {names[2]} and {names[3]} to the list");
            //Length of list
            Console.WriteLine($"The list has {names.Count} names in it");
            //Searching
            Console.WriteLine($"the name \"Bill\" is at index {names.IndexOf("Bill")}");
            Console.WriteLine(names.IndexOf("biLL"));
            Console.WriteLine(names.IndexOf("Not found"));
            Console.WriteLine("===========================");
            //Sorting
            var animals = new List<string> {"zebra", "elephant", "tiger", "giraffe", "lion", "frog", "shark", "kangaroo"};
            foreach (var i in animals)
            {
                Console.Write($"{i}     ");
            }
            Console.WriteLine();
            animals.Sort();
            foreach (var i in animals)
            {
                Console.Write($"{i}     ");
            }

            var nums = new List<int> {99, 0, -43, 67, -13, 2, 4, 8, -100, 555};
            nums.Sort();
            Console.WriteLine();
            foreach (var i in nums)
            {
                Console.Write($"{i} ");
            }
        }

        static void Main(string[] args)
        {
            WorkingWithLists();
            Console.WriteLine("\n=====================Fibonacci=======================");
            Fibonacci();
        }

        public static void Fibonacci()
        {
            var fiboNums = new List<int> {1, 1};
            while (fiboNums.Count < 20)
            {
                int last = fiboNums[fiboNums.Count - 1];
                int secondLast = fiboNums[fiboNums.Count -2];
                fiboNums.Add(last + secondLast);
            }


            foreach (int i in fiboNums)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
