using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _08.CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main()
        {
            //   C = (2N)! / ((N + 1)! * N!)

            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger result = 1;
            BigInteger factorialN = 1;
            BigInteger doubleFactorialN = 1;
            BigInteger factorialNPlus = 1;
            if(0 < n && n <= 100)
            {
                for (int i = 1; i <= n; i++)
                {
                    factorialN *= i;
                }
                for (int i = 1; i <= 2 * n; i++)
                {
                    doubleFactorialN *= i;
                }
                for (int i = 1; i <= n + 1; i++)
                {
                    factorialNPlus *= i;
                }
                result = doubleFactorialN / (factorialNPlus * factorialN);
            }
            Console.WriteLine(result);
        }
    }
}
