using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class OddAndEvenProduct
{
    static void Main()
{
        long n = long.Parse(Console.ReadLine());
        string numbers = Console.ReadLine();
        string[] array = numbers.Split(' ');
        long evens = 1;
        long odds = 1;
        if (4 <= n && n <= 50)
        {
            for (int i = 0; i < n; i++)
            {
                long num;
                bool number = long.TryParse(array[i], out num);
                if (number)
                {
                    if (i % 2 == 0)
                    {
                        evens *= num;
                    }
                    else
                    {
                        odds *= num;
                    }
                }
            }
        }
        if(odds == evens)
        {
            Console.WriteLine("yes {0}", evens);
        }
        else
        {
            Console.WriteLine("no {0} {1}", evens, odds);
        }
    }
}
