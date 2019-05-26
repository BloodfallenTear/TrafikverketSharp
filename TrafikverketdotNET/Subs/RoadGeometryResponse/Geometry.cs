using System;
using Newtonsoft.Json;

namespace TrafikverketdotNET.Subs.RoadGeometryResponse
{
    public sealed class Geometry
    {
        [JsonProperty("SWEREF99TM3D")] internal String _SWEREF99TM3D { get; set; }
        [JsonProperty("WGS843D")] internal String _WGS843D { get; set; }

        /// <summary>
        ///  Geometrisk 3D punkt i koordinatsystem SWEREF99TM. Vissa koordinater kan sakna höjdvärde. Höjdvärdet anges i meter i RH 2000.
        /// </summary>
        [JsonIgnore] public String SWEREF99TM3D => _SWEREF99TM3D;
        /// <summary>
        /// Geometrisk 3D punkt i koordinatsystem WGS84. Vissa koordinater kan sakna höjdvärde. Höjdvärdet anges i meter i RH 2000.
        /// </summary>
        [JsonIgnore] public String WGS843D => _WGS843D;

        internal Geometry() { }
    }
}
