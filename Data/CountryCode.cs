using System.Collections.Generic;
using Newtonsoft.Json;

namespace WeatherApp.Data
{
    public class CountryCodes
    {
        [JsonProperty("result")]
        public List<Country> Result { get; set; }
    }

    public class Country
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }
}