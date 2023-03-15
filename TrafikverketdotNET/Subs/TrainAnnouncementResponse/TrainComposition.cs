using System;
using Newtonsoft.Json;

namespace TrafikverketdotNET.Subs.TrainAnnouncementResponse
{
    public sealed class TrainComposition
    {
        [JsonProperty("Code")] internal String _Code { get; set; }
        [JsonProperty("Description")] internal String _Description { get; set; }

        /// <summary>
        /// Tågsammansättningskod
        /// </summary>
        [JsonIgnore] public String Code => _Code;
        /// <summary>
        /// Tågsammansättning, ex: "Vagnsordning 7, 6, 5, 4, 2, 1"
        /// </summary>
        [JsonIgnore] public String Description => _Description;

        internal TrainComposition() { }
    }
}
