using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_vol._2
{
    class Circle
    {
        public double radius;
        public double area;

        public Circle()
        {

        }

        public Circle(double radius)
        {
            this.radius = radius;
            FindArea();
        }
        public void FindArea()
        {
            area = Math.PI * radius * radius;
        }

        public override string ToString()
        {
            return "radius = " + radius + "\narea = " + area;
        }


    }

    
}
