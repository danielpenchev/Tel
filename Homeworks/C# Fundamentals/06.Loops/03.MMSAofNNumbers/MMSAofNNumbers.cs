using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MMSAofNNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<double> numbers = new List<double>();
        if (1 <= n && n <= 1000)
        {
            for (int i = 0; i < n; i++)
            {
                numbers.Add(i);
                numbers[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("min={0:0.00}", numbers.Min());
            Console.WriteLine("max={0:0.00}", numbers.Max());
            Console.WriteLine("sum={0:0.00}", numbers.Sum());
            Console.WriteLine("avg={0:0.00}", numbers.Average());
        }
    }
}
