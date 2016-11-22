using System;

public class CompareArrays
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var array1 = new int[n];
        for (int i = 0; i < array1.Length; i++)
        {
            array1[i] = int.Parse(Console.ReadLine());
        }

        var array2 = new int[n];
        for (int i = 0; i < array2.Length; i++)
        {
            array2[i] = int.Parse(Console.ReadLine());
        }

        bool equal = true;
        for (int i = 0; i < array1.Length; i++)
        {
            if (array1[i] == array2[i])
            {
                equal = true;
            }
            else
            {
                equal = false;
                break;
            }
        }

        if (equal)
        {
            Console.WriteLine("Equal");
        }
        else
        {
            Console.WriteLine("Not equal");
        }
    }
}
