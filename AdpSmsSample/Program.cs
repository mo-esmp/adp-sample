using AdpSmsService;
using System;
using System.Threading.Tasks;

namespace AdpSmsSample
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            var x = new System.Xml.Serialization.XmlSerializer(typeof(MyClass));

            var client = new JaxRpcMessagingServiceClient();
            var response = await client.sendAsync("username", "password", "", new[] { "98999999999" }, null, null, new[] { "98999999999" }, 1, 2,
                true, DateTime.Now, "This is a test messsage");

            Console.WriteLine($"Result: {response.sendReturn.status} - {response.sendReturn.id}");
            Console.Read();
        }
    }

    public class MyClass
    {
        public int Value;
    }
}