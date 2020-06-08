using System.Collections.Generic;

namespace GooDelivery.Emulator.Entities
{
    public class Role : Entity
    {
        public string Name { get; set; }

        public ICollection<User> Users { get; set; }
    }
}