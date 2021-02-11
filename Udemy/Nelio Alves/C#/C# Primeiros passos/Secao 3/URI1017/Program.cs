using System;

namespace URI1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempoGasto, velocidadeMedia, distancia;
            double consumo;

            tempoGasto = int.Parse(Console.ReadLine());

            velocidadeMedia = int.Parse(Console.ReadLine());

            distancia = tempoGasto * velocidadeMedia;

            consumo = (double) distancia / 12;

            Console.WriteLine(consumo.ToString("F3"));
        }
    }
}
