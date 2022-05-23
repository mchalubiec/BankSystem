using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace BankSystem.Models
{
    public class BankUser
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        private string email;

        public string Email
        {
            get { return email; }
            set 
            {
                if (IsValidEmail(value) == true)
                {
                    email = value;
                }
            }
        }
        public List<BankAccount> Accounts { get; set; }
        public List<Card> Cards { get; set; }
        public BankUser CreateBankUser()
        {
            var bankUser = new BankUser();
            bankUser.FirstName = Utility.GetUserInput("name: ");
            bankUser.SecondName = Utility.GetUserInput("surname: ");
            bankUser.Email = Utility.GetUserInput("email: ");
            return bankUser;
        }
        public void AddUserToBank(List<BankUser> bankUsers, BankUser bankUser)
        {
            bankUser = bankUser.CreateBankUser();
            bankUsers.Add(bankUser);
        }
        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return false;
            }
            return Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase);
        }
    }
}
