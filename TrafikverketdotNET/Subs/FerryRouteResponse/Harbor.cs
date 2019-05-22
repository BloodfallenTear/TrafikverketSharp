using System;
using Newtonsoft.Json;

namespace TrafikverketdotNET.Subs.FerryRouteResponse
{
    public sealed class Harbor
    {
        [JsonProperty("Id")] internal Int32 _Id { get; set; }
        [JsonProperty("Name")] internal String _Name { get; set; }
        [JsonProperty("SortOrder")] internal Int32 _SortOrder { get; set; }
        [JsonProperty("StopType")] internal StopType _StopType { get; set; }

        /// <summary>
        /// Hamnens id.
        /// </summary>
        [JsonIgnore] public Int32 Id => _Id;
        /// <summary>
        /// Hamnens namn.
        /// </summary>
        [JsonIgnore] public String Name => _Name;
        /// <summary>
        /// Sorteringsordning.
        /// </summary>
        [JsonIgnore] public Int32 SortOrder => _SortOrder;
        /// <summary>
        /// Stopptyp.
        /// </summary>
        [JsonIgnore] public StopType StopType => _StopType;

        internal Harbor() { }
    }
}
