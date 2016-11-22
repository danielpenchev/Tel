using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class Calculate3
{
    static void Main()
    {
       int n = int.Parse(Console.ReadLine());
       int k = int.Parse(Console.ReadLine());
       BigInteger factorialN = 1;
       BigInteger factorialK = 1;
       BigInteger factorialDifference = 1;
       for (int i = 1; i <= n; i++)
       {
           factorialN *= i;
       }
       for (int i = 1; i <= k; i++)
       {
           factorialK *= i;
       }
       for (int i = 1; i <= n - k; i++)
       {
           factorialDifference *= i;
       }
       Console.WriteLine("{0}", factorialN / (factorialK * (factorialDifference)));


        //N! / (K! * (N - K)!)

        
        //int n = int.Parse(Console.ReadLine());
        //int k = int.Parse(Console.ReadLine());
        //BigInteger factorialK = 1;
        //BigInteger factorialDiff = n-k;
        //BigInteger factorialN = 1;
        //BigInteger result = 1;
        //for (int i = 1; i < n; i++)
        //{
        //    factorialN *= i;
        //}
        //for (int i = n; i > k * (n-k); i--)
        //{
        //    factorialK *= i;
        //    factorialDiff *= i;
        //    result = factorialN / factorialK * factorialDiff;
        //}
        //Console.WriteLine(result);
    }
}