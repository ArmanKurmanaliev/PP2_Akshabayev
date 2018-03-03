﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Cnak
{
    class Wall
    {
        public List<Point> body;
        public string sign;
        public ConsoleColor color;

        public void ReadLevel(int level)
        {
            System.IO.StreamReader sr = new System.IO.StreamReader(@"C:\Wall\level" + level + ".txt");
            int n = int.Parse(sr.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string s = sr.ReadLine();
                for (int j = 0; j < s.Length; j++)
                {
                    if (s[j] == '*')
                        body.Add(new Point(j, i)); 
                }
            }
            sr.Close();
        }

        public Wall (int level)
        {
            body = new List<Point>();
            sign = "#";
            color = ConsoleColor.Yellow;
            ReadLevel(level);
        }

        public void Draw()
        {
            Console.ForegroundColor = color;
            foreach (Point p in body)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);
            }
        }
    }
}
