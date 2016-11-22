using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ParseTags
{
    class ParseTags
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(new[] {'<', '>'}.ToArray());
            var openTag = "upcase";
            var closeTag = "/upcase";

            var resultSb = new StringBuilder();
            var toUpper = false;

            foreach (var word in input)
            {
                if (word == openTag)
                {
                    toUpper = true;
                    continue;
                }
                if (word == closeTag)
                {
                    toUpper = false;
                    continue;
                }
                if (toUpper)
                {
                    resultSb.Append(word.ToUpper());
                }
                else
                {
                    resultSb.Append(word);
                }
            }
            Console.WriteLine(resultSb);


        }
    }
}
