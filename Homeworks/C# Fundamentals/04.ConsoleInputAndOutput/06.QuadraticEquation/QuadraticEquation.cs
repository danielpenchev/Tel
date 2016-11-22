using System;

class QuadraticEquation
{
    static void Main()
    {
        double a, b, c, D, x1, x2;

        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());
        c = double.Parse(Console.ReadLine());

        D = b * b - (4 * a * c);
        if (0 > D)
        {
            Console.WriteLine("no real roots");
        }
        else if (D == 0)
        {
            x1 = -b / (2 * a);
            Console.WriteLine("{0:f2}", x1);
        }
        else
        {
            x1 = (-b + Math.Sqrt(D)) / (2 * a);
            x2 = (-b - Math.Sqrt(D)) / (2 * a);

            double minX = Math.Min(x1, x2);
            double maxX = Math.Max(x1, x2);

            Console.WriteLine("{0:f2}", minX);
            Console.WriteLine("{0:f2}", maxX);
        }
    }
}
