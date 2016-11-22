using System;

class ComparingFloads
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        a = Math.Round(a, 6);
        b = Math.Round(b, 6);
        double equal = Math.Abs(a - b);
        if (equal < 0.000001)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}