using System;
using Newtonsoft.Json;

namespace TrafikverketdotNET.Subs.TrainAnnouncementResponse
{
    public sealed class ViaToLocation
    {
        [JsonProperty("LocationName")] internal String _LocationName { get; set; }
        [JsonProperty("Order")] internal Int32 _Order { get; set; }
        [JsonProperty("Priority")] internal Int32 _Priority { get; set; }

        /// <summary>
        /// Namn på vi. 
        /// Notera att det avser vad som ska annonseras för resenärerna, det vill säga vad som ska visas på skyltar o.dyl. 
        /// ViaToLocation kan med andra ord ha olika innehåll för samma tåg vid olika stationer och olika innehåll vad ankomster respektive avgångar. 
        /// Fältet anger hur till-stationer ska annonseras.
        /// </summary>
        [JsonIgnore] public String LocationName => _LocationName;
        /// <summary>
        /// Vilken ordning stationer ska visas.
        /// </summary>
        [JsonIgnore] public Int32 Order => _Order;
        /// <summary>
        /// Prioritet för vilka stationer som ska visas.
        /// </summary>
        [JsonIgnore] public Int32 Priority => _Priority;

        internal ViaToLocation() { }
    }
}
