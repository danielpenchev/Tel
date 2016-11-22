using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NthBit
{
    class NthBit
    {
        static void Main()
        {
            int p = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int mask = 1 << n;
            int number = p & mask;
            int bit = number >> n;
            Console.WriteLine(bit);
        }
    }
}
