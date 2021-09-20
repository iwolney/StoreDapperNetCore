using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolneyStore.Domain.StoreContext.ValueObjects;

namespace WolneyStore.Tests.ValueObjects
{
    [TestClass]
    public class NameTests
    {
        private Name nameValido;
        private Name nameInvalido;

        public NameTests()
        {
            nameInvalido = new Name("W", "");
            nameValido = new Name("Wolney", "Rodrigues");
        }

        [TestMethod]
        public void Retona_Valido_Se_Nome_Correto()
        {
            Assert.AreEqual(true, nameValido.Valid);
            Assert.AreEqual(0, nameValido.Notifications.Count);
        }

        [TestMethod]
        public void Retona_Notificacoes_Se_Nome_Incorreto()
        {
            Assert.AreEqual(false, nameInvalido.Invalid);
            Assert.AreEqual(1, nameInvalido.Notifications.Count);
        }
    }
}
