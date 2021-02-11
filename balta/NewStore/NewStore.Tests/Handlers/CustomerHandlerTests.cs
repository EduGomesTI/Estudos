using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewStore.Domain.StoreContext.Commands.CustomerCommands.Inputs;
using NewStore.Domain.StoreContext.Handlers;
using NewStore.Tests.Mocks;

namespace NewStore.Tests.Handlers
{
    [TestClass]
    public class CustomerHandlerTests
    {
        [TestMethod]
        public void Deve_registrar_customer_quando_command_for_valido()
        {
            var command = new CreateCustomerCommand();
            command.FirstName = "Eduardo";
            command.LastName = "Gomes";
            command.DocumentNumber = "12345678910";
            command.EmailAddress = "edu@gmail.com";
            command.Phone = "98393-5614";

            var handler = new CustomerHandler(new FakeCustomerRepository(), new FakeEmailService());

            var result = handler.Handle(command);

            Assert.AreNotEqual(null, result);

            Assert.AreEqual(true, handler.Valid);
        }
    }
}