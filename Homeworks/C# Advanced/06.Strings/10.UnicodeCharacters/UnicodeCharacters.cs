using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var output = new StringBuilder();
            var unicode = "\\u{0:X4}";
            foreach (var element in input)
            {
                output.Append(string.Format(unicode,(int)element));
            }
            Console.WriteLine(output);
        }
    }
}
