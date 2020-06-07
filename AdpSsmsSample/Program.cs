using System;
using System.Threading.Tasks;

namespace AdpSsmsSample
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            var client = new AdpSmsService.JaxRpcMessagingServiceClient();
            var response = await client.sendAsync("username", "password", "", new[] { "98999999999" }, null, null, new[] { "98999999999" }, 1, 2,
                true, DateTime.Now, "This is a test messsage");

            Console.WriteLine($"Result: {response.sendReturn.status} - {response.sendReturn.id}");
            Console.Read();
        }
    }
}