namespace Divisibleby7and3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class DivisibleNumbersRun
    {
        public static void Testing()
        {
            int[] array = new int[] { 1, 2, 3, 4, 1, 3, 35, 21, 13, 1, 2, 3, 12, 312, 3, 123, 0, -123 };

            DivisibleNumbers.PrintNumbersUsingLambda(array);
            DivisibleNumbers.PrintNumbersUsingLINQ(array);
        }
    }
}
