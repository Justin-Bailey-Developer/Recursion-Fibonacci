using System;
using System.Collections.Generic;

namespace Recursion_Fibonacci
{
    class Program
    {

        //Factorial & GCD


        //Borrowed from: https://www.davidhayden.me/blog/recursive-fibonacci-and-memoization-in-csharp

        static Dictionary<int, long> _memo =
            new Dictionary<int, long>() { { 0, 0 }, { 1, 1 } };

        static void Main(string[] args)
        {
            for (int i = 0; i <= 75; i++)
            {
                Console.WriteLine($"Fib({i}) = {Fib(i)}");
            }
        }

        //Memoization
        static long Fib(int n)
        {
            if (_memo.ContainsKey(n))
                return _memo[n];

            long value = Fib(n - 1) + Fib(n - 2);

            _memo[n] = value;

            return value;
        }
                
    }
}
