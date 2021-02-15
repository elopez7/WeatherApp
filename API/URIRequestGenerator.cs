using WeatherApp.Data;

namespace WeatherApp.API
{
    public class URIRequestGenerator
    {
        public string GenerateRequestUri(string uri, Location location)
        {
            var requestUri = uri;
            requestUri += $"?q={location.CityName}";
            requestUri += AppendCountryCode($"{location.CountryTwoDigitCode}");
            requestUri += "&units=metric";
            requestUri += $"&APPID={Constants.OpenWeatherMapApiKey}";
            return requestUri;
        }

        private string AppendCountryCode(string countryCode)
        {
            return string.IsNullOrEmpty(countryCode) ? string.Empty : $",{countryCode}";
        }
    }
}