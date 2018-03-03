using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyThread thread1 = new MyThread("Thread 1", 10);
            MyThread thread2 = new MyThread("Thread 2", 5);
            MyThread thread3 = new MyThread("Thread 3", 60);
            MyThread thread4 = new MyThread("Thread 4", 8);
            MyThread thread5 = new MyThread("Thread 5", 12);
            Console.ReadKey();
        }
    }
}