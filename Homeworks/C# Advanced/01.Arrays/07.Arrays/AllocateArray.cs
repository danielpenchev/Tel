using System;

public class AllocateArray
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var array = new int[n];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i * 5;
            Console.WriteLine(array[i]);
        }
    }
}