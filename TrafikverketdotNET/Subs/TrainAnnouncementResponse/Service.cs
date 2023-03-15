using System;
using Newtonsoft.Json;

namespace TrafikverketdotNET.Subs.TrainAnnouncementResponse
{
    public sealed class Service
    {
        [JsonProperty("Code")] internal String _Code { get; set; }
        [JsonProperty("Description")] internal String _Description { get; set; }

        /// <summary>
        /// Servicekod.
        /// </summary>
        [JsonIgnore] public String Code => _Code;
        /// <summary>
        /// Lite extra utöver produktinformation, ex "Bistro", "Sov-och liggv".
        /// </summary>
        [JsonIgnore] public String Description => _Description;

        internal Service() { }
    }
}
