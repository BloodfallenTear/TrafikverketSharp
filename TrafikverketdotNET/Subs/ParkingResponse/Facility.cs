using System;
using Newtonsoft.Json;

namespace TrafikverketdotNET.Subs.ParkingResponse
{
    public sealed class Facility
    {
        [JsonProperty("Accessibility")] internal String _Accessibility { get; set; }
        [JsonProperty("Type")] internal String _Type { get; set; }

        /// <summary>
        /// Serviceanläggningens tillgänglighet (https://github.com/BloodfallenTear/Trafikverket.NET/blob/master/docs/Parking.Facility.Accessibility.txt).
        /// </summary>
        [JsonIgnore] public String Accessibility => _Accessibility;
        /// <summary>
        /// Serviceanläggningar vid parkeringen (https://github.com/BloodfallenTear/Trafikverket.NET/blob/master/docs/Parking.Facility.Type.txt).
        /// </summary>
        [JsonIgnore] public String Type => _Type;

        internal Facility() { }
    }

}
