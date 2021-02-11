using System;

namespace URI1036
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, a, b, c, delta;
            string[] valores;

            valores = Console.ReadLine().Split(' ');


            a = double.Parse(valores[0]);
            b = double.Parse(valores[1]);
            c = double.Parse(valores[2]);

            if (a == 0)
            {
                Console.WriteLine("Impossivel calcular");
             }
            else
            {
                delta = Math.Pow(b, 2.0) - 4 * a * c;
                if (delta < 0)
                {
                    Console.WriteLine("Impossivel calcular");
                }
                else
                {
                    x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

                    Console.WriteLine("R1 = " + x1.ToString("F5"));
                    Console.WriteLine("R2 = " + x2.ToString("F5"));
                }
            }
        }
    }
}
