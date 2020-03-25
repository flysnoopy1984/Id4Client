using IdentityModel.Client;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Id4Client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = new HttpClient();
            var disco = await client.GetDiscoveryDocumentAsync("http://localhost:5000");
            if (disco.IsError)
            {
                Console.WriteLine(disco.Error);
                return;
            }

            Console.ReadLine();
        }

        
    }
}
