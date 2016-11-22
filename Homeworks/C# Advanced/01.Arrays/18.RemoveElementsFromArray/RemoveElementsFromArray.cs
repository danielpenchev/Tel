namespace _18.RemoveElementsFromArray
{
    using System;
    using System.Collections.Generic;

    public class RemoveElementsFromArray
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            List<int> newList = new List<int>();
            int maxSequence = 0;

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                newList.Add(1);
            }

            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if ((array[j] <= array[i]) && (newList[i] < newList[j] + 1))
                    {
                        newList[i] = newList[j] + 1;
                        if (maxSequence < newList[i])
                        {
                            maxSequence = newList[i];
                        }
                    }
                }
            }

            Console.WriteLine(n - maxSequence);
        }
    }
}
