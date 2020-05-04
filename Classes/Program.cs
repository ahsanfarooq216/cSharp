using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var akount1 = new BankAccount("Ahsan", 10000);
            Console.WriteLine($"Account {akount1.Number} was created for {akount1.Owner} with {akount1.Balance}");
            akount1.MakeWithdrawal(1230, DateTime.Now, "Rent Payment");
            Console.WriteLine(akount1.Balance);
            akount1.MakeDeposit(3430, DateTime.Now, "Paycheck #21");
            Console.WriteLine(akount1.Balance);
            Console.WriteLine(akount1.GetAccountHistory());
            //SomeTests();
        }

        public static void SomeTests()
        {
            // Test that the initial balances must be positive.
            try
            {
                var invalidAkount1 = new BankAccount("Bill", -55);
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Cannot make an account with negative balance");
                Console.WriteLine(e);
            }
            // Test for a negative balance.
            try
            {
                var testAccount1 = new BankAccount("person1", 1000);
                testAccount1.MakeWithdrawal(1222333, DateTime.Now, "Ateempt to overdraw");
            }
            catch(InvalidOperationException e)
            {
                Console.WriteLine("Exception caught trying to overdraw");
                Console.WriteLine(e);
            }
        }
    }
}


