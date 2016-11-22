namespace Shapes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class ShapesRun
    {
        public static void Testing()
        {
            Shape[] shapes = new Shape[]
            {
                new Triangle(5.23, 6.85),
                new Rectangle(1.21, 5.32),
                new Circle(12.3)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine("{0}= {1:0.00}", shape.GetType().Name, shape.CalculateSurface());
            }
        }
    }
}
