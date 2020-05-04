using System;

namespace Abstract1HR1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Manager Manga1 = new Manager();
            Manga1.Login(); //Method coming from Manager class not employee
            Manga1.Hire();
        }
    }
}
