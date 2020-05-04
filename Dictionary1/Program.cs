using System;
using System.Collections.Generic;

namespace Dictionary1
{
    class Program
    {
        static void Main(string[] args)
        {
            var inventory = new Dictionary<string, int>()
            {
                ["hammer, ball pein"] = 18,
                ["hammer, cross pein"] = 5,
                ["screwdriver, phillips #2"] = 14
            };
            //Controlling the field width
            Console.WriteLine($"Inventory on {DateTime.Now:d}\n");
            Console.WriteLine($"|{"Item", -25}|{"Quantity", 10}|"); // minimum width goes after ","
            foreach(var item in inventory)
            {
                Console.WriteLine($"|{item.Key, -25}|{item.Value, 10}|"); // "-" for left align and vice versa
            }

            Console.WriteLine($"[{DateTime.Now,-20:d}] Hour [{DateTime.Now,-10:HH}] [{1063.342,15:N2}] feet");
        }
    }
}
