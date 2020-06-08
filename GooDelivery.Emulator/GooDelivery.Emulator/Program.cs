using System;
using System.Net;
using System.Threading.Tasks;
using GooDelivery.Emulator.Entities;
using Newtonsoft.Json;

namespace GooDelivery.Emulator
{
    class Program
    {
        private static readonly string _emulatorAddress = "Yuliia Chyhyryna str, 13/1";
        private static Repository _repository;

        static async Task Main(string[] args)
        {
            _repository = new Repository();

            Console.WriteLine("Please enter the Id of delivery to confirm: ");
            var id = Console.ReadLine();

            var deliveryResponse = await _repository.GetDelivery(id);
            if (deliveryResponse.StatusCode == HttpStatusCode.NotFound)
            {
                Console.WriteLine($"There is no delivery with id {id}");
                Console.ReadKey();
                return;
            }

            var delivery = JsonConvert.DeserializeObject<Delivery>(deliveryResponse.Content);
            if (delivery.DeliveryUnit.Ad.Address.Trim() != _emulatorAddress)
            {
                Console.WriteLine($"The delivery address does not match the emulator address");
                Console.ReadKey();
                return;
            }

            var confirmDeliveryResponse = await _repository.ConfirmDelivery(id);
            if (confirmDeliveryResponse.StatusCode == HttpStatusCode.OK)
            {
                Console.WriteLine($"The delivery was confirmed successfully");
                Console.ReadKey();
                return;
            }

            Console.WriteLine($"An unknown error occured"); 
            Console.ReadKey();
        }
    }
}
