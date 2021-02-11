using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewStore.Domain.StoreContext.Commands.CustomerCommands.Inputs;

namespace NewStore.Tests.Commands
{
    [TestClass]
    public class CreateCustomerCommandTests
    {
        [TestMethod]
        public void Create_Customer_precisa_Validar()
        {
            var command = new CreateCustomerCommand();
            command.FirstName = "Eduardo";
            command.LastName = "Gomes";
            command.DocumentNumber = "12345678910";
            command.EmailAddress = "edu@gmail.com";
            command.Phone = "98393-5614";

            Assert.AreEqual(true, command.Valid());
        }
    }
}