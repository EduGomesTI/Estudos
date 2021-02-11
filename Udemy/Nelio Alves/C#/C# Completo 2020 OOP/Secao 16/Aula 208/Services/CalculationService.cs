using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_208.Services
{
    class CalculationService
    {
        public static double Max(double x, double y)
        {
            return (x > y) ? x : y;
        }

        public static double Sum(double x, double y)
        {
            return x + y;
        }

        public static double square(double x)
        {
            return x * x;
        }
    }
}
