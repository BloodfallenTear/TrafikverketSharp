using System;
using Newtonsoft.Json;

namespace TrafikverketdotNET.Subs.TravelTimeRouteResponse
{
    public sealed class Geometry
    {
        [JsonProperty("ModifiedTime")] internal DateTime _ModifiedTime { get; set; }
        [JsonProperty("SWEREF99TM")] internal String _SWEREF99TM { get; set; }
        [JsonProperty("WGS84")] internal String _WGS84 { get; set; }

        /// <summary>
        /// Tidpunkt då elementet ändrades.
        /// </summary>
        [JsonIgnore] public DateTime ModifiedTime => _ModifiedTime;
        /// <summary>
        /// Geometrisk punkt i koordinatsystem SWEREF99TM.
        /// </summary>
        [JsonIgnore] public String SWEREF99TM => _SWEREF99TM;
        /// <summary>
        /// Geometrisk punkt i koordinatsystem WGS84
        /// </summary>
        [JsonIgnore] public String WGS84 => _WGS84;

        internal Geometry() { }
    }
}
