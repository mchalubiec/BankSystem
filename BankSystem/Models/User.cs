using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystem.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public bool IsLogged { get; set; }
        public List<Account> Accounts { get; set; }
        public List<Card> Cards { get; set; }
    }
}
