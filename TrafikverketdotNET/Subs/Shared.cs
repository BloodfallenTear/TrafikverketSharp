using System;
using Newtonsoft.Json;

namespace TrafikverketdotNET.Subs
{
    public sealed class Type
    {
        [JsonProperty("Id")] internal Int32 _Id { get; set; }
        [JsonProperty("Name")] internal String _Name { get; set; }

        /// <summary>
        /// Id för ledtypen.
        /// </summary>
        [JsonIgnore] public Int32 Id => _Id;
        /// <summary>
        /// Namn för ledtypen (ex. Vändande).
        /// </summary>
        [JsonIgnore] public String Name => _Name;

        internal Type() { }
    }

    public sealed class Geometry
    {
        [JsonProperty("SWEREF99TM")] internal String _SWEREF99TM { get; set; }
        [JsonProperty("WGS84")] internal String _WGS84 { get; set; }

        /// <summary>
        /// Geometrisk punkt i koordinatsystem SWEREF99TM.
        /// </summary>
        [JsonIgnore] public String SWEREF99TM => _SWEREF99TM;
        /// <summary>
        /// Geometrisk punkt i koordinatsystem WGS84
        /// </summary>
        [JsonIgnore] public String WGS84 => _WGS84;

        internal Geometry() { }
    }

    public sealed class Direction
    {
        [JsonProperty("Code")] internal Int32 _Code { get; set; }
        [JsonProperty("Value")] internal String _Value { get; set; }

        /// <summary>
        /// Riktning. Värde.Fältet är nyckel för objektet.
        /// </summary>
        [JsonIgnore] public Int32 Code => _Code;
        /// <summary>
        /// Riktning. Beskrivning. Fältet är nyckel för objektet.
        /// </summary>
        [JsonIgnore] public String Value => _Value;

        internal Direction() { }
    }
}
