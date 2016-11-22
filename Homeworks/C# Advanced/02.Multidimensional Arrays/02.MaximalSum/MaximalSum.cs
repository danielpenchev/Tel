using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MaximalSum
{
    class MaximalSum
    {
        static void Main()
        {
            int[] nm = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = nm[0];
            int cols = nm[1];
            var matrix = new int[rows, cols];
            int currentSum = 0;
            int maxSum = int.MinValue;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] arrayLine = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int col = 0; col < arrayLine.Length; col++)
                {
                    matrix[row, col] = arrayLine[col];
                }
            }

            for (int row = 0; row < rows - 2; row++)
            {
                for (int col = 0; col < cols - 2; col++)
                {
                    currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                        matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                        matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        currentSum = 0;
                    }
                }
            }
            Console.WriteLine(maxSum);
        }
    }
}

