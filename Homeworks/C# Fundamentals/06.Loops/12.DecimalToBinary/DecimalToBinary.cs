using System;

class DecimalToBin
{
    static void Main(string[] args)
    {
        long number = long.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(number, 2));
    }
}