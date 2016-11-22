using System;

namespace PrintOnTheConsole
{
    public class BooleanVariable
    {
        public void Print(bool variableToPrint)
        {
            string changeBoolToString = variableToPrint.ToString();
            Console.WriteLine(changeBoolToString);
        }
    }
}
