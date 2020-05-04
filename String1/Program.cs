using System;

namespace String1
{
    class Program
    {
        static void Main(string[] args)
        {
            string aFriend = "Bill";
            Console.WriteLine("Hello " + aFriend);

            aFriend = "Maira";
            Console.WriteLine("Hello " + aFriend);

            string friend1 = "Topamato";
            string friend2 = "Pomato";
            Console.WriteLine($"Hello {friend2} and {friend1}");

            Console.WriteLine($"The name {friend1} has {friend1.Length} letters");
            Console.WriteLine($"The name {friend2} has {friend2.Length} letters");

            string greeting = "       Hello World!      ";
            Console.WriteLine($"[{greeting}]");

            Console.WriteLine($"[{greeting.TrimStart()}]");
            Console.WriteLine($"[{greeting.TrimEnd()}]");
            Console.WriteLine($"[{greeting.Trim()}]");
            Console.WriteLine("==============1=============");
            string sayHello = "Hello World!";
            Console.WriteLine(sayHello);
            Console.WriteLine(sayHello.Replace("Hello", "Greetings"));
            Console.WriteLine(sayHello.ToUpper());
            Console.WriteLine(sayHello.ToLower());
            Console.WriteLine("==============2=============");
            string songLyrics = "You are a piece of meat, I wish I didn't eat";
            Console.WriteLine(songLyrics.Contains("meat"));
            Console.WriteLine(songLyrics.Contains("apple"));
            Console.WriteLine("==============3=============");
            Console.WriteLine(songLyrics.StartsWith("You"));
            Console.WriteLine(songLyrics.StartsWith("I"));
            Console.WriteLine(songLyrics.EndsWith("eat"));
            Console.WriteLine(songLyrics.EndsWith("drink"));
        }
    }
}
