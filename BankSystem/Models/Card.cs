using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystem.Models
{
    public enum CardProviders { VISA = 4, Mastercard = 5 };
    public class Card
    {
        public CardProviders CardProvider { get; set; }
        public long CardNumber { get; set; }
        public int CardPin { get; set; }
        public DateTime CardExpirationDate { get; set; }
        public bool IsBlocked { get; set; } = false;
        public int TotalLoginFailed { get; set; }
        public User User { get; set; }
        public Account Account { get; set; }
        public Card() { }
        public Card(CardProviders cardProvider, long cardNumber, int cardPin, DateTime cardExpirationDate, User user, Account account, bool isblocked)
        {
            CardProvider = cardProvider;
            CardNumber = cardNumber;
            CardPin = cardPin;
            CardExpirationDate = cardExpirationDate;
            IsBlocked = isblocked;
            User = user;
            Account = account;
        }
        public CardProviders SetCardProvider(int userInput)
        {
            switch (userInput)
            {
                case 1:
                    CardProvider = CardProviders.VISA;
                    break;
                case 2:
                    CardProvider = CardProviders.Mastercard;
                    break;
            }
            return CardProvider;
        }
        public DateTime SetCardExpirationDate()
        {
            DateTime dateCreatingCard = DateTime.Now;
            return dateCreatingCard.AddMonths(24);
        }
        public long GenerateCardNumber()
        {
            long generatedCardNumber = 0;
            // 16 cyfr
            // 1 - cardprovider 4- visa, 5 mastercard
            // 2-6 - BIN (Bank Identification Number)
            // 7-15 - zawiera główny numer konta lub numer PAN (Permanent Account Number)
            // 16 - cyfra kontrolna Algorytm Luhna
            return generatedCardNumber;
        }
    }
}
