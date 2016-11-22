using System;

class FormattingNumbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("{0:X} |{1,10}| {2,-1:0.00}|{3,-1:0.000} |",a , Convert.ToString(a, 2).PadLeft(10, '0'), b, c);
    }
}
