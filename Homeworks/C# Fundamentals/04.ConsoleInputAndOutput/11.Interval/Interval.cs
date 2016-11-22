using System;

class Interval
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int numbers = 0;
        for (int i = n + 1; i < m; i++)
        {
            if(i % 5 == 0)
            {
                numbers ++;
            }
        }
        Console.WriteLine(numbers);
    }
}
