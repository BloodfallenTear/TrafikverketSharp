using System;
using Newtonsoft.Json;

namespace TrafikverketdotNET.Subs.RoadDataResponse
{
    public sealed class RoadOwner
    {
        [JsonProperty("Code")] internal Int32 _Code { get; set; }
        [JsonProperty("Value")] internal String _Value { get; set; }

        /// <summary>
        /// Den som är ansvarig för väghållningen.
        /// </summary>
        [JsonIgnore] public Int32 Code => _Code;
        /// <summary>
        /// Den som är ansvarig för väghållningen. Beskrivning. 
        /// </summary>
        [JsonIgnore] public String Value => _Value;

        internal RoadOwner() { }
    }
}
