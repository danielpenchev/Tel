using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.LargerThanNeighbours
{
    class LargerThanNeighbours
    {
        static int CheckNeighbours(int[] array)
        {
            int counter = 0;

            for (int i = 1; i < array.Length - 1; i++)
            {
                if(array[i - 1] < array[i] && array[i + 1] < array[i])
                {
                    counter++;
                }
            }
            return counter;
        }


        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var array = new int[n];
            array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine(CheckNeighbours(array));
        }
    }
}
