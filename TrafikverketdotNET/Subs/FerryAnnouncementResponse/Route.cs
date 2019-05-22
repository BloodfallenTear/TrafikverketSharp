using System;
using Newtonsoft.Json;

namespace TrafikverketdotNET.Subs.FerryAnnouncementResponse
{
    public sealed class Route
    {
        [JsonProperty("Description")] internal String _Description { get; set; }
        [JsonProperty("Id")] internal Int32 _Id { get; set; }
        [JsonProperty("Name")] internal String _Name { get; set; }
        [JsonProperty("Shortname")] internal String _Shortname { get; set; }
        [JsonProperty("Type")] internal TrafikverketdotNET.Subs.Type _Type { get; set; }

        /// <summary>
        /// Beskrivande text om rutten.
        /// </summary>
        [JsonIgnore] public String Description => _Description;
        /// <summary>
        /// Ruttens id.
        /// </summary>
        [JsonIgnore] public Int32 Id => _Id;
        /// <summary>
        /// Ruttens namn
        /// </summary>
        [JsonIgnore] public String Name => _Name;
        /// <summary>
        /// Ruttens korntamn.
        /// </summary>
        [JsonIgnore] public String Shortname => _Shortname;
        /// <summary>
        /// Id för ledtypen.
        /// </summary>
        [JsonIgnore] public TrafikverketdotNET.Subs.Type Type => _Type;

        internal Route() { }
    }
}
