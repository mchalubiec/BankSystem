using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystem.Models
{
    public enum AccountTypes { CHECKING, SAVINGS }
    public class BankAccount
    {
        public AccountTypes AccountType { get; set; }
        public string AccountNumber { get; set; }
        public decimal AccountBalance { get; set; }
        public DateTime AccountCreatedOn { get; set; }
        public List<Transaction> Transactions { get; set; }
        public BankUser User { get; set; }
        public BankAccount() { }
        public BankAccount(string accountNumber, decimal accountBalance, DateTime createdOn, BankUser user)
        {
            AccountNumber = accountNumber;
            AccountBalance = accountBalance;
            AccountCreatedOn = createdOn;
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
        public string GenerateAccountNumber()
        {
            string generatedAccountNumber = "";
            /* generowanie numeru IBAN
            // 4 - 2(kod kraju)+ 2(cyfra kontrolna) = numer IBAN
            // 8 cyfr – Numer Rozliczeniowy Banku (4 kod banku + 3 kod odziału + 1 liczba kontrolna)
            // ---> generuje ciąg 7 liczb, tworze liczbę kontrolną i doklejam do ciągu (8 znaków)
            */
            // 16 cyfr – numer rachunku klienta
            // PLXX 1020 333X 0000 0000 0000 0001 
            // przesówam 4 pierwsz znaki na koniec, zamieniam litery na dwucyfrowe liczby A=10..Z= 35, dzielę powstałą liczbę prze 97, reszta z jej podzielenia 1 to numer poprawny
            return generatedAccountNumber;
        }
        public DateTime SetAccountCreatedOn()
        {
            return DateTime.Now;
        }
    }
}
