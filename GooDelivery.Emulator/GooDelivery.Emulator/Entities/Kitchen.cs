using System.Collections.Generic;

namespace GooDelivery.Emulator.Entities
{
    public class Kitchen : Entity
    {
        public string Name { get; set; }

        public ICollection<Ad> Ads { get; set; }
    }
}