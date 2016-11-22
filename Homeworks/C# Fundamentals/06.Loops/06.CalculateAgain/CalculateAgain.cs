using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class CalculateAgain
{
    static void Main()
    {
        //N! / K!

        ulong n = ulong.Parse(Console.ReadLine());
        ulong k = ulong.Parse(Console.ReadLine());

        BigInteger sum = 1;
        for (ulong i = n; i > k; i--)
        {
            sum = sum * i;
        }
        Console.WriteLine(sum);
    }
}

