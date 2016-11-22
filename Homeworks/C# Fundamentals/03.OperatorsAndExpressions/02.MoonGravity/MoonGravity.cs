using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoonGravity
{
    class MoonGravity
    {
        static void Main()
        {
            float W = float.Parse(Console.ReadLine());
            float weightOnMoon = W * 0.17f;
            Console.WriteLine("{0:0.000}", weightOnMoon);
        }
    }
}
