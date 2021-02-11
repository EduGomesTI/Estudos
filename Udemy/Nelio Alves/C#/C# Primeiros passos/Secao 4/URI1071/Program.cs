using System;

namespace URI1071
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, w, soma;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            soma = 0;

            if ( x > y)
            {
                w = x;
                x = y;
                y = w;
            }

            for (int i = (x + 1); y > i; i++)
            {
                if (i % 2 != 0)
                {
                    soma = soma + i;
                }
            }
            Console.WriteLine(soma);
        }
    }
}
