using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Adding_polynomials
{
    class AddingPolynomials
    {
        static int[] AddPoly(int[] firstArray, int[] secondArray, int length)
        {
            var result = new int[length];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = firstArray[i] + secondArray[i];
            }
            return result;
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var firstArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var secondArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var result = AddPoly(firstArray, secondArray, n);
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
