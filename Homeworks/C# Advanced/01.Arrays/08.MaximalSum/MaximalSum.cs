namespace _08.MaximalSum
{
    using System;

    public class MaximalSum
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            var array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int maxSum = 0;

            Array.Sort(array);
            Array.Reverse(array);

            for (int i = 0; i < k; i++)
            {
                maxSum += array[i];
            }

            Console.WriteLine(maxSum);
        }
    }
}
