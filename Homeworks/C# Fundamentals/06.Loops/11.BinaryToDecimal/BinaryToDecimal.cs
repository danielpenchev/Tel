using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main()
        {
            string number = Console.ReadLine();
            int num = Convert.ToInt32(number, 2);
            Console.WriteLine(num);
        }
    }
}
