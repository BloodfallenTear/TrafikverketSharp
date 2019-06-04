using System;
using Newtonsoft.Json;

namespace TrafikverketdotNET.Subs.TrainAnnouncementResponse
{
    public sealed class ProductInformation
    {
        [JsonProperty("Code")] internal String _Code { get; set; }
        [JsonProperty("Description")] internal String _Description { get; set; }

        /// <summary>
        /// Kod för beskrivning av tåget.
        /// </summary>
        [JsonIgnore] public String Code { get; set; }
        /// <summary>
        /// Beskrivning av tåget, ex. "Tågkompaniet", "SJ InterCity", "TiB/Tågkomp".
        /// </summary>
        [JsonIgnore] public String Description { get; set; }

        internal ProductInformation() { }
    }
}
