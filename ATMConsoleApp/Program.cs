using BankSystem.Models;
using System;
using System.Collections.Generic;

namespace ATMConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BankUser> bankUsers = new List<BankUser>();
            BankUser bankUser = new BankUser();
            bankUser.AddUserToBank(bankUsers, bankUser);
            bankUser.AddUserToBank(bankUsers, bankUser);
            foreach (var item in bankUsers)
            {
                Console.WriteLine($"Name:\t{item.FirstName}");
                Console.WriteLine($"Email:\t{item.Email}");
            }

            Console.ReadLine();
        }
    }
}
