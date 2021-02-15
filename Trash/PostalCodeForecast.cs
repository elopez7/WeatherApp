using System;
using Newtonsoft.Json;

namespace WeatherApp
{
    public class PostalCodeForecast
    {
        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("timestamp")]
        public DateTimeOffset Timestamp { get; set; }

        [JsonProperty("timestampInit")]
        public DateTimeOffset TimestampInit { get; set; }

        [JsonProperty("cldCvrMin")]
        public long CldCvrMin { get; set; }

        [JsonProperty("cldCvrAvg")]
        public long CldCvrAvg { get; set; }

        [JsonProperty("cldCvrMax")]
        public long CldCvrMax { get; set; }

        [JsonProperty("dewPtMin")]
        public double DewPtMin { get; set; }

        [JsonProperty("dewPtAvg")]
        public double DewPtAvg { get; set; }

        [JsonProperty("dewPtMax")]
        public double DewPtMax { get; set; }

        [JsonProperty("feelsLikeMin")]
        public double FeelsLikeMin { get; set; }

        [JsonProperty("feelsLikeAvg")]
        public double FeelsLikeAvg { get; set; }

        [JsonProperty("feelsLikeMax")]
        public double FeelsLikeMax { get; set; }

        [JsonProperty("heatIndexMin")]
        public double HeatIndexMin { get; set; }

        [JsonProperty("heatIndexAvg")]
        public double HeatIndexAvg { get; set; }

        [JsonProperty("heatIndexMax")]
        public double HeatIndexMax { get; set; }

        [JsonProperty("mslPresMin")]
        public double MslPresMin { get; set; }

        [JsonProperty("mslPresAvg")]
        public double MslPresAvg { get; set; }

        [JsonProperty("mslPresMax")]
        public double MslPresMax { get; set; }

        [JsonProperty("precip")]
        public double Precip { get; set; }

        [JsonProperty("precipProb")]
        public long PrecipProb { get; set; }

        [JsonProperty("radSolarMin")]
        public long RadSolarMin { get; set; }

        [JsonProperty("radSolarAvg")]
        public double RadSolarAvg { get; set; }

        [JsonProperty("radSolarMax")]
        public double RadSolarMax { get; set; }

        [JsonProperty("radSolarTot")]
        public double RadSolarTot { get; set; }

        [JsonProperty("relHumMin")]
        public double RelHumMin { get; set; }

        [JsonProperty("relHumAvg")]
        public double RelHumAvg { get; set; }

        [JsonProperty("relHumMax")]
        public double RelHumMax { get; set; }

        [JsonProperty("sfcPresMin")]
        public double SfcPresMin { get; set; }

        [JsonProperty("sfcPresAvg")]
        public double SfcPresAvg { get; set; }

        [JsonProperty("sfcPresMax")]
        public double SfcPresMax { get; set; }

        [JsonProperty("snowfall")]
        public double Snowfall { get; set; }

        [JsonProperty("snowfallProb")]
        public long SnowfallProb { get; set; }

        [JsonProperty("spcHumMin")]
        public double SpcHumMin { get; set; }

        [JsonProperty("spcHumAvg")]
        public double SpcHumAvg { get; set; }

        [JsonProperty("spcHumMax")]
        public double SpcHumMax { get; set; }

        [JsonProperty("tempMin")]
        public double TempMin { get; set; }

        [JsonProperty("tempAvg")]
        public double TempAvg { get; set; }

        [JsonProperty("tempMax")]
        public double TempMax { get; set; }

        [JsonProperty("windChillMin")]
        public double WindChillMin { get; set; }

        [JsonProperty("windChillAvg")]
        public double WindChillAvg { get; set; }

        [JsonProperty("windChillMax")]
        public double WindChillMax { get; set; }

        [JsonProperty("windDirAvg")]
        public long WindDirAvg { get; set; }

        [JsonProperty("windDir80mAvg")]
        public long WindDir80MAvg { get; set; }

        [JsonProperty("windDir100mAvg")]
        public long WindDir100MAvg { get; set; }

        [JsonProperty("windSpdMin")]
        public double WindSpdMin { get; set; }

        [JsonProperty("windSpdAvg")]
        public double WindSpdAvg { get; set; }

        [JsonProperty("windSpdMax")]
        public double WindSpdMax { get; set; }

        [JsonProperty("windSpd80mMin")]
        public double WindSpd80MMin { get; set; }

        [JsonProperty("windSpd80mAvg")]
        public double WindSpd80MAvg { get; set; }

        [JsonProperty("windSpd80mMax")]
        public double WindSpd80MMax { get; set; }

        [JsonProperty("windSpd100mMin")]
        public double WindSpd100MMin { get; set; }

        [JsonProperty("windSpd100mAvg")]
        public double WindSpd100MAvg { get; set; }

        [JsonProperty("windSpd100mMax")]
        public double WindSpd100MMax { get; set; }

        [JsonProperty("wetBulbMin")]
        public double WetBulbMin { get; set; }

        [JsonProperty("wetBulbAvg")]
        public double WetBulbAvg { get; set; }

        [JsonProperty("wetBulbMax")]
        public double WetBulbMax { get; set; }
    }
}