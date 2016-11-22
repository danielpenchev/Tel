using System;

class AsciTable
{
    static void Main()
    {
        for (int i = 33; i <= 126; i++)
        {
            char letter = (char)i;
            Console.Write("{0}",letter);
        }
    }
}