using System;

namespace Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor positivo: ");

            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Fibonacci de {n} = {Fibonacci(n)}");

        }

        static int Fibonacci(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return (Fibonacci(n - 2) + Fibonacci(n - 1));
            }
        }

    }

}
