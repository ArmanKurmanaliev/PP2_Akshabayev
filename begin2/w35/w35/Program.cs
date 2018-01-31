using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3G1_Example4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0;
            while (true)
            {
                Console.Clear();
                Console.CursorVisible = false;

                Console.SetCursorPosition(x, y);
                Console.Write("o");

                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.UpArrow)
                    y--;
                if (keyInfo.Key == ConsoleKey.DownArrow)
                    y++;
                if (keyInfo.Key == ConsoleKey.LeftArrow)
                    x--;
                if (keyInfo.Key == ConsoleKey.RightArrow)
                    x++;
            }
        }
    }
}