using System;

namespace Vetores2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, pares;
    
            N = int.Parse(Console.ReadLine());

            string[] s = Console.ReadLine().Split(" ");

            int[] numeros = new int[N];

            pares = 0;

            for (int i = 0; i < N; i++)
            {
                numeros[i] = int.Parse(s[i]);
            }

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    Console.Write(numeros[i] + " ");
                    pares++;
                }                
            }
            Console.WriteLine();
            Console.WriteLine(pares);
            Console.ReadLine();
        }
    }
}
