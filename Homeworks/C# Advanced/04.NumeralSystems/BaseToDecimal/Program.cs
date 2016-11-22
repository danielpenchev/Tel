namespace BaseToDecimal
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    class Program
    {
        static long BaseToDecimal(string number, int numeralSystem)
        {
            long decimalNumber = 0;

            for (int i = 0; i < number.Length; i++)
            {
                int digit = 0;
                if(number[i] >= '0' && number[i] <= '9')
                {
                    digit = number[i] - '0';
                }
                else
                {
                    digit = number[i] - 'A' + 10;
                }
                decimalNumber += digit * (long)Math.Pow(numeralSystem, number.Length - i - 1);
            }
            return decimalNumber;
        }

        static void Main()
        {
            string number = Console.ReadLine();
            Console.WriteLine(BaseToDecimal(number, 16));
        }
    }
}
