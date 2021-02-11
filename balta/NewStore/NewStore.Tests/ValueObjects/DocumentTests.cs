using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewStore.Domain.StoreContext.ValueObjects;

namespace NewStore.Tests.ValueObjects
{
    [TestClass]
    public class DocumentTests{ 
  
        [TestMethod]
        public void Deve_retornar_uma_notificacao_quando_documento_nao_for_valido()
        {
            var document = new Document("123456789");
            Assert.AreEqual(false, document.Valid);
            Assert.AreNotEqual(0, document.Notifications.Count);
        }
        
         [TestMethod]
        public void Deve_retornar_uma_notificacao_quando_documento_for_valido()
        {
            var document = new Document("12345678912");
            Assert.AreEqual(true, document.Valid);
            Assert.AreEqual(0, document.Notifications.Count);
        }
    }
}