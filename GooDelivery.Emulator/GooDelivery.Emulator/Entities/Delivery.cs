using System;
using GooDelivery.Emulator.Entities.Enums;

namespace GooDelivery.Emulator.Entities
{
    public class Delivery : Entity
    {
        public DateTime? DateTime { get; set; }

        public string Comment { get; set; }

        public DeliveryStatus Status { get; set; }

        public string DeliveryUnitId { get; set; }

        public DeliveryUnit DeliveryUnit { get; set; }
    }
}