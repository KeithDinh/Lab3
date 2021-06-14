using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    class Transaction
    {
        public Transaction(DateTime d, string des, decimal amount)
        {
            this.Date = d;
            this.Description = des;
            this.Amount = amount;
            this.Category = (amount >= 0) ? "Income" : "Expense";
        }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public decimal Amount { get; set; }
    }
}
