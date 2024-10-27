using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsTutor
{
    abstract class Volume2D: Volume1D
    {

        private double dimension2;
        public Volume2D(string description, double dimension1, double dimension2) : base(description, dimension1)
        {
            this.dimension2 = dimension2;

        }

        public void setDimension2(double newDimension2)
        {
            this.dimension2 = newDimension2;
        }
        public double getDimension2()
        {
            return this.dimension2;
        }

    }
}
