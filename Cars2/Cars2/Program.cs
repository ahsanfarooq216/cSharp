using System;

namespace Cars2
{
    class Program
    {
        static void Main(string[] args)
        {
            var Car1 = new Car();
            Car1.Color = "White";
            Car1.Year = 2010;
            Car1.Mileage = 11838;
            Console.WriteLine($"{Car1.Color}\t{Car1.Year}\t{Car1.Mileage}");
            Console.WriteLine($"There are {Car.CountCars()} in the inventory now"); // Access static members

            var Car2 = new Car("Red", 2012);
            Console.WriteLine($"{Car2.Color}\t{Car2.Year}\t{Car2.Mileage}");
            Console.WriteLine($"There are {Car.CountCars()} in the inventory now");
        }
    }
}
