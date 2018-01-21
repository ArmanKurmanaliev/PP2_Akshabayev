using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example4
{
    class Program
    {
        static bool IsPrime(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            for (int i=0; i<=a; i++)
            {
                if (IsPrime(i))
                    Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}