using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double l = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());

            Rect r = new Rect(l, w);
            Console.WriteLine(r);
            Console.ReadKey();
        }
    }
}
