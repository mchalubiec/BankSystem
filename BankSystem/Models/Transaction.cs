using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystem.Models
{
    public enum TransactionTypes { DEPOSIT = 1, WITHDRAWAL = 2, TRANSFER = 3 }
    public class Transaction
    {
        public DateTime TransactionDate { get; set; }
        public TransactionTypes TransactionType { get; set; }
        public Account Sender { get; set; }
        public Account Receiver { get; set; }
        public decimal TransactionAmount { get; set; }
    }
}
