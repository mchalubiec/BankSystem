using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystem
{
    public static class Utility
    {
        public static string GetUserInput(string requestContent)
        {
            Console.Write($"Enter {requestContent}");
            return Console.ReadLine();
        }
    }
}
