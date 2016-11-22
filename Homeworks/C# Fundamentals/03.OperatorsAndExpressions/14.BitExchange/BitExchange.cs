using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitExchange
{
    class BitExchange
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int mask = 0;
            int bit = 0;
            int p = 0;
            int numP = 0;
            for (int i = 0; i < 3; i++)
            {
                p = 3 + i;
                numP = num >> p;
                bit = numP & 1;
                if (bit == 1)
                {
                    mask = 1 << 24 + i;
                    num = num | mask;
                }
                else
                {
                    mask = ~(1 << 24 + i);
                    num = num & mask;
                }
            }
            Console.WriteLine(num);
        }
    }
}
