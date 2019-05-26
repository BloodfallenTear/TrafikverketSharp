using System;
using Newtonsoft.Json;

namespace TrafikverketdotNET.Subs.MeasurementDataResponse
{
    public sealed class Direction
    {
        [JsonProperty("Code")] internal Int32 _Code { get; set; }
        [JsonProperty("Value")] internal String _Value { get; set; }

        /// <summary>
        /// Riktning. Värde.Fältet är nyckel för objektet.
        /// </summary>
        [JsonIgnore] public Int32 Code => _Code;
        /// <summary>
        /// Riktning. Beskrivning. Fältet är nyckel för objektet.
        /// </summary>
        [JsonIgnore] public String Value => _Value;

        internal Direction() { }
    }
}
