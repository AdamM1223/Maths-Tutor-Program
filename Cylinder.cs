using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsTutor
{
    internal class Cylinder: Volume2D
    {
        public Cylinder(string newDescription, double newDimension1, double newDimension2) : base(newDescription, newDimension1, newDimension2) { }

        public override double calculateVolume()
        {
            double Volume = Math.PI * (Math.Pow(this.getDimension1(), 2)) * this.getDimension2();
            return Math.Round(Volume, 2);
        }
    }
}
