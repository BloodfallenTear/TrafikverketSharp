using System;
using Newtonsoft.Json;

namespace TrafikverketdotNET.Subs.TrainAnnouncementResponse
{
    public sealed class Booking
    {
        [JsonProperty("Code")] internal String _Code { get; set; }
        [JsonProperty("Description")] internal String _Description { get; set; }

        /// <summary>
        /// Bokningsinformationskod.
        /// </summary>
        [JsonIgnore] public String Code => _Code;
        /// <summary>
        /// Bokninginformation, ex: "Vagn 4 obokad".
        /// </summary>
        [JsonIgnore] public String Description => _Description;

        internal Booking() { }
    }
}
