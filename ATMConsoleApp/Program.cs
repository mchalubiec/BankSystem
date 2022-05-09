using BankSystem.Models;
using System;

namespace ATMConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank("lol", "PL");
            Console.WriteLine(bank.BankIdentification);
            Console.ReadLine();
        }
    }
}
