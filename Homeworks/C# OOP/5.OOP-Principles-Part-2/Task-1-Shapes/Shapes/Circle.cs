namespace Shapes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class Circle : Shape
    {
        public Circle(double radius)
            : base(radius, radius)
        {

        }

        public override double CalculateSurface()
        {
            double surface = Math.PI * (this.Width / 2.0) * (this.Height / 2.0);
            return surface;
        }
    }
}
