namespace StringBuilderSubstring
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class StringBuilderExt
    {
        public static StringBuilder Substring(this StringBuilder sb, int index, int len)
        {
            StringBuilder current = new StringBuilder();

            for (int i = index; i < index + len; i++)
            {
                current.Append(sb[i]);
            }
            
            return current;
        }
    }
}
