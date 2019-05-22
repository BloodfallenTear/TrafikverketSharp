using System;
using Newtonsoft.Json;

namespace TrafikverketdotNET.Subs.TrainMessageResponse
{
    public sealed class TrafficImpact
    {
        [JsonProperty("AffectedLocation")] internal String[] _AffectedLocation { get; set; }
        [JsonProperty("FromLocation")] internal String[] _FromLocation { get; set; }
        [JsonProperty("ToLocation")] internal String[] _ToLocation { get; set; }

        /// <summary>
        /// Påverkade stationer.
        /// </summary>
        [JsonIgnore] public String[] AffectedLocation => _AffectedLocation;
        /// <summary>
        /// Påverkad sträckas frånstation, för att avgöra om stationen är påverkad, se fältet AffectedLocation.
        /// </summary>
        [JsonIgnore] public String[] FromLocation => _FromLocation;
        /// <summary>
        /// Påverkad sträckas tillstation, för att avgöra om stationen är påverkad, se fältet AffectedLocation.
        /// </summary>
        [JsonIgnore] public String[] ToLocation => _ToLocation;

        internal TrafficImpact() { }
    }
}
