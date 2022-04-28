using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystem.Models
{
    public class BankUser
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public bool IsLogged { get; set; }
        public List<BankAccount> Accounts { get; set; }
        public List<Card> Cards { get; set; }
        public Card CreateCard(BankAccount account, BankUser user)
        {
            var card = new Card();
            card.CardProvider = card.SetCardProvider(userInput);
            card.CardNumber = card.GenerateCardNumber();
            card.CardPin = card.SetCardPin(userInput);
            card.CardExpirationDate = card.SetCardExpirationDate();
            card.Account = account;
            card.User = user;
            return card;
        }
        public BankAccount CreateAccount(BankUser user)
        {
            var account = new BankAccount();
            account.AccountType = account.SetAccountType(userInput);
            account.AccountNumber = account.GenerateAccountNumber();
            account.AccountBalance = 0.0m;
            account.AccountCreatedOn = account.SetAccountCreatedOn();
            account.User = this.User;
            return account;
        }
    }
}
