using KanyeAndRonSwansonAPI;
using Newtonsoft.Json.Linq;
using static System.Net.WebRequestMethods;

var client = new HttpClient();

var quote = new QuoteGenerator(client);

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Kanye: {quote.KanyeQuote()}");
    Console.WriteLine($"Ron: {quote.RonQuote()}");
}