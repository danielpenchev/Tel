using System;
using System.Linq;

class GetBiggerNumber
{
    static int GetMax(int firstNumber, int secondNumber)
    {
        if(firstNumber > secondNumber)
        {
            return firstNumber;
        }
        return secondNumber;
    }

    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int number1 = numbers[0];
        int number2 = numbers[1];
        int number3 = numbers[2];

        Console.WriteLine(GetMax(number1,GetMax(number2, number3)));
    }
}
