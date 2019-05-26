using System;
using Newtonsoft.Json;

namespace TrafikverketdotNET.Subs.RoadDataResponse
{
    public sealed class Winter2003
    {
        [JsonProperty("Code")] internal Int32 _Code { get; set; }
        [JsonProperty("Value")] internal String _Value { get; set; }

        /// <summary>
        /// Värde. 
        /// </summary>
        [JsonIgnore] public Int32 Code => _Code;
        /// <summary>
        /// Beskrivning. 
        /// </summary>
        [JsonIgnore] public String Value => _Value;

        internal Winter2003() { }
    }
}
