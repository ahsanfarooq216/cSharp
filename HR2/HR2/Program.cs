using System;

namespace HR2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            /*deleted code:
                Instantiates Employee Object with name Libby and salary 2000 called employee1
                Employee emp1 = new Employee("Libby", 2000); 
            */
            // Instantiates TechnicalEmployee Object with name Libby called employee1
            var emp1 = new TechnicalEmployee("Libby");
            // Instantiates TechnicalEmployee Object with name Zaynah called employee2
            TechnicalEmployee emp2 = new TechnicalEmployee("Zaynah");
            // Instantiates BusinessEmployee Object with name Winter called employee3
            BusinessEmployee emp3 = new BusinessEmployee("Winter");

            // Output to the console window
            Console.WriteLine(emp1.employeeStatus() + "..." + emp2.employeeStatus() + "..." + emp3.employeeStatus());
        }
    }
}
