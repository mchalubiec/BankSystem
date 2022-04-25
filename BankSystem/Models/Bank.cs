using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystem.Models
{
    public class Bank
    {
        public string Name { get; set; }
        public string Currency { get; set; }
        public List<User> users { get; set; }
        public List<Account> accounts { get; set; }
    }
}
