using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

namespace DraftDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Id : {Thread.CurrentThread.ManagedThreadId}, name: {Thread.CurrentThread.Name}");

            Thread thread1 = new Thread(MethodThread1);
            Thread thread2 = new Thread(MethodThread2);
            thread1.Priority = ThreadPriority.Lowest;
            thread2.Priority = ThreadPriority.Highest;
            thread1.Start();
            //thread1.Join();
            
            thread2.Start();
            thread1.Interrupt();

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"Thread main.{i + 1}, time: {DateTime.Now.ToString("dd/MM/yy hh:mm:ss tt")}");
            //}

        }

        public static void MethodThread1()
        {
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"1. ThreadId.{Thread.CurrentThread.ManagedThreadId}. Time: {DateTimeOffset.Now.ToString("dd/MM/yy hh:mm:ss tt fff")}");
                    //Thread.Yield();
                    if (i == 5)
                    {
                        Thread.CurrentThread.Interrupt();
                    }
                }
            }
            catch(ThreadAbortException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void MethodThread2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"2. ThreadId.{Thread.CurrentThread.ManagedThreadId}. Time: {DateTimeOffset.Now.ToString("dd/MM/yy hh:mm:ss tt fff")}");
                
            }
        }
    }
}
