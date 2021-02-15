namespace WeatherApp.Data
{
    public class Location
    {
        public string CityName { get; }
        public string CountryName { get; }
        public string CountryTwoDigitCode { get; set; }
        private const int CountryCodeLength = 2;

        public Location(string city, string country)
        {
            CityName = city;
            CountryName = country;
        }
    }
}