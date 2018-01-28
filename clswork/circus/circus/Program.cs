using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circus
{
    class Circle
    {
        public double radius;
        public double area;

        public void FindArea()
        {
            area = Math.PI * radius * radius;
        }

        public Circle (double radius)
        {
            this.radius = radius;
            FindArea();
        }

        public override string ToString()
        {
            return "radius = " + radius + "\narea = " + area;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            Circle c = new Circle(r);

            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
