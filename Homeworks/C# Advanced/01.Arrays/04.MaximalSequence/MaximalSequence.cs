namespace _4.MaximalSequence
{
    using System;

    public class MaximalSequence
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int count = 1;
            int maxCount = 1;

            var array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            if (1 <= n && n <= 1024)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] == array[i + 1])
                    {
                        count++;
                    }
                    else
                    {
                        count = 1;
                    }

                    if (count > maxCount)
                    {
                        maxCount = count;
                    }
                }
            }

            Console.WriteLine(maxCount);
        }
    }
}
