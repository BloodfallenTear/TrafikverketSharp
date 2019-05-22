using System;
using Newtonsoft.Json;

namespace TrafikverketdotNET.Subs.ParkingResponse
{
    public sealed class ParkingAccess
    {
        [JsonProperty("SWEREF99TM")] internal String _SWEREF99TM { get; set; }
        [JsonProperty("WGS84")] internal String _WGS84 { get; set; }

        /// <summary>
        /// Parkeringens anslutning som en geometrisk punkt i koordinatsystemet SWEREF99TM.
        /// </summary>
        [JsonIgnore] public String SWEREF99TM => _SWEREF99TM;
        /// <summary>
        /// Parkeringens anslutning som en geometrisk punkt i koordinatsystemet WGS84.
        /// </summary>
        [JsonIgnore] public String WGS84 => _WGS84;

        internal ParkingAccess() { }
    }
}
