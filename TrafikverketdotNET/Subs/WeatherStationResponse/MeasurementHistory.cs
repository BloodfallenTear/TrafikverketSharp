using System;
using Newtonsoft.Json;

namespace TrafikverketdotNET.Subs.WeatherStationResponse
{
    public sealed class MeasurementHistory
    {
        [JsonProperty("Air")] internal Air _Air { get; set; }
        [JsonProperty("MeasureTime")] internal DateTime _MeasureTime { get; set; }
        [JsonProperty("Precipitation")] internal Precipitation _Precipitation { get; set; }
        [JsonProperty("Road")] internal Road _Road { get; set; }
        [JsonProperty("Wind")] internal Wind _Wind { get; set; }

        [JsonIgnore] public Air Air => _Air;
        /// <summary>
        /// Tidpunkt då mätvärdena uppdaterades.
        /// </summary>
        [JsonIgnore] public DateTime MeasureTime => _MeasureTime;
        [JsonIgnore] public Precipitation Precipitation => _Precipitation;
        [JsonIgnore] public Road Road => _Road;
        [JsonIgnore] public Wind Wind => _Wind;

        internal MeasurementHistory() { }
    }
}
