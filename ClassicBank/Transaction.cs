using System;

namespace ClassicBank
{
    public class Transaction
    {
        private decimal Amount; //one way
        public DateTime Date { get; } //another way
        public string Notes{ get; } //another way

        public Transaction(decimal amount, DateTime date, string notes)
        {
            this.Amount = amount;
            this.Date = date;
            this.Notes = notes;
        }

        public decimal GetAmount() //one way
        {
            return this.Amount;
        }
    }
}