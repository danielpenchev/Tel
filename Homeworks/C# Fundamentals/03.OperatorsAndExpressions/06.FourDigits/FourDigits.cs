using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourDigits
{
    class FourDigits
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int d = number % 10;
            int thirdNum = number / 10;
            int c = thirdNum % 10;
            int secondNum = number / 100;
            int b = secondNum % 10;
            int firstNum = number / 1000;
            int a = firstNum % 10;

            Console.WriteLine("{0}", a+b+c+d);
            Console.WriteLine("{0}{1}{2}{3}", d, c, b, a);
            Console.WriteLine("{0}{1}{2}{3}", d, a, b, c);
            Console.WriteLine("{0}{1}{2}{3}", a, c, b, d);
           
        }
    }
}
