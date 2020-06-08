using System.Net;

namespace GooDelivery.Emulator.Entities
{
    public class ViewResponse
    {
        public HttpStatusCode StatusCode { get; set; }

        public string Content { get; set; }
    }
}
