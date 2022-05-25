using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace KanyeWestAndRonSwanson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            var quote = new KanyeAndRonQuotes(client);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Kanye West: {quote.KanyeWest()}");
                Console.WriteLine();
                Console.WriteLine($"Ron Swanson: {quote.RonSwanson()}");
                Console.WriteLine();
            }
           
        }
    }
}
