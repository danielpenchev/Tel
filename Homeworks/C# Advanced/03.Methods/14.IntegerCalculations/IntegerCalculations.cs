using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.IntegerCalculations
{
    class IntegerCalculations
    {
        static double MinMethod(List<long> li)
        {
            long min = li.Min();
            return min;
        }

        static double MaxMethod(List<long> li)
        {
            long max = li.Max();
            return max;
        }

        static double AverageMethod(List<long> li)
        {
            double average = SumMethod(li) / 5;
            return average;
        }

        static double SumMethod(List<long> li)
        {
            double sum = li.Sum();
            return sum;
        }

        static long Product(List<long> li)
        {
            long product = 1;
            foreach (var n in li)
            {
                product *= n;
            }
            return product;
        }


        static void Main()
        {
            var numbers = new List<long>();
            numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            Console.WriteLine("{0}", MinMethod(numbers));
            Console.WriteLine("{0}", MaxMethod(numbers));
            Console.WriteLine("{0:F2}", AverageMethod(numbers));
            Console.WriteLine("{0}", SumMethod(numbers));
            Console.WriteLine("{0}", Product(numbers));
        }
    }
}
