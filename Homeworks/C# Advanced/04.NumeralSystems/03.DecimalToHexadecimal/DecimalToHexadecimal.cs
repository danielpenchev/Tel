using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.DecimalToHexadecimal
{
    class DecimalToHexadecimal
    {
        static string DecimalToHex(long decNumber)
        {
            string hexadecimal = string.Empty;

            while (decNumber > 0)
            {
                long digit = decNumber % 16; /// 0-9 10-15
                if (digit >= 0 && digit <= 9)
                {
                    hexadecimal = (char)(digit + '0') + hexadecimal;
                }
                else if(digit >= 10 && digit <= 15)
                {
                    hexadecimal = (char)(digit - 10 + 'A') + hexadecimal;
                }
                decNumber /= 16;
            }

            return hexadecimal;
        }

        static void Main()
        {
            long dec = long.Parse(Console.ReadLine());
            Console.WriteLine(DecimalToHex(dec));
        }
    }
}
