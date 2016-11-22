﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods.Utils
{
    public class ConsoleWriter
    {
        /// <summary>
        /// Writes a number on the Console in the required format.
        /// </summary>
        /// <param name="number">A number to print. </param>
        /// <param name="format"> Allowed value "f", "%", "r". </param>
        public static void PrintAsNumber(object number, string format)
        {
            if (number == null)
            {
                throw new ArgumentNullException("number");
            }

            if (format == null)
            {
                throw new ArgumentNullException("format");
            }

            decimal parsedNumber;
            var isParsed = decimal.TryParse(number.ToString(), out parsedNumber);
            if (!isParsed)
            {
                throw new ArgumentException("Invalid number.");
            }

            if (format == "f")
            {
                Console.WriteLine("{0:f2}", number);
            }
            else if (format == "%")
            {
                Console.WriteLine("{0:p0}", number);
            }
            else if (format == "r")
            {
                Console.WriteLine("{0,8}", number);
            }
            else
            {
                throw new ArgumentException("Invalid format string.");
            }
        }
    }
}
