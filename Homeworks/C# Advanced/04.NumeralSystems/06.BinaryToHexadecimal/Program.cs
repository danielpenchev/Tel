using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.HexadecimalToBinary
{
    class Program
    {
        static string ConvertToHex(string binaryNumber)
        {
            long decimalNumber = Convert.ToInt64(binaryNumber, 2);

            string hexNumber = Convert.ToString(decimalNumber, 16);

            return hexNumber.ToUpper().TrimStart('0');
        }

        static void Main()
        {
            string binaryNum = Console.ReadLine();
            string result = ConvertToHex(binaryNum);
            Console.WriteLine(result);
        }
    }
}

