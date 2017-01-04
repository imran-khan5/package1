using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Package1.Core.Package.Proxy.Interfaces;

namespace Package1.Core.Package.Proxy
{
    public class BundleProxy : IBundleProxy
    {
        public async Task<Models.Package> GetBundleDetails()
        {
            var client = new HttpClient();
            var url = string.Format("http://api.broadbandchoices.co.uk/api/v2/bundles?Authorization=eb45afb3-a7c2-4d6d-a62a-bb9a29a4fb2e");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await client.GetAsync(url);
            var result = await response.Content.ReadAsStringAsync();
            var rootObject = await Deserialize<Models.Package>(result);

            return rootObject;
        }

        async Task<T> Deserialize<T>(string json)
        {
            var value = await JsonConvert.DeserializeObjectAsync<T>(json);
            return value;
        }

    }
}
