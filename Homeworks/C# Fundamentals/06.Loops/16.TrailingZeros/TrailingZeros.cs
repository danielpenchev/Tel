using System;

class TrailingZeros
{
    static void Main()
    {
        ulong n = ulong.Parse(Console.ReadLine());
        ulong divider = 5;
        ulong trailingZeros = 0;

        while (divider <= n)
        {
            ulong nDivDivider = n / divider;
            trailingZeros += nDivDivider;
            divider *= 5;
        }
        Console.WriteLine(trailingZeros);
    }
}
