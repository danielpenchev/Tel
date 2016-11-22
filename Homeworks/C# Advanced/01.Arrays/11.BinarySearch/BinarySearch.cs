namespace _11.BinarySearch
{
    using System;

    public class BinarySearch
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int x = int.Parse(Console.ReadLine());

            int high = array.Length - 1;
            int low = array[0];
            int mid;
            int result = -1;
            
            if (array[0] == x)
            {
                result = low;
            }
            else if (array[high] == x)
            {
                result = high;
            }
            else
            {
                while (low <= high)
                {
                    mid = (high + low) / 2;
                    if (array[mid] == x)
                    {
                        result = mid;
                        break;
                    }
                    else
                    {
                        if (array[mid] > x)
                        {
                            high = mid - 1;
                        }
                        else
                        {
                            low = mid + 1;
                        }
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
