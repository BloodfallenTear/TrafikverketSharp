using System;
using Newtonsoft.Json;

namespace TrafikverketdotNET.Subs.FerryAnnouncementResponse
{
    public sealed class FromHarbor
    {
        [JsonProperty("Id")] internal Int32 _Id { get; set; }
        [JsonProperty("Name")] internal String _Name { get; set; }

        /// <summary>
        /// Avgår från (id).
        /// </summary>
        [JsonIgnore] public Int32 Id => _Id;
        /// <summary>
        /// Avgår från (namn).
        /// </summary>
        [JsonIgnore] public String Name => _Name;

        internal FromHarbor() { }
    }
}
