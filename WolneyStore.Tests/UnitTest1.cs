using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolneyStore.Domain.StoreContext.Entities;

namespace WolneyStore.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var customer = new Customer(
                "Wolney", "Rodrigues", "12345678910", "wolney@msn.com", "1199999848", "Rua 1");

            var order = new Order(customer);
            
            
        }
    }
}
