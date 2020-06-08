namespace GooDelivery.Emulator.Entities
{
    public class User : Entity
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string PasswordHash { get; set; }

        public string RoleId { get; set; }

        public Role Role { get; set; }

        public Company Company { get; set; }
    }
}