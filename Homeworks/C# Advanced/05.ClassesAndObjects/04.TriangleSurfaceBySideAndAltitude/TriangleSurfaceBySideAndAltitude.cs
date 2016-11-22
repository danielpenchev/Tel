using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TriangleSurfaceBySideAndAltitude
{
    class TriangleSurfaceBySideAndAltitude
    {
        static void Main()
        {
            double length = double.Parse(Console.ReadLine());
            double altitude = double.Parse(Console.ReadLine());
            double surface = (length * altitude) / 2;
            Console.WriteLine("{0:F2}", surface);            
        }
    }
}
