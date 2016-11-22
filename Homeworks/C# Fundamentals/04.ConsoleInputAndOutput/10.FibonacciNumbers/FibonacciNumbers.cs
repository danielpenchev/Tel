using System;
using System.Numerics;

public class FibonacciSequence
{
    public static void Main()
    {
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        BigInteger first = 0, second = 1, next = 1;
        string sequence = "";

        sequence += first.ToString() + ", " + second.ToString();

        if (n >= 1 && n <= 50)
        {
            if (n < 2)
            {
                sequence = first.ToString();
            }

            for (int i = 2; i < n; i++)
            {
                next = first + second;
                first = second;
                second = next;
                sequence += ", " + second;
            }

            Console.WriteLine(sequence);
        }
    }
}
