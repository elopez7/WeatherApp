using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WeatherApp.Data;
using Newtonsoft.Json;

namespace WeatherApp.API
{
    public class APIHelper
    {
        private readonly HttpClient Client;

        public APIHelper()
        {
            Client = new HttpClient();
        }

        public async Task<WeatherData> GetWeatherData(string query)
        {
            using var response = await Client.GetAsync(query);
            if (!response.IsSuccessStatusCode) throw new Exception(response.ReasonPhrase);
            WeatherData weatherData = null;
            weatherData = await response.Content.ReadFromJsonAsync<WeatherData>();
            return weatherData;
        }

        public async Task<CountryCodes> GetCountryCode(string query)
        {
            using var response = await Client.GetAsync(query);
            if (!response.IsSuccessStatusCode) throw new Exception(response.ReasonPhrase);
            CountryCodes countryCode = null;
            countryCode = await response.Content.ReadFromJsonAsync<CountryCodes>();
            return countryCode;
        }
    }
}