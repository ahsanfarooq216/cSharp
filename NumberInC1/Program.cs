using System;

namespace NumberInC1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int a = 18;
            int b = 6;
            int c = a + b;
            Console.WriteLine(c);

            c = a - b;
            Console.WriteLine(c);

            c = a * b;
            Console.WriteLine(c);

            c = a / b;
            Console.WriteLine(c);
            Console.WriteLine("============1============");
            a = 5;
            b = 4;
            c = 2;
            int d = a + b * c;
            Console.WriteLine(d);
            d = (a + b) * c;
            Console.WriteLine(d);
            d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
            Console.WriteLine(d);
            Console.WriteLine("============2============");
            Console.WriteLine(10/3);
            Console.WriteLine(1987%10);
            Console.WriteLine(1987%100);
            Console.WriteLine(1987%1000);
            Console.WriteLine("============3============");
            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers in c# is {min} to {max}");
            Console.WriteLine($"an example of overflow {max + 3}"); //wraparound
            Console.WriteLine($"an example of overflow {min + 2}");
            */
            double a = 19;
            double b = 23;
            double c = 8;
            double d = (a + b) /c;
            Console.WriteLine(d);
            Console.WriteLine("============4============");
            Console.WriteLine($"the range of double is {double.MinValue} to {double.MaxValue}");
            Console.WriteLine(1.0/3);
            Console.WriteLine("============5============");
            decimal min = decimal.MinValue;
            decimal max = decimal.MaxValue;
            Console.WriteLine($"the range of decimal type is {min} to {max}");
            a = 1.0;
            b = 3.0;
            Console.WriteLine(a / b);

            decimal e = 1.0M; //The M suffix on the numbers is how you 
            decimal f = 3.0M; //indicate that a constant should use the decimal type.
            Console.WriteLine(e / f);
            Console.WriteLine("============6============");
            string unit = "cm";
            double radius = 2.5;
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"area of a circle of radius {radius}{unit} is {area} {unit} square");
        }
    }
}
