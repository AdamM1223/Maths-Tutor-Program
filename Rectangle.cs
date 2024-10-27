using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsTutor
{
    internal class Rectangle: Area2D
    {
        public Rectangle(string newDescription, double newDimension1, double newDimension2) : base(newDescription, newDimension1, newDimension2)
        {

        }

        public override double calculateArea()
        {
            double area = this.getDimension1() * this.getDimension2();
            return area;
        }


    }
}
