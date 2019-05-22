using System;
using Newtonsoft.Json;

namespace TrafikverketdotNET.Subs.FerryAnnouncementResponse
{
    public sealed class ToHarbor
    {
        [JsonProperty("Id")] internal Int32 _Id { get; set; }
        [JsonProperty("Name")] internal String _Name { get; set; }

        /// <summary>
        /// Ankommer till (id).
        /// </summary>
        [JsonIgnore] public Int32 Id => _Id;
        /// <summary>
        /// Ankommer till (namn).
        /// </summary>
        [JsonIgnore] public String Name => _Name;

        internal ToHarbor() { }
    }
}
