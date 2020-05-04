using System;

namespace BranchNLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========== if/else Syntax ==========");
            int a = 5;
            int b = 3;
            int c = 4;
            if ((a + b + c > 10) && (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not equal to the second");
            }

            Console.WriteLine("========== while Loop Syntax ==========");
            int counter = 0;
            while(counter < 10)
            {
                Console.Write($"{counter} ");
                counter++;
            }
            Console.WriteLine("\n========== do while loop Syntax ==========");
            counter = 0;
            do
            {
                Console.Write($"{counter} ");
                counter++;
            }while(counter < 10);
            Console.WriteLine("\n========== for Loop Syntax ==========");
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Hello World! The counter is {i}");
            }
            Console.WriteLine("====== Combining Branches & Loops ======");
            // find the sum of all integers 1 through 20 that are divisible by 3
            int sum = 0;
            for(int i = 1; i <= 20; i++){
                if (i % 3 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine($"the sum of all integers 1 through 20 that are divisible by 3 is: {sum}");
        }
    }
}
