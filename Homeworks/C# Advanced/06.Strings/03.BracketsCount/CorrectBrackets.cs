using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.BracketsCount
{
    class CorrectBrackets
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var openBrackets = 0;
            var closeBrackets = 0;

            foreach (var index in input)
            {
                if(index == '(')
                {
                    openBrackets++;
                    continue;
                }
                else if(index == ')')
                {
                    closeBrackets++;
                    continue;
                }
            }
            if(openBrackets == closeBrackets)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
        }
    }
}
