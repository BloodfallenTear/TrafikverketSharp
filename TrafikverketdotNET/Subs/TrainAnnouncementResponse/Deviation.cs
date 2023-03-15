using System;
using Newtonsoft.Json;

namespace TrafikverketdotNET.Subs.TrainAnnouncementResponse
{
    public sealed class Deviation
    {
        [JsonProperty("Code")] internal String _Code { get; set; }
        [JsonProperty("Description")] internal String _Description { get; set; }

        /// <summary>
        /// Full Orsakskod.
        /// </summary>
        [JsonIgnore] public String Code => _Code;
        /// <summary>
        /// Eventuell avvikelse, ex: "Buss ersätter", "Spårändrat", "Kort tåg", "Ej servering" o.s.v.
        /// </summary>
        [JsonIgnore] public String Description => _Description;

        internal Deviation() { }
    }
}
