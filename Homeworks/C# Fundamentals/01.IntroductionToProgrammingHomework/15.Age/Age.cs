using System;
namespace AgeAfterTenYears
{
    class AgeAfterTenYears
    {
        static void Main()
        {
            DateTime input = DateTime.Parse(Console.ReadLine());
            TimeSpan difference = DateTime.Now - input;
            int years = (int)(difference.TotalDays / 365);
            Console.WriteLine(years);
            Console.WriteLine(years + 10);
        }
    }
}
