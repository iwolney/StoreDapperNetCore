using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolneyStore.Domain.StoreContext.ValueObjects;

namespace WolneyStore.Tests.ValueObjects
{
    [TestClass]
    public class DocumentTests
    {
        private Document validDocument;
        private Document invalidDocument;
        public DocumentTests()
        {
            validDocument = new Document("12345678910");
            invalidDocument = new Document("123456789");
        }

        [TestMethod]
        public void Retorna_Validacoes_Se_Documento_Invalido()
        {
            Assert.AreEqual(false, invalidDocument.Invalid);
            Assert.AreEqual(1, invalidDocument.Notifications.Count);
        }

        [TestMethod]
        public void Retorna_Validacoes_Se_Documento_Valido()
        {
            Assert.AreEqual(true, validDocument.Valid);
            Assert.AreEqual(0, validDocument.Notifications.Count);
        }
    }
}
