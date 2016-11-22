using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.DecimalToHex
{
    class DecimalToHex
    {
        static void Main()
        {
            long dec = long.Parse(Console.ReadLine());
            StringBuilder hexadecimal = new StringBuilder();
            while(dec > 0)
            {
                if (dec % 16 > 9)
                {
                    switch (dec % 16)
                    {
                        case 10: hexadecimal.Append("A"); break;
                        case 11: hexadecimal.Append("B"); break;
                        case 12: hexadecimal.Append("C"); break;
                        case 13: hexadecimal.Append("D"); break;
                        case 14: hexadecimal.Append("E"); break;
                        case 15: hexadecimal.Append("F"); break;
                        default:
                            break;
                    }
                }
                else
                {
                    hexadecimal.Append(dec % 16).ToString();
                }
                dec /= 16;
            }
            for (int i = hexadecimal.Length - 1; i > -1; i--)
            {
                Console.Write(hexadecimal[i]);
            }
            Console.WriteLine();
        }
    }
}