using System;
using Newtonsoft.Json;

namespace WeatherApp
{
    public class PostalCodeAstronomicalData
    {
        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("timestamp")]
        public DateTimeOffset Timestamp { get; set; }

        [JsonProperty("sunrise")]
        public DateTimeOffset Sunrise { get; set; }

        [JsonProperty("sun_transit_time")]
        public DateTimeOffset SunTransitTime { get; set; }

        [JsonProperty("sunset")]
        public DateTimeOffset Sunset { get; set; }

        [JsonProperty("sun_distance")]
        public long SunDistance { get; set; }

        [JsonProperty("sun_diameter")]
        public double SunDiameter { get; set; }

        [JsonProperty("civil_twilight_begin")]
        public DateTimeOffset CivilTwilightBegin { get; set; }

        [JsonProperty("civil_twilight_end")]
        public DateTimeOffset CivilTwilightEnd { get; set; }

        [JsonProperty("nautical_twilight_begin")]
        public DateTimeOffset NauticalTwilightBegin { get; set; }

        [JsonProperty("nautical_twilight_end")]
        public DateTimeOffset NauticalTwilightEnd { get; set; }

        [JsonProperty("astronomical_twilight_begin")]
        public DateTimeOffset AstronomicalTwilightBegin { get; set; }

        [JsonProperty("astronomical_twilight_end")]
        public DateTimeOffset AstronomicalTwilightEnd { get; set; }

        [JsonProperty("moonrise")]
        public DateTimeOffset Moonrise { get; set; }

        [JsonProperty("moonset")]
        public DateTimeOffset Moonset { get; set; }

        [JsonProperty("moon_distance")]
        public long MoonDistance { get; set; }

        [JsonProperty("moon_diameter")]
        public double MoonDiameter { get; set; }

        [JsonProperty("moon_phase")]
        public string MoonPhase { get; set; }

        [JsonProperty("moon_illumination")]
        public double MoonIllumination { get; set; }

        [JsonProperty("moon_age")]
        public double MoonAge { get; set; }
    }
}