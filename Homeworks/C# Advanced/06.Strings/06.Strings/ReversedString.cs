using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Strings
{
    class ReversedString
    {

        public static string ReverseString(string text)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = text.Length - 1; i >= 0; i--)
            {
                sb.Append(text[i]);
            }
            return sb.ToString(); 
        }

        static void Main()
        {
            string input = Console.ReadLine();
            string reversed = ReverseString(input);
            Console.WriteLine(reversed);

            /*
            string input = Console.ReadLine();
            char[] array = input.ToCharArray();
            Array.Reverse(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine();
             */
        }
    }
}
