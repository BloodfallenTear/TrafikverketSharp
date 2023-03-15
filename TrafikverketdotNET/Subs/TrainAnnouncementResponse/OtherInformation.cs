using System;
using Newtonsoft.Json;

namespace TrafikverketdotNET.Subs.TrainAnnouncementResponse
{
    public sealed class OtherInformation
    {
        [JsonProperty("Code")] internal String _Code { get; set; }
        [JsonProperty("Description")] internal String _Description { get; set; }

        /// <summary>
        /// Kod för övrig annonseringsinformation.
        /// </summary>
        [JsonIgnore] public String Code => _Code;
        /// <summary>
        /// Övrig annonseringsinformation, ex. "Trevlig resa!", "Bakre fordon går låst!", "Ingen påstigning".
        /// </summary>
        [JsonIgnore] public String Description => _Description;

        internal OtherInformation() { }
    }
}
