namespace StringBuilderSubstring
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SubstringRun
    {
        public static void Testing()
        {
            var input = new StringBuilder();
            input.Append("0123456789");
            var result = input.Substring(5, 3);
            Console.WriteLine(result);
        }
    }
}
