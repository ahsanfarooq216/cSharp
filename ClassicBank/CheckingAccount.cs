using System;
using System.Collections.Generic;
using System.Text;

namespace ClassicBank
{
    public class CheckingAccount
    {
        private string AcNum;
        private string Title;
        private DateTime OpeningDate;

        private decimal Balance;

        private static int AcNumSeed = 1928374650;
        private List<Transaction> allTransactions = new List<Transaction>();

        public CheckingAccount(string title, DateTime date)
        {
            this.AcNum = AcNumSeed.ToString();
            AcNumSeed++;
            this.Title = title;
            this.Balance = 0;
            this.OpeningDate = date;
        }

        public void MakeDeposit(decimal amount, DateTime date, string notes)
        {
            var deposit = new Transaction(amount, date, notes);
            allTransactions.Add(deposit);
            Balance += amount;
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string notes)
        {
            var withdrawal = new Transaction(amount, date, notes);
            allTransactions.Add(withdrawal);
            Balance -= amount;
        }

        public decimal getBalance()
        {
            return this.Balance;
        }

        public string AcStatement(){
            var report = new StringBuilder();
            decimal balance = 0;
            report.AppendLine("Date\t\tDescription\t\tAmount\t\tBalance");
            report.AppendLine($"{OpeningDate.ToShortDateString()}\tOpening Balance\t\t0.00\t\t0.00");
            foreach (var i in allTransactions)
            {
                balance += i.GetAmount();
                report.AppendLine($"{i.Date.ToShortDateString()}\t{i.Notes}\t\t\t{i.GetAmount().ToString()}\t\t{balance}");
            }
            return report.ToString();
        }
    }
}