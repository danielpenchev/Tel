using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ReverseNumber
{
    class ReverseNumber
    {
        static string ReversedNumber(string number)
        {
            string rev = string.Empty;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                rev += number[i];
            }
            return rev;
        }

        static void Main()
        {
            string decNumber = Console.ReadLine();

            Console.WriteLine(ReversedNumber(decNumber));
        }
    }
}
