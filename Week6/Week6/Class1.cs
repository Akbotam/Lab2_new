﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Week6
{
    class Class1
    {
        static void F1()
        {
            for (int i = 0; i < 100; i++)
                Console.WriteLine("In F1:" + i);
            Thread.Sleep(0);
        }
        static void Main(string[] args)
        {
            Thread thread = new Thread(F1);
            thread.Start();
            for (int i = 0; i < 100; i++)
                Console.WriteLine("In main:" + i);
            Thread.Sleep(0);
        } 
        
 
    }
    Console.ReadKey();
}
