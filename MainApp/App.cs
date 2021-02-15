using System;
using System.Linq;
using WeatherApp.Data;
using WeatherApp.API;
using WeatherApp.IO;

namespace WeatherApp.MainApp
{
    public class App
    {
        readonly APIHelper apiHelper;
        readonly URIRequestGenerator requestGenerator;
        readonly StandardUserInput standardInput;
        private Location location;
        private CountryCodes countryCodes;
        private WeatherData weatherData;

        public App()
        {
            apiHelper = new APIHelper();
            requestGenerator = new URIRequestGenerator();
            standardInput = new StandardUserInput();
        }

        public void RunApp()
        {
            Initialize();
            InitializeLocation();
            DownloadWeatherResults();
            DisplayWeatherResults();
        }

        private void Initialize()
        {
            StandardMessages.WelcomeMessage();
            countryCodes = apiHelper.GetCountryCode(Constants.PrintfulCountryCodeURI).Result;
            StandardMessages.InitializationCompletedMessage();
        }

        private void InitializeLocation()
        {
            location = new Location(CityName(), CountryName());
        }
        
        private string CityName()
        {
            StandardMessages.CityNamePromptMessage();
            string cityName = standardInput.GetInput();
            return cityName;
        }

        private string CountryName()
        {
            StandardMessages.CountryNamePromptMessage();
            string countryName = standardInput.GetInput();
            return countryName;
        }
        
        private void DownloadWeatherResults()
        {
            FindCountryCode();
            weatherData = apiHelper.GetWeatherData(requestGenerator.GenerateRequestUri(Constants.OpenWeatherMapURI, location)).Result;
        }

        private void FindCountryCode()
        {
            foreach (var country in countryCodes.Result.Where(country => string.Equals(location.CountryName, country.Name, StringComparison.OrdinalIgnoreCase)))
            {
                location.CountryTwoDigitCode = country.Code;
                return;
            }
        }

        private void DisplayWeatherResults()
        {
            Console.WriteLine(WeatherDownloadedData());
        }
        
        private string WeatherDownloadedData()
        {
            var weatherResults = "Here are your results\n";
            weatherResults += $"City: {weatherData.Name}\n";
            weatherResults += $"Country: {weatherData.Sys.Country}\n";
            weatherResults += $"Temp: {weatherData.Main.Temp}\n";
            weatherResults += $"Feels like: {weatherData.Main.FeelsLike}\n";
            weatherResults += $"Humidity: {weatherData.Main.Humidity}\n";
            weatherResults += $"Description: {weatherData.Weather[0].Description}\n";
            weatherResults += $"Description: {weatherData.Weather[0].Icon}\n";
            return weatherResults;
        }
    }
}