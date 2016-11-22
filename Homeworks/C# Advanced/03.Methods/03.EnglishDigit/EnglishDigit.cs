using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EnglishDigit
{
    class EnglishDigit
    {
        static string Digit(int number)
        {
            string[] words = {"zero","one","two","three","four",
                            "five","six","seven","eight","nine"};
            int lastDigit = number % 10;
            string lastDigitAsWord = words[lastDigit];

            return lastDigitAsWord;
        }

        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(Digit(num));
        }
    }
}
