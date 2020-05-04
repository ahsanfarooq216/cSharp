using static System.Console;

namespace AutoProperties
{
    public class Person
    {
        public string FirstName { get; /*private set;*/ }
        public string LastName { get; /*private set;*/ }

        public string MiddleName { get; } = "";

        public Person(string first, string middle, string last)
        {
            FirstName = first;
            MiddleName = middle;
            LastName = last;
        }

        public Person(string first, string last)
        {
            FirstName = first;
            LastName = last;
        }

        public override string ToString()
        {
            return FirstName + " " +  MiddleName + " " + LastName;
        }

        public string AllCaps()
        {
        return ToString().ToUpper();
        }
    }

    public class Program
    {
        public static void Main()
        {
            var p = new Person("Bill", "P.", "Wagner");
            var q = new Person("Faddoo", "Paddoo");
            WriteLine("The name, in all caps: " + p.AllCaps());
            WriteLine("The name: " + p);
            WriteLine("The name, in all caps: " + q.AllCaps());
            WriteLine("The name: " + q);
        }
    }
}
