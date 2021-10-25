using FluentValidator;
using System;
using WolneyStore.Domain.StoreContext.Enums;

namespace WolneyStore.Domain.StoreContext.Entities
{
    public class Delivery : Notifiable
    {
        public Delivery(DateTime estimateDeliveryDate)
        {
            CreateDate = DateTime.Now;
            EstimateDeliveryDate = estimateDeliveryDate;
            Status = EDeliveryStatus.Waiting;
        }

        public DateTime CreateDate { get; private set; }
        public DateTime EstimateDeliveryDate { get; private set; }
        public EDeliveryStatus Status { get; private set; }

        public void Ship()
        {
            // Se a data estimada de entrega for no passado, não validar
            Status = EDeliveryStatus.Shipped;
        }

        public void Cancel()
        {
            // Se o status estives como entregue, não pode cancelar
            Status = EDeliveryStatus.Canceled;
        }
    }
}