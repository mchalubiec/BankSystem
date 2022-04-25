using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystem.Models
{
    public enum AccountTypes { CHECKING, SAVINGS }
    public class Account
    {
        public static int AccountId { get; set; }
        public AccountTypes AccountType { get; set; }
        public string AccountNumber { get; set; }
        public decimal AccountBalance { get; set; }
        public DateTime AccountCreatedOn { get; set; }
        public List<Transaction> Transactions { get; set; }
        public User User { get; set; }
        public Account(string accountNumber, decimal accountBalance, DateTime createdOn, User user)
        {
            AccountId++;
            AccountNumber = accountNumber;
            AccountBalance = accountBalance;
            AccountCreatedOn = createdOn;

        }
    }
}
