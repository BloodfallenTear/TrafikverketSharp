using System;
using Newtonsoft.Json;

namespace TrafikverketdotNET.Subs.WeatherStationResponse
{
    public sealed class Air
    {
        [JsonProperty("RelativeHumidity")] internal float _RelativeHumidity { get; set; }
        [JsonProperty("Temp")] internal float _Temp { get; set; }
        [JsonProperty("TempIconId")] internal String _TempIconId { get; set; }

        /// <summary>
        /// Relativ luftfuktighet.
        /// </summary>
        [JsonIgnore] public float RelativeHumidity => _RelativeHumidity;
        /// <summary>
        /// Lufttemperatur.
        /// </summary>
        [JsonIgnore] public float Temp => _Temp;
        /// <summary>
        /// Ikonid för lufttemperatur.
        /// </summary>
        [JsonIgnore] public String TempIconId => _TempIconId;

        internal Air() { }
    }

    public sealed class Precipitation
    {
        [JsonProperty("Amount")] internal float _Amount { get; set; }
        [JsonProperty("AmountName")] internal String _AmountName { get; set; }
        [JsonProperty("Type")] internal String _Type { get; set; }
        [JsonProperty("TypeIconId")] internal String _TypeIconId { get; set; }

        /// <summary>
        /// Nederbördsmängd.
        /// </summary>
        [JsonIgnore] public float Amount => _Amount;
        /// <summary>
        /// I text beskriven nederbördsmängd (https://github.com/BloodfallenTear/Trafikverket.NET/blob/master/docs/WeatherStation.Measurement.Precipitation.AmountName.txt).
        /// </summary>
        [JsonIgnore] public String AmountName => _AmountName;
        /// <summary>
        /// Typ av nederbörd (https://github.com/BloodfallenTear/Trafikverket.NET/blob/master/docs/WeatherStation.Measurement.Precipitation.Type.txt).
        /// </summary>
        [JsonIgnore] public String Type => _Type;
        /// <summary>
        /// Ikonid för nederbördstyp
        /// </summary>
        [JsonIgnore] public String TypeIconId => _TypeIconId;

        internal Precipitation() { }
    }

    public sealed class Road
    {
        [JsonProperty("Temp")] internal float _Temp { get; set; }
        [JsonProperty("TempIconId")] internal String _TempIconId { get; set; }

        /// <summary>
        /// Vägbanans temperatur.
        /// </summary>
        [JsonIgnore] public float Temp => _Temp;
        /// <summary>
        /// Ikonid för vägbanans temperatur.
        /// </summary>
        [JsonIgnore] public String TempIconId => _TempIconId;

        internal Road() { }
    }

    public sealed class Wind
    {
        [JsonProperty("Direction")] internal float _Direction { get; set; }
        [JsonProperty("DirectionIconId")] internal String _DirectionIconId { get; set; }
        [JsonProperty("DirectionText")] internal String _DirectionText { get; set; }
        [JsonProperty("Force")] internal float _Force { get; set; }
        [JsonProperty("ForceMax")] internal float _ForceMax { get; set; }

        /// <summary>
        /// Vindriktning (grader).
        /// </summary>
        [JsonIgnore] public float Direction => _Direction;
        /// <summary>
        /// Ikonid för vindriktning.
        /// </summary>
        [JsonIgnore] public String DirectionIconId => _DirectionIconId;
        /// <summary>
        /// Vindriktning (https://github.com/BloodfallenTear/Trafikverket.NET/blob/master/docs/WeatherStation.Measurement.Wind.DirectionText.txt).
        /// </summary>
        [JsonIgnore] public String DirectionText => _DirectionText;
        /// <summary>
        /// Vindstyrka (m/s), medelvärde 10 minuter tillbaka.
        /// </summary>
        [JsonIgnore] public float Force => _Force;
        /// <summary>
        /// Vindstyrka (m/s), maxvärde 30 minuter tillbaka.
        /// </summary>
        [JsonIgnore] public float ForceMax => _ForceMax;

        internal Wind() { }
    }
}
