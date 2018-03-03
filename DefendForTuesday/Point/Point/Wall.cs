﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Point
{
    class Wall
    {
        public List<Point> body;
        string sign;
        ConsoleColor color;

        public void ReadLevel(int level)
        {
            StreamReader sr = new StreamReader("level" + level + ".txt");
            try
            {
                int n = int.Parse(sr.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    string s = sr.ReadLine();
                    for (int j = 0; j < s.Length; j++)
                        if (s[j] == '*')
                            body.Add(new Point(j, i));
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                sr.Close();
            }

        }

        public Wall(int level)
        {
            body = new List<Point>();
            color = ConsoleColor.Yellow;
            sign = "#";
            ReadLevel(level);
        }

        public void Draw()
        {
            foreach (Point p in body)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.ForegroundColor = color;
                Console.Write(sign);
            }
        }
    }
}