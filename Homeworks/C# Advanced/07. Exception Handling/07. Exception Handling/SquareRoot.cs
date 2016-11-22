namespace _07.Exception_Handling
{
    using System;
    class SquareRoot
    {
        static void Main()
        {
            try
            {
                var input = double.Parse(Console.ReadLine());
                if(input < 0)
                {
                    throw new System.FormatException();
                }
                Console.WriteLine(Math.Sqrt(input).ToString("F3"));
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
