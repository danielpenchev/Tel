using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.TriangleSurfaceByTwoSidesAndAngle
{
    class TriangleSurfaceByTwoSidesAndAngle
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double angle = double.Parse(Console.ReadLine());
            
            double result = ((a * b) / 2) * Math.Sin(angle * Math.PI / 180);
            Console.WriteLine("{0:F2}", result);
            Console.WriteLine(123);
        }
    }
}
