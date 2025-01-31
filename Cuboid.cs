﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsTutor
{
    internal class Cuboid: Volume3D
    {
        public Cuboid(string newDescription, double newDimension1, double newDimension2, double newDimension3) : base(newDescription, newDimension1, newDimension2, newDimension3) { }

        public override double calculateVolume()
        {
            double Volume = (this.getDimension1() * this.getDimension2() * this.getDimension3());
            return Math.Round(Volume, 2);
        }
    }
}
