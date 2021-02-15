using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WeatherApp
{
    public class PostalCodeHistory
    {
        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("timestamp")]
        public DateTimeOffset Timestamp { get; set; }

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
        public long HeatIndexAvg { get; set; }

        [JsonProperty("heatIndexMax")]
        public long HeatIndexMax { get; set; }

        [JsonProperty("mslPresMin")]
        public double MslPresMin { get; set; }

        [JsonProperty("mslPresAvg")]
        public long MslPresAvg { get; set; }

        [JsonProperty("mslPresMax")]
        public double MslPresMax { get; set; }

        [JsonProperty("precip")]
        public long Precip { get; set; }

        [JsonProperty("presTendMin")]
        public double PresTendMin { get; set; }

        [JsonProperty("presTendAvg")]
        public double PresTendAvg { get; set; }

        [JsonProperty("presTendMax")]
        public long PresTendMax { get; set; }

        [JsonProperty("radSolarMin")]
        public long RadSolarMin { get; set; }

        [JsonProperty("radSolarAvg")]
        public double RadSolarAvg { get; set; }

        [JsonProperty("radSolarMax")]
        public long RadSolarMax { get; set; }

        [JsonProperty("radSolarTot")]
        public long RadSolarTot { get; set; }

        [JsonProperty("relHumMin")]
        public double RelHumMin { get; set; }

        [JsonProperty("relHumAvg")]
        public double RelHumAvg { get; set; }

        [JsonProperty("relHumMax")]
        public double RelHumMax { get; set; }

        [JsonProperty("sfcPresMin")]
        public double SfcPresMin { get; set; }

        [JsonProperty("sfcPresAvg")]
        public long SfcPresAvg { get; set; }

        [JsonProperty("sfcPresMax")]
        public double SfcPresMax { get; set; }

        [JsonProperty("snowDepth")]
        public long SnowDepth { get; set; }

        [JsonProperty("snowfall")]
        public long Snowfall { get; set; }

        [JsonProperty("spcHumMin")]
        public long SpcHumMin { get; set; }

        [JsonProperty("spcHumAvg")]
        public long SpcHumAvg { get; set; }

        [JsonProperty("spcHumMax")]
        public double SpcHumMax { get; set; }

        [JsonProperty("tempMin")]
        public double TempMin { get; set; }

        [JsonProperty("tempAvg")]
        public long TempAvg { get; set; }

        [JsonProperty("tempMax")]
        public long TempMax { get; set; }

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
        public long WindSpd80MAvg { get; set; }

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
        public long WetBulbMax { get; set; }
    }
}