using System;
using System.Collections.Generic;

namespace GooDelivery.Emulator.Entities
{
    public class DeliveryUnit : Entity
    {
        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public TimeSpan Time { get; set; }

        public string AdId { get; set; }

        public Ad Ad { get; set; }
        
        public ICollection<Delivery> Deliveries { get; set; }
    }
}