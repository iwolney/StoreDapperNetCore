using System.Linq;
using System;
using System.Collections.Generic;
using WolneyStore.Domain.StoreContext.Enums;
using FluentValidator;

namespace WolneyStore.Domain.StoreContext.Entities
{
    public class Order : Notifiable
    {
        private readonly IList<OrderItem> _items;
        private readonly IList<Delivery> _deliveries;
        public Order(Customer customer)
        {
            Customer = customer;
            CreateDate = DateTime.Now;
            Status = EOrderStatus.Created;
            _items = new List<OrderItem>();
            _deliveries = new List<Delivery>();
        }

        public Customer Customer { get; private set; }
        public string Number { get; private set; }
        public DateTime CreateDate { get; private set; }
        public EOrderStatus Status { get; private set; }
        public IReadOnlyCollection<OrderItem> Items => _items.ToArray();
        public IReadOnlyCollection<Delivery> Deliveries => _deliveries.ToArray();

        public void AddItem(Product product, decimal quantity)
        {
            if (quantity > product.QuantityOnHand)
                AddNotification("OrderItem", $"Produto {product.Title} n?o tem {quantity} itens em estoque");

            var item = new OrderItem(product, quantity);
            _items.Add(item);
        }

        // Criar um pedido
        public void Place() 
        {
            // Gera o n?mero do pedido
            Number = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 8).ToUpper();

            // Validar 
            if (_items.Count == 0)
                AddNotification("Order", "Pedido n?o possui itens!");
        }

        // Pagar um pedido
        public void Pay()
        {
            Status = EOrderStatus.Paid;
            
            var delivery = new Delivery(DateTime.Now.AddDays(5));            
            delivery.Ship();

            _deliveries.Add(delivery);
        }

        // Enviar um pedido
        public void Ship()
        {
            // Uma regra de teste (a cada 5 produtos ? uma entrega)
            var deliveries = new List<Delivery>();
            deliveries.Add(new Delivery(DateTime.Now.AddDays(5)));
            var count = 1;

            // Quebra as entregas a cada 5 produtos
            foreach (var item in _items)
            {
                if (count == 5)
                {
                    count = 1;
                    deliveries.Add(new Delivery(DateTime.Now.AddDays(5)));                    
                }
                count++;
            }

            // Envia todas as entregas
            deliveries.ForEach(x => x.Ship());

            // Adiciona as entregas ao pedido
            deliveries.ForEach(x => _deliveries.Add(x));
        }

        // Cancelar um pedido
        public void Cancel()
        {
            Status = EOrderStatus.Canceled;
            _deliveries.ToList().ForEach(x => x.Cancel());
        }
    }
}