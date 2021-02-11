using System;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
public class PayPalPayment : Payment
{
        public PayPalPayment(string transactionCode, DateTime paidDate, DateTime expiredDate, decimal total, decimal totalPaid, Document document, string payer, Address address, Email email):base( paidDate,  expiredDate,  total,  totalPaid,  document,  payer,  address, email)
        {
            TransactionCode = transactionCode;
        }

        public string TransactionCode { get; private set; }
}
}