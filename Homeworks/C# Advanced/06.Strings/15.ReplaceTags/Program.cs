using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _09ReplaceTags
{
    class ReplaceTags
    {

        static string ReplaceLinks(string input)
        {
            return Regex.Replace(input, "(<a href=\")(.*?)(\">)(.*?)(</a>)", "[$4]($2)");
        }

        static void Main()
        {
            var html = Console.ReadLine();

            Console.WriteLine(ReplaceLinks(html));
        }
    }
}
