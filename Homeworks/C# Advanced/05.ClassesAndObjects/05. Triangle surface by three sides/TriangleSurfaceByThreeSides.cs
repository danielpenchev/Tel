using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Triangle_surface_by_three_sides
{
    class TriangleSurfaceByThreeSides
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double s = (a + b + c) / 2.0D;
            double result = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            Console.WriteLine("{0:F2}", result);
        }
    }
}
