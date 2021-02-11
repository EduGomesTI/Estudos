using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio01.Entities.Servies
{
    interface IPaymentService
    {
        public double PaymentTax(double amount, double simpleInterest, double paymentFee);
    }
}
