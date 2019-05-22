using System;
using Newtonsoft.Json;

namespace TrafikverketdotNET.Subs.ParkingResponse
{
    public sealed class Equipment
    {
        [JsonProperty("Accessibility")] internal String _Accessibility { get; set; }
        [JsonProperty("Type")] internal String _Type { get; set; }

        /// <summary>
        /// Utrustningens tillgänglighet (https://github.com/BloodfallenTear/Trafikverket.NET/blob/master/docs/Parking.Equipment.Accessibility.txt).
        /// </summary>
        [JsonIgnore] public String Accessibility => _Accessibility;
        /// <summary>
        /// Typ av utrustning (https://github.com/BloodfallenTear/Trafikverket.NET/blob/master/docs/Parking.Equipment.Type.txt).
        /// </summary>
        [JsonIgnore] public String Type => _Type;

        internal Equipment() { }
    }
}
