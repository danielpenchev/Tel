using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideBy7And5
{
    class DivideBy7And5
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            bool divisible = true;
            if (number % 35 == 0)
            {
                divisible = true;
                Console.WriteLine("true {1}", divisible, number);
            }
            else
            {
                divisible = false;
                Console.WriteLine("false {1}", divisible, number);
            }
        }
    }
}
