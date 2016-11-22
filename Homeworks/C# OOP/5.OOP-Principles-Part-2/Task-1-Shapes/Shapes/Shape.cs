namespace Shapes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public abstract class Shape
    {
        private double width;
        private double height;

        public Shape(double width, double height)
        {
            this.Width = width;
            this.height = height;
        }

        public double Width
        {
            get { return this.width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Width cannot be negative number or zero.");
                }
                else
                {
                    this.width = value;
                }
            }
        }

        public double Height
        {
            get { return this.height; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Height cannot be negative number or zero.");
                }
                else
                {
                    this.height = value;
                }
            }
        }

        public abstract double CalculateSurface();
    }
}
