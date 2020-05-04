using System;

namespace NullChecks
{
    class Program
    {
        static void Main(string[] args)
        {
            string s  = null;
            Console.WriteLine(s?.Length);

            char? c = s?[0];
            Console.WriteLine(c.HasValue);

            bool? hasMore = s?.ToCharArray()?.GetEnumerator()?.MoveNext();
            Console.WriteLine(hasMore.HasValue);

            bool hasMore2 = s?.ToCharArray()?.GetEnumerator()?.MoveNext() ?? false;
            Console.WriteLine(hasMore2);
        }
    }
}
