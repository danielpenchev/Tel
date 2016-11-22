using IEnumerableExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExtension
{
    public static class IEnumRun
    {
        public static void Testing()
        {
            IEnumerable<int> array = new int[] { -100, -5, 1, 8, 2, 3, 3, 4, 5, 6, 6, 4, 3, 199 };

            Console.WriteLine("Sum: {0}", array.SumExtension<int>());
            Console.WriteLine("Max: {0}", array.MaxExtension<int>());
            Console.WriteLine("Min: {0}", array.MinExtension<int>());
            Console.WriteLine("Average: {0}", array.AverageExtension<int>());
        }
    }
}
