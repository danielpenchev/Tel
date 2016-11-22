using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.SortingArray
{
    class SortingArray
    {
        static void Sorting(int[] array)
        {
            Array.Sort(array);
        }
        
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var array = new int[n];
            array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Sorting(array);

            Console.WriteLine(string.Join(" ", array));
        }
    }
}
