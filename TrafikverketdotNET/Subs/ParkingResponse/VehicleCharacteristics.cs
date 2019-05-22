using System;
using Newtonsoft.Json;

namespace TrafikverketdotNET.Subs.ParkingResponse
{
    public sealed class VehicleCharacteristics
    {
        [JsonProperty("LoadType")] internal String _LoadType { get; set; }
        [JsonProperty("NumberOfSpaces")] internal Byte _NumberOfSpaces { get; set; }
        [JsonProperty("VeichleType")] internal String _VeichleType { get; set; }

        /// <summary>
        /// Typ av last parkeringen är avsedd för, exempelvis fryst gods (refrigeratedGoods).
        /// </summary>
        [JsonIgnore] public String LoadType => _LoadType;
        /// <summary>
        /// Antal platser för fordonstypen inkl släp.
        /// </summary>
        [JsonIgnore] public Byte NumberOfSpaces => _NumberOfSpaces;
        /// <summary>
        /// Fordonstyp parkeringen är avsedd för.
        /// </summary>
        [JsonIgnore] public String VeichleType => _VeichleType;

        internal VehicleCharacteristics() { }
    }
}
