namespace RangeExceptionsClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class ExceptionsRun
    {
        static void IntegerTest(int start, int end, int inputNumber)
        {
            try
            {
                if (inputNumber < start || inputNumber > end)
                {
                    throw new InvalidRangeException<int>("Number is out of range!", start, end);
                }
                else
                {
                    Console.WriteLine("The number is in range!");
                }
            }
            catch (InvalidRangeException<int> ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("The range is [{0} - {1}]", ex.Start, ex.End);
            }
        }

        static void DateTimeTest(DateTime start, DateTime end, DateTime inputDate)
        {
            try
            {
                if (inputDate < start || inputDate > end)
                {
                    throw new InvalidRangeException<DateTime>("Date is out of range!", start, end);
                }
                else
                {
                    Console.WriteLine("The date is in range!");
                }
            }
            catch (InvalidRangeException<DateTime> ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("The range is [{0} - {1}]", ex.Start, ex.End);
            }
        }

        public static void Testing()
        {
            IntegerTest(1, 5, 10);
            DateTimeTest(new DateTime(1994, 6, 25), new DateTime(1995, 12, 12), new DateTime(2016, 6, 26));
        }
    }
}
