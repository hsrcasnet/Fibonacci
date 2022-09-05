using System;
using System.Collections.Generic;
using System.Threading;

namespace Fibonacci.ConsoleApp
{
    internal class Program
    {
        private static void Main()
        {
            var list = new List<int>();

            for (var i = 0; i < 100; i++)
            {
                Thread.Sleep(1000);
                var fibonacci = Algorithms.Fibonacci(i);
                list.Add(fibonacci);

                Console.WriteLine(fibonacci);
            }
        }
    }
}