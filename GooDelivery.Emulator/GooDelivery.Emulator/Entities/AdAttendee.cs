namespace GooDelivery.Emulator.Entities
{
    public class AdAttendee
    {
        public string AdId { get; set; }

        public Ad Ad { get; set; }

        public string CompanyId { get; set; }
        
        public Company Company { get; set; }
    }
}