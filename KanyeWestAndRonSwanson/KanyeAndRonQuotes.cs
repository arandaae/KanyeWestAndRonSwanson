using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace KanyeWestAndRonSwanson
{
    public class KanyeAndRonQuotes
    {
        public HttpClient _client;

        public KanyeAndRonQuotes(HttpClient client)
        {
            _client = new HttpClient();
        }

        public string KanyeWest()
        {
            //Kanye Quote
            var kanyeURL = "https://api.kanye.rest";
            var kanyeResponse = _client.GetStringAsync(kanyeURL).Result;
            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            return kanyeQuote;
        }

        public string RonSwanson()
        {
            //Ron Quote
            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            var ronResponse = _client.GetStringAsync(ronURL).Result;
            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            return ronQuote;
        }
    }
}
