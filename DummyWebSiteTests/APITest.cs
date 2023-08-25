using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DummyWebSiteTests
{
    [TestClass]
    public class APITest
    {

        [TestMethod]
        public void VerifyApiResponseProperty()
        {
            const string PROPERTY = "Authentication & Authorization";
            var client = new RestClient("https://api.publicapis.org");
            var request = new RestRequest("/entries", Method.Get);
            var response = client.Execute(request);
            if (response.IsSuccessful)
            {
                JObject jsonResponse = JObject.Parse(response.Content);
                JArray entries = (JArray)jsonResponse["entries"];
                List<JToken> authAndAuthEntries = entries.Where(entry =>
                    entry["Category"] != null && entry["Category"].ToString() == PROPERTY).ToList();
                // count
                Console.WriteLine("Number of entries with Authentication & Authorization "+authAndAuthEntries.Count);
               Assert.AreEqual(authAndAuthEntries.Count, 7,"The number of entries is not the expected");
                // print found objects to console
                foreach (var entry in authAndAuthEntries)
                {
                    Console.WriteLine(entry);
                }
            }
            else
            {
                Console.WriteLine("Error: " + response.ErrorMessage);
            }
        }
    }
}
