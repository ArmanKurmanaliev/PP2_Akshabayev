using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace far3
{
    class Program
    {
        static void ShowDirectoryInfo (DirectoryInfo directory, int cursor)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            FileSystemInfo[] FileSystem = directory.GetFileSystemInfos();

            for (int index = 0; index<FileSystem.Length; index ++)
            {
                FileSystemInfo FileSys = FileSystem[index];
                if (index == cursor)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }


        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\");
            int cursor = 0;
            int n = dir.GetFileSystemInfos().Length;
            ShowDirectoryInfo(dir, cursor);

            while (true)
            {
                ConsoleKeyInfo kk = Console.ReadKey();
                if (kk.Key == ConsoleKey.DownArrow)
                {
                    cursor++;
                    if (cursor == n)
                        cursor = 0;
                }

                if (kk.Key == ConsoleKey.UpArrow)
                {
                    cursor--;
                    if (cursor == -1)
                        cursor = n - 1;
                    ShowDirectoryInfo(dir, cursor);
                }


            }
        }
    }
}
