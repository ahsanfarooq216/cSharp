using System;

namespace AnonClass1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //region makes a collapsable code block
            #region Anon Class 
            var anonObject1 = new { Name = "Judith", Age = 29};
            Console.WriteLine($"{anonObject1.Name} is {anonObject1.Age} years old");
            #endregion
        }
    }
}
