using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FirstLarger
{
    class FirstLarger
    {
        static int FirstIndex(int[] array)
        {
            int index = 0;
            for (int i = 1; i < array.Length - 1; i++)
            {
                if(array[i - 1] < array[i] && array[i + 1] < array[i])
                {
                    index = i;
                    break;
                }
                else
                {
                    index = -1;
                }
            }
            return index;
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var array = new int[n];
            array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine(FirstIndex(array));

        }
    }
}
