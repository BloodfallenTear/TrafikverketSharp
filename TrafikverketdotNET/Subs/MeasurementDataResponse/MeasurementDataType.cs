using System;
using Newtonsoft.Json;

namespace TrafikverketdotNET.Subs.MeasurementDataResponse
{
    public sealed class MeasurementDataType
    {
        [JsonProperty("Code")] internal Int32 _Code { get; set; }
        [JsonProperty("Value")] internal String _Value { get; set; }

        /// <summary>
        /// Mätdatatyp. Värde.
        /// </summary>
        [JsonIgnore] public Int32 Code => _Code;
        /// <summary>
        /// Mätdatatyp. Beskrivning.
        /// </summary>
        [JsonIgnore] public String Value => _Value;

        internal MeasurementDataType() { }
    }
}
