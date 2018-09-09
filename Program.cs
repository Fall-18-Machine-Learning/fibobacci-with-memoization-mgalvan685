using System;
using System.Collections.Generic;

namespace Fib
{
    class Program
    {
        static Dictionary<int, int> mem = new Dictionary<int, int>();   // key - fib num, value - result

        static void Main(string[] args)
        {
            Console.WriteLine("Calculating 4th Fibonacci number...");
            memoize(4);

            Console.WriteLine("Calculating 40th Fibonacci number...");
            memoize(40);

            Console.WriteLine("Calculating 10th Fibonacci number...");
            memoize(10);

            Console.WriteLine("Calculating 40th Fibonacci number (again)...");
            memoize(40);

            Console.WriteLine("Press any key to exit...");
            Console.Read();

            // Uncomment below lines to input your own numbers
            //while (true)
            //{
            //    Console.WriteLine("Enter a number to find it's fibonacci sequence (type a negative number to quit): ");
            //    try
            //    {
            //        int input = Int32.Parse(Console.ReadLine());

            //        if (input < 0)
            //            break;

            //        memoize(input);     
            //    }
            //    catch
            //    {
            //        Console.WriteLine("Invalid entry. Try again.\n");
            //    }
            //}
        }

        static int fibNum(int n)
        {
            if (n == 0) { return 0; }
            if (n == 1) { return 1; }

            return (fibNum(n - 1) + fibNum(n - 2));
        }

        static void memoize(int input)
        {
            if (mem.ContainsKey(input))
            {
                Console.WriteLine("Fibonacci number (memoized): {0}\n", mem[input]);
            }
            else
            {
                int num = fibNum(input);
                Console.WriteLine("Fibonacci number (not memoized): {0}\n", num);
                mem.Add(input, num);
            }
        }
    }
}
