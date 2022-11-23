using System;

namespace bninamango
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Factorial : ");

            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(Factorial(n));
        }

        private static int Factorial(int n)
        {
            if (n == 0) return 1;

            return n * Factorial(n - 1);
        }
    }
}
