using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.PrimeNumberCheck
{
    class PrimeNumberCheck
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int divider = 2;
            int maxDivider = (int)Math.Sqrt(number);
            bool isPrime = true;
            if (number <= 1)
            {
                isPrime = false;
            }
            else
            {
                while (divider <= maxDivider)
                {
                    if (number % divider == 0)
                    {
                        isPrime = false;
                    }
                    divider++;
                }
            }
            if (isPrime)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");

            }
        }
    }
}
