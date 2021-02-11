using System;

namespace URI1018
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, resto, qtde100, qtde50, qtde20, qtde10, qtde5, qtde2, qtde1;

            N = int.Parse(Console.ReadLine());

            qtde100 = N / 100;

            resto = N % 100;

            qtde50 = resto / 50;

            resto = resto % 50;

            qtde20 = resto / 20;

            resto = resto % 20;

            qtde10 = resto / 10;

            resto = resto % 10;

            qtde5 = resto / 5;

            resto = resto % 5;

            qtde2 = resto / 2;

            resto = resto % 2;

            qtde1 = resto;

            Console.WriteLine(N);
            Console.WriteLine(qtde100 + " nota(s) de R$ 100,00");
            Console.WriteLine(qtde50 + " nota(s) de R$ 50,00");
            Console.WriteLine(qtde20 + " nota(s) de R$ 20,00");
            Console.WriteLine(qtde10 + " nota(s) de R$ 10,00");
            Console.WriteLine(qtde5 + " nota(s) de R$ 5,00");
            Console.WriteLine(qtde2 + " nota(s) de R$ 2,00");
            Console.WriteLine(qtde1 + " nota(s) de R$ 1,00");
        }
    }
}
