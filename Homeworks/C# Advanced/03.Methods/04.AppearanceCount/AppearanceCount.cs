using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.AppearanceCount
{
    class AppearanceCount
    {
        static int RepeatingNumber(int[] array, int num)
        {
            int counter = 0;
            foreach (var number in array)
            {
                if (number == num)
                {
                    counter++;
                }
            }
            return counter;
        }
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int x = int.Parse(Console.ReadLine());


            Console.WriteLine(RepeatingNumber(array, x));
        }
    }
}
