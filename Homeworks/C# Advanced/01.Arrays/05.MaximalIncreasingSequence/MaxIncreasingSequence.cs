namespace _5.MaximalIncreasingSequence
{
    using System;

    public class MaxIncreasingSequence
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var array = new int[n];
            int currentSequence = 1;
            int maxSequence = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] < array[i + 1])
                {
                    currentSequence++;
                }
                else
                {
                    if (currentSequence > maxSequence)
                    {
                        maxSequence = currentSequence;
                    }

                    currentSequence = 1;
                }
            }

            if (currentSequence > maxSequence)
            {
                maxSequence = currentSequence;
            }

            Console.WriteLine(maxSequence);
        }
    }
}
