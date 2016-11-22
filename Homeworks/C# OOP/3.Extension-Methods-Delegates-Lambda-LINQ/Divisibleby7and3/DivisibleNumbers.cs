namespace Divisibleby7and3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class DivisibleNumbers
    {
        public static void PrintNumbersUsingLambda(int[] array)
        {
            var numbers = array.Where(x => (x % 21) == 0);

            Console.WriteLine("--------------- Using Lambda Expressions ---------------");
            Console.WriteLine("Numbers that are divisible by 7 and 3 at the same time are: ");

            foreach (var element in numbers)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine();
        }

        public static void PrintNumbersUsingLINQ(int[] array)
        {
            var numbers =
                from number in array
                where number % 21 == 0
                select number;

            Console.WriteLine("--------------- Using LINQ Query ---------------");
            Console.WriteLine("Numbers that are dibisible by 7 and 3 at the same time are: ");

            foreach (var element in numbers)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine();
        }
    }
}
