namespace LongestString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LongestElement
    {
        public static void Testing()
        {
            var array = new string[] { "Cuklev", "Nakov", "Kostooov", "Doncho0o0o0o" };
            string maxLength = array.OrderByDescending(x => x.Length).First();

            Console.WriteLine("The longest element is: {0}", maxLength);
        }
    }
}
