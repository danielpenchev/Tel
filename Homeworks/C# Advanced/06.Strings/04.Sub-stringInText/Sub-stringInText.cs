using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sub_stringInText
{
    class Program
    {
        static void Main()
        {
            //StringComparison. CurrentCultureIgnoreCase
            string pattern = Console.ReadLine().ToLower();
            string text = Console.ReadLine().ToLower();
            int index = text.IndexOf(pattern);
            int counts = 0;
            while (index != -1)
            {
                index = text.IndexOf(pattern, index + 1);
                counts++;
            }
            Console.WriteLine(counts);
        }
    }
}
