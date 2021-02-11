using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.Handlers;
using PaymentContext.Tests.Mocks;

namespace PaymentContext.Tests.Handlers
{
    [TestClass]
    public class SubscriptionsHandlerTest
    {
        public void DeveRetornarErroQuandoDocumentoExiste()
        {
            var handler = new SubscriptionHandler(new FakeStudentRepository());
            var command = new CreateBoletoSubscriptionCommand();
            command.FirstName = "Eduardo";
            command.LastName = "Gomes";
            command.Document = "27114498829";
            command.Email = "edu@gmail.com2";
            command.BarCode = "123456";
            command.BoletoNumber = "123456";
            command.PaymentNumber = "12345";
            command.PaidDate = DateTime.Now;
            command.ExpiredDate = DateTime.Now.AddMonths(1);
            command.Total = 60;
            command.TotalPaid = 60;
            command.PayerDocument = "12345678911";
            command.PayerDocumentType = EDocumentType.CPF;
            command.PayerEmail = "batman@dc.com";



        }
    }
}