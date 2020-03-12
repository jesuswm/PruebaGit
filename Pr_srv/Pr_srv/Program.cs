using System;  
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;  
using System.Text;  
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks; 

namespace Pr_srv
{
    public delegate int Operation(int a, int b);
    class Program
    {
            static readonly object l = new object();
            static void Main(string[] args)
            {
                Thread thread = new Thread(action);
                thread.Start();
                Thread.Sleep(50);
                lock (l)
                {
                    Monitor.Pulse(l);
                }
                Console.ReadKey();
            }
            static void action()
            {
                lock (l)
                Monitor.Wait(l);
                Console.WriteLine("Don't rest anymore...");
            }
    }
}