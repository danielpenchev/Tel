using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangles
{
    class Rectangles
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = width * height;
            double perimeter = 2 * (width + height);
            Console.WriteLine("{0:F2} {1:F2}", area, perimeter);
        }
    }
}
