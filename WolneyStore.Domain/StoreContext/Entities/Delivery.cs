using System;
using WolneyStore.Domain.StoreContext.Enums;

namespace WolneyStore.Domain.StoreContext.Entities
{
    public class Delivery
    {
        public Delivery(DateTime estimateDeliveryDate)
        {
            CreateDate = DateTime.Now;
            EstimateDeliveryDate = estimateDeliveryDate;
            Status = EDeliveyStatus.Waiting;
        }

        public DateTime CreateDate { get; private set; }
        public DateTime EstimateDeliveryDate { get; private set; }
        public EDeliveyStatus Status { get; private set; }
    }
}