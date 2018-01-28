using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace w3._1
{
    class Program
    {
        static void Main(string[] args)
        {/*
            DirectoryInfo directory = new DirectoryInfo(@"C:\");
            DirectoryInfo[] dd = directory.GetDirectories();
            FileInfo[] ff = directory.GetFiles();

            foreach (DirectoryInfo d in dd)
                Console.WriteLine(d.Name);

            foreach (FileInfo f in ff)
                Console.WriteLine(f.Name);
            */
            DirectoryInfo dd = new DirectoryInfo(@"C:\");
            FileSystemInfo[] fss = dd.GetFileSystemInfos();

            foreach (FileSystemInfo f in fss)
            {
                if (f.GetType() == typeof(DirectoryInfo))
                    Console.WriteLine("Folder  " + f.Name);
                else
                    Console.WriteLine("File    " + f.Name);

            }

            Console.ReadKey();
        }
    }
}
