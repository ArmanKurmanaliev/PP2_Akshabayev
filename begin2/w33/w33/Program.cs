using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace w33
{
    class Program
    {
        static void ShowDir (DirectoryInfo dir, int cursor)
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Clear();
            FileSystemInfo[] FileSys = dir.GetFileSystemInfos();

            for (int index = 0; index < FileSys.Length; index++)
            {
                FileSystemInfo FileSystem = FileSys[index];
                if (index == cursor)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                }

                if (FileSystem.GetType() == typeof(DirectoryInfo))
                    Console.ForegroundColor = ConsoleColor.Green;

                else
                    Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(FileSystem.Name);
            }
        }

        static void Main(string[] args)
        {
            DirectoryInfo DirInfo = new DirectoryInfo(@"C:\");
            int cursor = 0;
            int n = DirInfo.GetFileSystemInfos().Length;
            ShowDir(DirInfo, cursor);

            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.DownArrow)
                {
                    cursor++;
                    if (cursor == n)
                        cursor = 0;
                }

                if (key.Key == ConsoleKey.UpArrow)
                {
                    cursor--;
                    if (cursor == -1)
                        cursor = n - 1;
                }

                if (key.Key == ConsoleKey.Enter)
                {
                    if (DirInfo.GetFileSystemInfos()[cursor].GetType() == typeof(DirectoryInfo))
                    {
                        DirInfo = new DirectoryInfo(DirInfo.GetFileSystemInfos()[cursor].FullName);
                        cursor = 0;
                        n = DirInfo.GetFileSystemInfos().Length;
                    }

                    else
                    {
                        StreamReader sr = new StreamReader(DirInfo.GetFileSystemInfos()[cursor].FullName);
                        string s = sr.ReadToEnd();
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(s);
                        Console.ReadKey();
                    }
                }

                if (key.Key == ConsoleKey.Escape || key.Key == ConsoleKey.Backspace)
                {
                    if (DirInfo.Parent != null)
                    {
                        DirInfo = DirInfo.Parent;
                        cursor = 0;
                        n = DirInfo.GetFileSystemInfos().Length;
                    }
                    else
                        break;
                }

                ShowDir(DirInfo, cursor);
            }
        }
    }
}
