using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace direct2
{
    class Program
    {
        public static void PrintEmptySpaces(int n)
        {
            for (int i=0; i<n; i++)
            {
                Console.WriteLine(" ");
            }
        }


        public static void Ex4(DirectoryInfo d, int level)
        {
            //try
            {
                FileInfo[] files = d.GetFiles();
                DirectoryInfo[] directories = d.GetDirectories();

                foreach (FileInfo file in files)
                {
                    PrintEmptySpaces(level);
                    Console.WriteLine(file.Name);
                }

                foreach (DirectoryInfo directory in directories)
                {
                    PrintEmptySpaces(level);
                    Console.WriteLine(directory.Name);
                    Ex4(directory, level + 1);
                }
            }
            //catch (Exception Ex)
            //{
            //    Console.WriteLine(Ex.ToString());
            //    Console.ReadKey();
            //}
        }



        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo(@"C:\study");
            Ex4(d, 0);
            Console.ReadKey();
        }
    }
}
