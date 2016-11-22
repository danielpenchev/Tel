﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _04.HexadecimalToDecimal
{
    class HexadecimalToDecimal
    {
        static long HexToDecimal(string hex)
        {
            long decimalNumber = 0;

            for (int i = 0; i < hex.Length; i++)
            {
                int digit = 0;
                if(hex[i] >= '0' && hex[i] <= '9')
                {
                    digit = hex[i] - '0';
                }
                else if (hex[i] >= 'A' && hex[i] <= 'F')
                {
                    digit = hex[i] - 'A' + 10;
                }

                decimalNumber += digit * (long)Math.Pow(16, hex.Length - i - 1);
            }

            return decimalNumber;
        }

        static void Main()
        {
            string hexNumber = Console.ReadLine();
            Console.WriteLine(HexToDecimal(hexNumber));
        }
    }
}
