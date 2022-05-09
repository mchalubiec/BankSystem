using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystem.Models
{
    public enum CardProviders { VISA = 4, Mastercard = 5 };
    public class Card
    {
        public CardProviders CardProvider { get; set; }
        public string CardNumber { get; set; }
        public int CardPin { get; set; }
        public DateTime CardExpirationDate { get; set; }
        public bool IsBlocked { get; set; } = false;
        public int TotalLoginFailed { get; set; }
        public BankUser User { get; set; }
        public BankAccount Account { get; set; }
        public Card() { }
        public Card(CardProviders cardProvider, string cardNumber, int cardPin, DateTime cardExpirationDate, BankUser user, BankAccount account, bool isblocked)
        {
            CardProvider = cardProvider;
            CardNumber = cardNumber;
            CardPin = cardPin;
            CardExpirationDate = cardExpirationDate;
            IsBlocked = isblocked;
            User = user;
            Account = account;
        }
        public CardProviders SetCardProvider(int userSelection)
        {
            return CardProvider == (CardProviders)userSelection ? CardProviders.Mastercard : CardProviders.VISA;
            //switch (userChoice)
            //{
            //    case 1:
            //        CardProvider = CardProviders.VISA;
            //        break;
            //    case 2:
            //        CardProvider = CardProviders.Mastercard;
            //        break;
            //}
            //return CardProvider;
        }
        public DateTime SetCardExpirationDate()
        {
            return DateTime.Now.AddMonths(24);
        }
        public string GenerateCardNumber()
        {
            string generatedCardNumber = "";
            // 16 cyfr
            // 1 - cardprovider 4- visa, 5 mastercard
            // 2-6 - BIN (Bank Identification Number)
            // 7-15 - zawiera główny numer konta lub numer PAN (Permanent Account Number)
            // 16 - cyfra kontrolna Algorytm Luhna
            return generatedCardNumber;
        }
        public int SetCardPin(int userPin)
        {
            // jakis komentarz
            return userPin;

        }
    }
}
