using System.Collections.Generic;
using GooDelivery.Emulator.Entities.Enums;

namespace GooDelivery.Emulator.Entities
{
    public class Ad : Entity
    {
        public string Name { get; set; }

        public string OwnerId { get; set; }

        public Company Owner { get; set; }
        
        public string ExecutorId { get; set; }

        public Company Executor { get; set; }

        public ICollection<AdAttendee> Attendees { get; set; }

        public ICollection<Image> Images { get; set; }

        public string Address { get; set; }

        public ICollection<DeliveryUnit> DeliveryUnits { get; set; }

        public AdStatus Status { get; set; }

        public string KitchenId { get; set; }
        
        public Kitchen Kitchen { get; set; }
    }
}