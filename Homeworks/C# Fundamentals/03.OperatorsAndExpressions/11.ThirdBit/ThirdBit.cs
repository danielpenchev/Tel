using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ThirdBit
{
    class ThirdBit
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int mask = 1 << 3;
            int result = number & mask;
            int bit = result >> 3;
            Console.WriteLine(bit);
        }
    }
}
