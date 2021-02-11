namespace Exercicio01.Entities.Servies
{
    class PayPalPaymentService : IPaymentService
    {
        public double SimpleInterest { get; set; }
        public double PaymentFee { get; set; }

        public PayPalPaymentService(double simpleInterest, double paymentFee)
        {
            SimpleInterest = simpleInterest;
            PaymentFee = paymentFee;
        }

        public double PaymentTax(double amount, double simpleInterest, double paymentFee)
        {
            return 
        }
    }
}
