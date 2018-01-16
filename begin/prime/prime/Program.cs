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
            int[] n = new int[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                n[i] = int.Parse(s[i]);
            }

            for (int i = 0; i < n.Length; i++)
            {
                for (int j=2; j<n.Length; j++)
                {
                    
                }
            }



            Console.ReadKey();
        }
    }
}
