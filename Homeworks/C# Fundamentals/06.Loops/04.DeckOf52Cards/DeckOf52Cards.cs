using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DeckOf52Cards
{
    static void Main()
    {
            char input = char.Parse(Console.ReadLine());
            int number = (int)(input - '0');
            for (int card = 0; card < number - 1; card++)
            {
                for (int type = 0; type < 4; type++)
                {
                    switch (card)
                    {
                        case 0:
                            Console.Write("2 of ");break;
                        case 1:
                            Console.Write("3 of "); break;
                        case 2:
                            Console.Write("4 of "); break;
                        case 3:
                            Console.Write("5 of "); break;
                        case 4:
                            Console.Write("6 of "); break;
                        case 5:
                            Console.Write("7 of "); break;
                        case 6:
                            Console.Write("8 of "); break;
                        case 7:
                            Console.Write("9 of "); break;
                        case 8:
                            Console.Write("10 of "); break;
                        case 9:
                            Console.Write("J of "); break;
                        case 10:
                            Console.Write("Q of "); break;
                        case 11:
                            Console.Write("K of "); break;
                        case 12:
                            Console.Write("A of "); break;
                        default:
                            break;
                    }
                    switch (type)
                    {
                        case 0:
                            Console.Write("spades, "); break;
                        case 1:
                            Console.Write("clubs, "); break;
                        case 2:
                            Console.Write("hearts, "); break;
                        case 3:
                            Console.Write("diamonds"); break;
                        default:
                            break;
                    }
            } 
            Console.WriteLine();
        }
    }
}