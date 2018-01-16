using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sec
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] s = line.Split();

            int sum = 0;

            for (int i = 0; i < s.Length; i++)
            {
                sum += int.Parse(s[i]);
            }

            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
