using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class BankAccount
    {
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance 
        {
            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }
                return balance;
            }
        }
        private static int accountNumberSeed = 1234567890;
        private List<Transaction> allTransactions = new List<Transaction>();

        public BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;
            //this.Balance = initialBalance;
            MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {    
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);        
        }
        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawl must be positive");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
        }

        public string GetAccountHistory()
        {
            var report = new StringBuilder();
            decimal balance = 0;
            report.AppendLine("Date\t\tDescription\t\tAmount\t\tBalance");
            foreach (var i in allTransactions)
            {
                balance += i.Amount;
                report.AppendLine($"{i.Date.ToShortDateString()}\t{i.Notes}\t\t{i.Amount}\t\t{balance}");
            }
            return report.ToString();
        }
    }
}