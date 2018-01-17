using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Rect
    {
        public double length;
        public double width;
        public double area;
        public double perimetr;

        public Rect(double l, double w)
        {
            length = l;
            width = w;
            FindArea();
            FindPerimetr();
        }

        public void FindArea()
        {
            area = length * width;
        }

        public void FindPerimetr()
        {
            perimetr = length + length + width + width;
        }

        public override string ToString()
        {
            return "length = " + length + "\nwidth = " + width + "\narea = " + area + "\nperimetr = " + perimetr;
        }
    }

    
}
