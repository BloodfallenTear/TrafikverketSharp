using System;
using Newtonsoft.Json;

namespace TrafikverketdotNET.Subs.FerryRouteResponse
{
    public sealed class StopType
    {
        [JsonProperty("Id")] internal Int32 _Id { get; set; }
        [JsonProperty("Name")] internal String _Name { get; set; }
        [JsonProperty("Visible")] internal Boolean _Visible { get; set; }

        /// <summary>
        /// Stopptypens id.
        /// </summary>
        [JsonIgnore] public Int32 Id => _Id;
        /// <summary>
        /// Namn på stopptypen. Det finns tre olika "Avg", "Ank/Avg" och "Ank".
        /// </summary>
        [JsonIgnore] public String Name => _Name;
        /// <summary>
        /// De med värdet true är synliga i tidtabellen.
        /// </summary>
        [JsonIgnore] public Boolean Visible => _Visible;

        internal StopType() { }
    }
}
