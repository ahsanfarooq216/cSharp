using System;

namespace Tuples1
{
    class Program
    {
        static void Main(string[] args)
        {
            var item = (Name: "eggplant", Price: 1.99m, perPackage: 3);
            var date = DateTime.Now;
            Console.WriteLine($"On {date:d}, the price of {item.Name} was {item.Price:c2} per {item.perPackage} items.");
        }
    }
}
