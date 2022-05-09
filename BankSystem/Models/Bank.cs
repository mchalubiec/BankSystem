using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystem.Models
{
    public class Bank
    {
        public string BankIdentification { get; set; }
        public string BankName { get; set; }
        public string CountryCode { get; set; }
        // 1010000, wagi 3 9 7 1 3 9 7 - 3*1+9*0+7*1+1*0+3*0+9*0+7*0=3+0+7+0+0+0+0=10 % 10 = 0
        public Bank(string bankName, string countryCode)
        {
            BankIdentification = GenerateRandomNumberEndsCheckDigit(8);
            BankName = bankName;
            CountryCode = countryCode;
        }
        public string GenerateRandomNumberEndsCheckDigit(int length)
        {
            var random = new Random();
            int[] digits = new int[length];
            for (int i = 0; i < length - 1; i++)
            {
                digits[i] += random.Next(10);
            }
            int[] weights = { 3, 9, 7, 1, 3, 9, 7 };
            int sum = 0;
            for (int i = 0; i < length - 1; i++)
            {
                sum += weights[i] * digits[i];
            }
            int modulo = sum % 10;
            if (modulo > 0)
            {
                modulo = 10 - modulo;
            }
            digits[length] = modulo;
            return digits.ToString();
        }
    }
}
