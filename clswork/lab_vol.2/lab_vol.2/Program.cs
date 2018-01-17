using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_vol._2
{
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
