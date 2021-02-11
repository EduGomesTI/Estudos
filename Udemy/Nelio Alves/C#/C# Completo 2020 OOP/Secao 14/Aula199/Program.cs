using Aula199.Model.Entities;
using System;
using Aula199.Model.Enums;

namespace Aula199
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape circle = new Circle() {Radius = 2.0, Color = Color.White };
            IShape rectangle = new Rectangle() {Width = 3.5, Height = 4.2, Color = Color.Black };

            Console.WriteLine(circle);
            Console.WriteLine();
            Console.WriteLine(rectangle);
        }
    }
}
