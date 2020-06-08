using System.Net.Http;
using System.Threading.Tasks;
using GooDelivery.Emulator.Entities;

namespace GooDelivery.Emulator
{
    public class Repository
    {
        private readonly string _apiBaseUrl = "https://localhost:44301/";

        public async Task<ViewResponse> GetDelivery(string id)
        {
            var result = await SendRequest(HttpMethod.Get, $"{_apiBaseUrl}api/Delivery/{id}");

            return result;
        }

        public async Task<ViewResponse> ConfirmDelivery(string id)
        {
            var result = await SendRequest(HttpMethod.Post, $"{_apiBaseUrl}/Account/ConfirmDelivery/{id}");

            return result;
        }

        private async Task<ViewResponse> SendRequest(HttpMethod httpMethod, string url)
        {
            var httpRequestMessage = new HttpRequestMessage(httpMethod, url);
            ViewResponse result;

            using (var client = new HttpClient())
            {
                var httpResponseMessage = await client.SendAsync(httpRequestMessage);
                var httpResponseContent = await httpResponseMessage.Content.ReadAsStringAsync();

                result = new ViewResponse
                {
                    Content = httpResponseContent,
                    StatusCode = httpResponseMessage.StatusCode
                };
            }

            return result;
        }
    }
}