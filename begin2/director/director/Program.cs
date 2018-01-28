using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace director
{
    class Program
    {
        public static void Ex1()
        {
        }

        static void Main(string[] args)
        {
            FileInfo f = new FileInfo(@"C:\Users\PC-User\Desktop\fortest\test.txt");
            Console.WriteLine(f.Name);
            Console.WriteLine(f.FullName);
            Console.WriteLine("\n");

            DirectoryInfo d = new DirectoryInfo(@"C:\Users\PC-User\Desktop\fortest");
            Console.WriteLine(d.FullName);
            Console.WriteLine("\n");

            DirectoryInfo e = new DirectoryInfo(@"C:\Users\PC-User\Desktop\fortest");
            Console.WriteLine(e.FullName);
            FileInfo[] files = d.GetFiles();
            foreach (FileInfo fi in files)
            {
                Console.WriteLine(fi.Name);
            }

            Console.ReadKey();
        }
    }
}
