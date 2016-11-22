namespace _3.CompareCharArrays
{
    using System;

    public class CompareCharArrays
    {
        public static void Main()
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            char[] array1 = str1.ToCharArray();
            char[] array2 = str2.ToCharArray();

            int n = Math.Min(array1.Length, array2.Length);
            string result = "=";

            for (int i = 0; i < n; i++)
            {
                if (array1[i] > array2[i])
                {
                    result = ">";
                    break;
                }

                if (array1[i] < array2[i])
                {
                    result = "<";
                    break;
                }
            }

            if (result == "=")
            {
                if (array1.Length > array2.Length)
                {
                    result = ">";
                }
                else if (array1.Length < array2.Length)
                {
                    result = "<";
                }
            }

            Console.WriteLine(result);
        }
    }
}
