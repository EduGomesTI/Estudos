using System;

namespace URI1015
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2, distancia;

            string[] p1, p2;

            p1 = Console.ReadLine().Split(' ');

            p2 = Console.ReadLine().Split(' ');

            x1 = double.Parse(p1[0]);

            y1 = double.Parse(p1[1]);

            x2 = double.Parse(p2[0]);

            y2 = double.Parse(p2[1]);

            distancia = Math.Sqrt(Math.Pow((x2 - x1), 2.0) + Math.Pow((y2 - y1), 2.0));

            Console.WriteLine(distancia.ToString("F4"));
        }
    }
}
