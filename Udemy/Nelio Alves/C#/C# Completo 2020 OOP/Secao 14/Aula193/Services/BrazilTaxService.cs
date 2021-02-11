using System;
using System.Collections.Generic;
using System.Text;

namespace Aula193.Services
{
    class BrazilTaxService
    {
        public double Tax(double ammount)
        {
            return (ammount <= 100.0) ? ammount * 0.2 : ammount * 0.15;
        }
    }
}
