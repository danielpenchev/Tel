using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.HexToDecimal
{
    class HexToDecimal
    {
        static void Main()
        {
            //string number = Console.ReadLine();
            //long dec = 0;
            //long index = 0;
            //int j = 0;
            //for (int i = number.Length - 1; i > -1; i--)
            //{
            //    switch (number[i])
            //    {
            //        case 'A': index = 10; break;
            //        case 'B': index = 11; break;
            //        case 'C': index = 12; break;
            //        case 'D': index = 13; break;
            //        case 'E': index = 14; break;
            //        case 'F': index = 15; break;
            //        default: index = int.Parse(number[i].ToString()); break;
            //    }
            //    dec += index * (long)Math.Pow(16, j);
            //    j++;
            //}
            //Console.WriteLine(dec);

            string hex = Console.ReadLine();
            long dec = 0;
            long index = 0;
            int j = 0;
            for (int i = hex.Length - 1; i > - 1; i--)
            {
                switch (hex[i])
                {
                    case 'A': index = 10; break;
                    case 'B': index = 11; break;
                    case 'C': index = 12; break;
                    case 'D': index = 13; break;
                    case 'E': index = 14; break;
                    case 'F': index = 15; break;
                    default: index = int.Parse(hex[i].ToString());
                        break;
                }
                dec += index * (long)Math.Pow(16,j);
                j++;
            }
            Console.WriteLine(dec);
        }
    }
}
