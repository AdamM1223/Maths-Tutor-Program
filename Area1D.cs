using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsTutor
{
    abstract class Area1D
    {
        private string description = "";
        private double dimension1 = 0.0;
        public Area1D() { }
        public Area1D(string description) {
            this.description = description;
        }

        public Area1D(string description, double dimension1) {
            this.description = description;
            this.dimension1 = dimension1;
        }
        
   

        public void setDescription(string newDescription)
        {
            this.description = newDescription;
        }
        public void setDimension1(double newDimension)
        { 
            this.dimension1 = newDimension;
        }
        public string getDescription()
        {
            return this.description;
        }
        public double getDimension1()
        {
            return this.dimension1;
        }

        public abstract double calculateArea();
     
    }

}
