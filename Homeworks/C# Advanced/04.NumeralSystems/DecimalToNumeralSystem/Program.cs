using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToNumeralSystem
{
    class Program
    {
        static string DecimalToBase(long decimalNumber, int numeralSystem)
        {
            string result = string.Empty;

            while (decimalNumber != 0)
            {
                long digit = decimalNumber % numeralSystem;
                if(digit >= '0' && digit <= '9')
                {
                    result = (char)(digit + '0') + result;
                }
                else // A-Z
                {
                    result = (char)(digit - 10 + 'A') + result;
                }
                decimalNumber /= numeralSystem;
            }

            return result;
        }

        static void Main()
        {

        }
    }
}
