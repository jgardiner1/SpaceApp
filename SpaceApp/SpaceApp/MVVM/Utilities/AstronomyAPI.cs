using System;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Text;
using System.Net.Http.Headers;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Windows;

namespace SpaceApp.MVVM.Utilities
{
    internal class AstronomyAPI
    {
        public static IConfiguration Configuration { get; private set; }

        private string _apiID;
        private string _apiSecret;
        private string _baseURL = "https://api.astronomyapi.com/api/v2/";

        public AstronomyAPI()
        {
            // Configure the configuration builder
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            Configuration = builder.Build();

            // Access configuration settings
            var credentials = Configuration.GetSection("AstronomyAPICredentials").Get<AstronomyAPICredentials>();

            // Do something with the credentials
            _apiID = credentials.ApiID;
            _apiSecret = credentials.ApiSecret;
        }
        public async Task<string> GetPlanetaryData()
        {
            using (HttpClient client = new HttpClient())
            {
                // Create the Basic Authentication string
                var creds = $"{_apiID}:{_apiSecret}";
                var base64Credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes(creds));

                // Set the Authorization header
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", base64Credentials);

                // Build the request URL with the query parameter
                var requestUrl = $"{_baseURL}bodies/positions?longitude=-84.39733&latitude=33.775867&elevation=1&from_date=2024-08-05&to_date=2024-08-05&time=14%3A31%3A52";

                Console.Write($"URL: {requestUrl} ----");

                HttpResponseMessage response = await client.GetAsync(requestUrl);

                // Ensure successful status code
                if (!response.IsSuccessStatusCode)
                {
                    // Log or handle the error
                    throw new Exception($"API call failed with status code {response.StatusCode} and reason {response.ReasonPhrase}");
                }

                string jsonResponse = await response.Content.ReadAsStringAsync();
                JObject data = JObject.Parse(jsonResponse);
                return data.ToString();
            }
        }
    }
}
