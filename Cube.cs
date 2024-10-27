using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsTutor
{
    internal class Cube: Volume1D
    {
        public Cube(string newDescription, double newDimension1) : base(newDescription, newDimension1) { }
        public Cube(string newDescription) : base(newDescription) { }

        public override double calculateVolume()
        {
            double Volume = Math.Pow(getDimension1(), 3);

            return Math.Round(Volume, 2);
        }
    }
}
