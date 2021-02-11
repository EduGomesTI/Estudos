using System;

namespace URI1011
{
    class Program
    {
        static void Main(string[] args)
        {
            double R, Volume;

            R = double.Parse(Console.ReadLine());

            Volume = (double) (4.0 / 3.0) * 3.14159 * Math.Pow(R, 3.0);

            Console.WriteLine("VOLUME = " + Volume.ToString("F3"));
        }
    }
}
