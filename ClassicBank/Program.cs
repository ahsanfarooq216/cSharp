using System;

namespace ClassicBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            CheckingAccount ac1 = new CheckingAccount("foobar", DateTime.Now);
            Console.WriteLine(ac1.getBalance());
            ac1.MakeDeposit(7800, DateTime.Now, "salary");
            Console.WriteLine(ac1.getBalance());
            ac1.MakeWithdrawal(1270, DateTime.Now, "rent");
            Console.WriteLine(ac1.getBalance());
            Console.WriteLine(ac1.AcStatement());
        }
    }
}
