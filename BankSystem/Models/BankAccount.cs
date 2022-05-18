using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystem.Models
{
    public enum AccountTypes { CHECKING, SAVINGS }
    public class BankAccount
    {
        public const int AccountNumberLength = 16;
        public AccountTypes AccountType { get; set; }
        public string AccountNumber { get; set; }
        public decimal AccountBalance { get; set; }
        public DateTime AccountCreatedOn { get; set; }
        public List<Transaction> Transactions { get; set; }
        public BankUser User { get; set; }
        public BankAccount() { }
        public BankAccount(BankUser user)
        {
            AccountNumber = GenerateAccountNumber(AccountNumberLength);
            AccountBalance = 0.0m;
            AccountCreatedOn = SetAccountCreatedOn();
        }
        public AccountTypes SetAccountType(int userInput)
        {
            switch (userInput)
            {
                case 1:
                    AccountType = AccountTypes.CHECKING;
                    break;
                case 2:
                    AccountType = AccountTypes.SAVINGS;
                    break;
            }
            return AccountType;
        }
        public string GenerateAccountNumber(int accountNumberLength)
        {            
            return new Generator().GenerateNumber(accountNumberLength).ToString();
        }
        public DateTime SetAccountCreatedOn()
        {
            return DateTime.Now;
        }
        public Card CreateCard(int userSelection, int userPin)
        {
            var card = new Card();
            card.CardProvider = card.SetCardProvider(userSelection);
            card.CardNumber = card.GenerateCardNumber();
            card.CardPin = card.SetCardPin(userPin);
            card.CardExpirationDate = card.SetCardExpirationDate();
            card.Account = this;
            card.User = User;
            return card;
        }
    }
}
