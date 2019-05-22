using System;
using Newtonsoft.Json;

namespace TrafikverketdotNET.Subs.ParkingResponse
{
    public sealed class Photo
    {
        [JsonProperty("Title")] internal String _Title { get; set; }
        [JsonProperty("Url")] internal String _Url { get; set; }

        /// <summary>
        /// Namn på foto.
        /// </summary>
        [JsonIgnore] public String Title => _Title;
        /// <summary>
        /// Url till foto.
        /// </summary>
        [JsonIgnore] public String Url => _Url;

        internal Photo() { }
    }
}
