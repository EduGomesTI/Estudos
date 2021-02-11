using System;

namespace URI1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int distancia;
            double combustivelGasto, consumoMedio;

            distancia = int.Parse(Console.ReadLine());

            combustivelGasto = double.Parse(Console.ReadLine());

            consumoMedio = distancia / combustivelGasto;

            Console.WriteLine(consumoMedio.ToString("F3") + " km/l");
        }
    }
}
