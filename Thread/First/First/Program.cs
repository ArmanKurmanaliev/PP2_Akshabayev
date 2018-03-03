using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace First
{
    class Program
    {
        public static void t1()
        {
            int a = 0;
            for (int i = 0; i < 50; i++)
            {
                Console.Write(a + " ");
                a++;
                Thread.Sleep(100);
            }
        }

        static void Main(string[] args)
        {
            Thread Thread = new Thread(t1);
            Console.ReadKey();
            Thread.Start();
            Console.ReadKey();
        }
    }
}
