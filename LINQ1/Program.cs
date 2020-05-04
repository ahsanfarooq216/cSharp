using System.Linq;
using static System.Console;

namespace LINQ1
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "the quick brown fox jumps over the lazy dog";
            var wordlength = from word in phrase.Split(" ") where (word.Length > 3) select word.Length;
            //var average = wordlength.Average();
            WriteLine($"The average word length is {wordlength.Average():F3}");
            //extra:
            foreach (int i in wordlength)
            {
                Write(i + " ");
            }
        }
    }
}
