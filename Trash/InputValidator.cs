using System;
using WeatherApp.Data;

namespace WeatherApp
{
    public class InputValidator
    {
        public bool Validate(Location location)
        {
            return !string.IsNullOrEmpty(location.CityName);
        }
    }
}