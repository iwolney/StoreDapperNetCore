using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolneyStore.Domain.StoreContext.ValueObjects;

namespace WolneyStore.Tests.ValueObjects
{
    [TestClass]
    public class EmailTests
    {
        private Email emailValido;
        private Email emailInvalido;
        public EmailTests()
        {
            emailInvalido = new Email("wolney@.com");
            emailValido = new Email("wolney@msn.com");
        }
        [TestMethod]
        public void Retorna_Valido_Se_Email_Correto()
        {
            Assert.AreEqual(true, emailValido.Valid);
            Assert.AreEqual(0, emailValido.Notifications.Count);
        }
        [TestMethod]
        public void Retorna_Mensagem_Se_Email_Incorreto()
        {
            Assert.AreEqual(false, emailInvalido.Invalid);
            Assert.AreEqual(1, emailInvalido.Notifications.Count);
        }
    }
}
