using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystem.Models
{
    public class Bank
    {
        public const string BankName = "Narodowy Bank Polski";
        public const string BankIdentification = "1010";
        public const int BankSortCodeLength = 8;
        public const string CountryCode = "PL";

        // 8 cyfr, 4 pierwsze to 3 cyfry oznaczenie banku + 0 zawsze, 4 kolejne cyfry to 3 numer odziału + cyfra kontrolna
        // 1010000, wagi 3 9 7 1 3 9 7 - 3*1+9*0+7*1+1*0+3*0+9*0+7*0=3+0+7+0+0+0+0=10 % 10 = 0
    }
}
