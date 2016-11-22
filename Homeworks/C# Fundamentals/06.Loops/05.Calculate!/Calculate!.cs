using System;
using System.Numerics;

class CalculateSumsOfFactorials
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());
        long factorial = 1;
        double sum = 1;
        if (2 <= n && n <= 20) 
        {
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                sum += (factorial / Math.Pow(x, i));
            }
        }
        Console.WriteLine("{0:F5}", sum);
    }
}
