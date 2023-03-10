﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAndAwait
{
   public class Program
    {
        static void Main(string[] args)
        {

            //This task will as the which task having less time.
            Task1();
            Task2();
            Task3();
            Task4();
            Console.ReadLine();
        }

        //Asynchronous Example
        public static async void Task1()
        {
            await Task.Run(()=> {

                Console.WriteLine("Task 1 Starting...");
                Thread.Sleep(4000);
                Console.WriteLine("Task 1 Completed");

            });
           
        }

        public static async void Task2()
        {
           await Task.Run(() => {

                Console.WriteLine("Task 2 Starting...");
                Thread.Sleep(2000);
                Console.WriteLine("Task 2 Completed");

            });

        }
        public static async void Task3()
        {
           await Task.Run(() => {

                Console.WriteLine("Task 3 Starting...");
                Thread.Sleep(5000);
                Console.WriteLine("Task 3 Completed");

            });

        }
        public static async void Task4()
        {
            await Task.Run(() => {

                Console.WriteLine("Task 4 Starting...");
                Thread.Sleep(1000);
                Console.WriteLine("Task 4 Completed");

            });

        }
    }
}
