using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystem.Models
{
    public class Generator
    {
        public string GenerateNumber(int length)
        {
            int[] digits = new int[length -1];
            for (int i = 0; i < length; i++)
            {
                digits[i] += new Random().Next(10);
            }
            return digits.ToString();
        }
        public string GenerateCheckDigit()
        {
            string[] generatedNumber = (Bank.BankIdentification + GenerateNumber(2)).Split();
            int[] weights = { 3, 9, 7, 1, 3, 9, 7 };
            int sum = 0;
            for (int i = 0; i < generatedNumber.Length - 1; i++)
            {
                sum += weights[i] * int.Parse(generatedNumber[i]);
            }
            int modulo = sum % 10;
            if (modulo > 0)
            {
                modulo = 10 - modulo;
            }
            return modulo.ToString();
        }
        public string GenerateBankIdentificator(int modulo)
        {
            string bankIdentificator = "";
            return bankIdentificator;
        }
    }
}
