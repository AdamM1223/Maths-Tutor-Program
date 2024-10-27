using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsTutor
{
    abstract class Volume3D: Volume2D
    {
        private double dimension3;
        public Volume3D(string description, double dimension1, double dimension2, double dimension3) : base(description, dimension1, dimension2)
        {
            this.dimension3 = dimension3;

        }

        public void setDimension3(double newDimension3)
        {
            this.dimension3 = newDimension3;
        }
        public double getDimension3()
        {
            return this.dimension3;
        }
    }
}
