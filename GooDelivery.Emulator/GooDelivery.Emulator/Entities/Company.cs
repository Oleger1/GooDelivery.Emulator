using System.Collections.Generic;

namespace GooDelivery.Emulator.Entities
{
    public class Company : Entity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<Ad> AdsOwned { get; set; }
        
        public ICollection<Ad> AdsExecuting { get; set; }
        
        public ICollection<AdAttendee> AdsAttended { get; set; }

        public string UserId { get; set; }

        public User User { get; set; }
    }
}