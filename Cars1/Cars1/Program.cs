using System;

namespace Cars1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating an object of Car() Class by using Type Inference called Car1
            var car01 = new Car();

            // Using dot notation to call members on Car1
            car01.Color = "White";
            car01.Year = 2010;
            car01.Mileage = 11838;

            //output to the console window
            Console.WriteLine($"This car is painted {car01.Color}, was built in {car01.Year} and has {car01.Mileage} miles on it.");
        }
    }
}
