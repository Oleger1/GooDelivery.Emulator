namespace GooDelivery.Emulator.Entities
{
    public class Image : Entity
    {
        public string Url { get; set; }

        public string AdId { get; set; }

        public Ad Ad { get; set; }
    }
}