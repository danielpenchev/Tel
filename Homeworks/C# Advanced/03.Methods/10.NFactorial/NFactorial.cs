using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _10.NFactorial
{
    class NFactorial
    {
        static BigInteger CalculateFactorial(int number)
        {
            BigInteger fact = 1;
            for (int i = 1; i <= number; i++)
            {
                fact *= i;
            }
            return fact;
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(CalculateFactorial(n));
        }
    }
}
