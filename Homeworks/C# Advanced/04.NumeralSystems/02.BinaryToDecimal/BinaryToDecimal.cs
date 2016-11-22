using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main()
        {
            string n = Console.ReadLine();
            long result = 0;

            foreach (var digit in n)
            {
                result = (digit - '0') + result * 2;
            }
            Console.WriteLine(result);
        }
    }
}
