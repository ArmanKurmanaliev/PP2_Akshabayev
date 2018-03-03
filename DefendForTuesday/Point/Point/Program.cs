using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Point
{
    class Program
    {
        static Snake snake = new Snake();
        static Wall wall = new Wall(1);
        static int direction = 0; // 1 - left, 2 - right, 3 - up, 4 - down
        static bool gameOver = false;
        static int speed = 100;
        static Food Food = new Food();

        static void playGame()
        {
            while (!gameOver)
            {
                if (direction == 1)
                    snake.Move(-1, 0);
                if (direction == 2)
                    snake.Move(1, 0);
                if (direction == 3)
                    snake.Move(0, -1);
                if (direction == 4)
                    snake.Move(0, 1);
                if (snake.cnt == 60)
                {
                    wall = new Wall(2);
                    Console.Clear();
                }
                if (snake.CollisionWallandSnake(wall.body))
                {
                    Console.Clear();
                    gameOver = true;
                }


                snake.Draw();
                wall.Draw();
                Thread.Sleep(speed);
                
            }
        }

        static void Main(string[] args)
        {

            
            Console.CursorVisible = false;
            Thread thread = new Thread(playGame);
            thread.Start();

            while (!gameOver)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.UpArrow)
                    direction = 3;
                if (keyInfo.Key == ConsoleKey.DownArrow)
                    direction = 4;
                if (keyInfo.Key == ConsoleKey.LeftArrow)
                    direction = 1;
                if (keyInfo.Key == ConsoleKey.RightArrow)
                    direction = 2;
                if (keyInfo.Key == ConsoleKey.Escape)
                    gameOver = true;
            }
        }
    }
}