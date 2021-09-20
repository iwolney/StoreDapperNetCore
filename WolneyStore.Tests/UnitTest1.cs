using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolneyStore.Domain.StoreContext.Entities;
using WolneyStore.Domain.StoreContext.ValueObjects;

namespace WolneyStore.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var name = new Name("Wolney", "Rodrigues");
            var document = new Document("132165465987");
            var email = new Email("wolney@msn.com");
            var customer = new Customer(name, document, email, "1199989844");

            var mouse = new Product("Mouse", "Rato", "image.png", 59.90M, 10);
            var teclado = new Product("Teclado", "Teclado", "image.png", 159.90M, 10);
            var impressora = new Product("Impressora", "Impressora", "image.png", 359.90M, 10);
            var cadeira = new Product("Cadeira", "Cadeira", "image.png", 659.90M, 10);
            
            var order = new Order(customer);
            //order.AddItem(new OrderItem(mouse, 2));
            //order.AddItem(new OrderItem(teclado, 3));
            //order.AddItem(new OrderItem(impressora, 1));
            //order.AddItem(new OrderItem(cadeira, 1));

            order.Place();

            // Verificar se o pedido é válido
            var valid = order.Invalid;

            // Simular o pagamento
            order.Pay();

            // Simular Envio
            order.Ship();

            // Simular Cancelamento 
            order.Cancel();
        }
    }
}
