using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] arr = line.Split();
            string[] num = arr[0].Split('/');
            string[] num2 = arr[1].Split('/');
            Complex c1 = new Complex(int.Parse(num[0]), int.Parse(num[1]));
            Complex c2 = new Complex(int.Parse(num2[0]), int.Parse(num2[1]));
            Complex an = c1 + c2;
            Complex time = c1 * c2;
            Complex minus = c1 - c2;
            Console.WriteLine(minus);
            Console.WriteLine(time);
            Console.WriteLine(an);
            Console.ReadKey();
        }
    }
}