using System;
using System.IO;

namespace StreamReadWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Create a text file using the StreamWriter and Write something to the text file
            using (StreamWriter sw = new StreamWriter(@"C:\Users\ahsan\Desktop\Progs\cSharp\StreamReadWrite\StreamReadWrite\Example1.txt"))
            {
                sw.WriteLine("Hello World!\nBonjour le monde");
                sw.WriteLine("Hallo verden");
                sw.WriteLine("Kaixo Mondua");
            } //dispose of the sw for us

            using (StreamReader sr = new StreamReader(@"C:\Users\ahsan\Desktop\Progs\cSharp\StreamReadWrite\StreamReadWrite\Example1.txt"))
            {
                string s;
                do
                {
                    s = sr.ReadLine();
                    Console.WriteLine(s);
                } while (s != null);
            }
            Console.ReadLine();
        }
    }
}
