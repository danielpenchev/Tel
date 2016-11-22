namespace _23.SeriesOfLetters
{
    using System;
    using System.Linq;
    using System.Text;
    class SeriesOfLetters
    {
        static void Main()
        {
            var input = Console.ReadLine();

            char prev = ' ';
            var sb = new StringBuilder();

            foreach (var ch in input)
            {
                if (ch != prev)
                {
                    sb.Append(ch);
                    prev = ch;
                }
            }

            Console.WriteLine(sb);
        }
    }
}
