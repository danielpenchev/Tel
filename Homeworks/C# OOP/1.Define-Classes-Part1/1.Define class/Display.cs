namespace _1.Define_class
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Display
    {
        private double? size;
        private int? colors;

        public Display()
        {
            this.Size = null;
            this.Colors = null;
        }

        public Display(double? size)
            : this()
        {
            this.Size = size;
        }

        public Display(double? size, int? colors)
            : this(size)
        {
            this.Colors = colors;
        }

        public double? Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (this.size <= 0)
                {
                    throw new ArgumentException("You must set size.");
                }
                this.size = value;
            }
        }

        public int? Colors
        {
            get
            {
                return this.colors;
            }
            set
            {
                if (this.colors <= 0)
                {
                    throw new ArgumentException("You must set colors.");
                }
                this.colors = value;
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append("Size - ");

            if (this.Size != null)
            {
                result.Append(string.Format("{0}", this.Size));
            }

            result.Append("Colors - ");

            if (this.Colors != 0)
            {
                result.Append(string.Format("{0}", this.Colors));
            }

            return result.ToString();
        }
    }
}
