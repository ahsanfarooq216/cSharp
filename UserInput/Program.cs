using System;
// using System.Linq;
// using System.Collections.Generic;
// using System.Text;
// using System.Threading.Tasks;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            int age;

            Console.Write("What is your name? "); //print to screen and stay on same line
            name = Console.ReadLine(); //scanner
            Console.WriteLine($"You said your name is {name}"); //print to screen and move to next line
            Console.ReadKey(); //waits for 1 key input

            // Console.Write("Type a word: ");
            // int something = Console.Read(); //reads 1st key's ASCII value
            //Console.WriteLine(something);
        
            System.Console.Write("What is your age? ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine($"you saif yoyr age is {age}");
        }
    }
}
