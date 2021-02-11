using System;

namespace URI1046
{
    class Program
    {
        static void Main(string[] args)
        {
            int inicial, final, total;
            string[] horas;

            horas = Console.ReadLine().Split(' ');
            inicial = int.Parse(horas[0]);
            final = int.Parse(horas[1]);

            if (inicial == 0 && final == 0)
            {
                total = 24;
            }
            else if (inicial > final)
            {
                total = final + (24 - inicial);
            }
            else
            {
                total = final - inicial;
            }
            Console.WriteLine("O JOGO DUROU " + total + " HORA(S)");
        }
    }
}
