using System;

namespace DrinksMachine1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            // Instantiating a Class
            DrinksMachine dm1 = new DrinksMachine();
            // Instantiating a Class by Using Type Inference
            var dm2 = new DrinksMachine();
            dm2.Make = "Breville";
            dm2.Model = "Beancrusher 3000";
            dm2.Age = 2;
            Console.WriteLine(dm1.Make);
            Console.WriteLine(dm2.Make);
            Console.WriteLine(dm2.Model);
            Console.WriteLine($"Age of dm2: {dm2.Age}");
            dm2.MakeEspresso();
            var dm3 = new DrinksMachine(6, "kitchen", "Sage", "Barista Express 3800");
            Console.WriteLine($"dm3: the {dm3.Make} {dm3.Model} is {dm3.Age} years old and is in the {dm3.Location}");
        }
    }

    public partial class DrinksMachine
    {
        public int Age { get; set; }
        public void MakeFlatWhite()
        {
            // Method logic goes here.
        }
    }

    public partial class DrinksMachine
    {

        public void MakeLatte()
        {
            // Method logic goes here.
        }
    }
}
