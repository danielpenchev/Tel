namespace FrequentNumber
{
    using System;

    public class FrequentNumber
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var array = new int[n];

            int element = 0;
            int currentCount = 1;
            int maxCount = 1;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(array);

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    currentCount++;
                }
                else
                {
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                        element = array[i];
                        currentCount = 1;
                    }
                    else
                    {
                        currentCount = 1;
                    }
                }
            }

            if (currentCount > maxCount)
            {
                maxCount = currentCount;
                element = array[array.Length - 1];
            }

            Console.WriteLine("{0} ({1} times)", element, maxCount);
        }
    }
}
