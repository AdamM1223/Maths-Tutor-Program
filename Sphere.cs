using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsTutor
{
    internal class Sphere: Volume1D
    {
        public Sphere(string newDescription, double newDimension1) : base(newDescription, newDimension1) { }
        public Sphere(string newDescription) : base(newDescription) { }

        public override double calculateVolume()
        {
            double Volume = 4/3 * Math.PI * (Math.Pow(this.getDimension1(), 3));
            return Math.Round(Volume, 2);
        }
    }
}
