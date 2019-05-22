using System;
using Newtonsoft.Json;

namespace TrafikverketdotNET
{
    public sealed class WeatherStationResponse
    {
        [JsonProperty("Active")] internal Boolean _Active { get; set; }
        [JsonProperty("CountyNo")] internal Int32[] _CountyNo { get; set; }
        [JsonProperty("Deleted")] internal Boolean _Deleted { get; set; }
        [JsonProperty("Geometry")] internal Geometry _Geometry { get; set; }
        [JsonProperty("IconId")] internal String _IconId { get; set; }
        [JsonProperty("Id")] internal String _Id { get; set; }
        [JsonProperty("Measurement")] internal MeasurementResp _Measurement { get; set; }
        [JsonProperty("MeasurementHistory")] internal MeasurementHistoryResp[] _MeasurementHistory { get; set; }
        [JsonProperty("ModifiedTime")] internal DateTime _ModifiedTime { get; set; }
        [JsonProperty("Name")] internal String _Name { get; set; }
        [JsonProperty("RoadNumberNumeric")] internal Int32 _RoadNumberNumeric { get; set; }

        /// <summary>
        /// Anger att mätstationen är aktiv och levererar mätdata.
        /// </summary>
        [JsonIgnore] public Boolean Active => _Active;
        /// <summary>
        /// Länsnummer (https://github.com/BloodfallenTear/Trafikverket.NET/blob/master/docs/Lansnummer.txt).
        /// </summary>
        [JsonIgnore] public Int32[] CountyNo => _CountyNo;
        /// <summary>
        /// Anger att dataposten raderats
        /// </summary>
        [JsonIgnore] public Boolean Deleted => _Deleted;
        /// <summary>
        /// Geometrisk punkt i koordinatsystem. Fältet kan användas för geo-frågor.
        /// </summary>
        [JsonIgnore] public Geometry Geometry => _Geometry;
        /// <summary>
        /// Ikonid för mätstationen.
        /// </summary>
        [JsonIgnore] public String IconId => _IconId;
        /// <summary>
        /// Mätstationens id. Fältet är nyckel för objektet.
        /// </summary>
        [JsonIgnore] public String Id => _Id;
        [JsonIgnore] public MeasurementResp Measurement => _Measurement;
        [JsonIgnore] public MeasurementHistoryResp[] MeasurementHistory => _MeasurementHistory;
        /// <summary>
        /// Tidpunkt då dataposten ändrades.
        /// </summary>
        [JsonIgnore] public DateTime ModifiedTime => _ModifiedTime;
        /// <summary>
        /// Mätstationens namn.
        /// </summary>
        [JsonIgnore] public String Name => _Name;
        /// <summary>
        /// Numeriskt vägnummer där mätstationen är placerad.
        /// </summary>
        [JsonIgnore] public Int32 RoadNumberNumeric => _RoadNumberNumeric;

        public sealed class MeasurementResp
        {
            [JsonProperty("Air")] internal AirResp _Air { get; set; }
            [JsonProperty("MeasureTime")] internal DateTime _MeasureTime { get; set; }
            [JsonProperty("Precipitation")] internal PrecipitationResp _Precipitation { get; set; }
            [JsonProperty("Road")] internal RoadResp _Road { get; set; }
            [JsonProperty("Wind")] internal WindResp _Wind { get; set; }

            [JsonIgnore] public AirResp Air => _Air;
            /// <summary>
            /// Tidpunkt då mätvärdena uppdaterades.
            /// </summary>
            [JsonIgnore] public DateTime MeasureTime => _MeasureTime;
            [JsonIgnore] public PrecipitationResp Precipitation => _Precipitation;
            [JsonIgnore] public RoadResp Road => _Road;
            [JsonIgnore] public WindResp Wind => _Wind;

            public sealed class AirResp
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
            }

            public sealed class PrecipitationResp
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
            }

            public sealed class RoadResp
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
            }

            public sealed class WindResp
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
            }
        }

        public sealed class MeasurementHistoryResp
        {
            [JsonProperty("Air")] internal AirResp _Air { get; set; }
            [JsonProperty("MeasureTime")] internal DateTime _MeasureTime { get; set; }
            [JsonProperty("Precipitation")] internal PrecipitationResp _Precipitation { get; set; }
            [JsonProperty("Road")] internal RoadResp _Road { get; set; }
            [JsonProperty("Wind")] internal WindResp _Wind { get; set; }

            [JsonIgnore] public AirResp Air => _Air;
            /// <summary>
            /// Tidpunkt då mätvärdena uppdaterades.
            /// </summary>
            [JsonIgnore] public DateTime MeasureTime => _MeasureTime;
            [JsonIgnore] public PrecipitationResp Precipitation => _Precipitation;
            [JsonIgnore] public RoadResp Road => _Road;
            [JsonIgnore] public WindResp Wind => _Wind;

            public sealed class AirResp
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
            }

            public sealed class PrecipitationResp
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
            }

            public sealed class RoadResp
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
            }

            public sealed class WindResp
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
            }
        }
    }

    public sealed class WeatherStation : BaseTrafikverket<WeatherStationResponse[]>
    {
        /// <summary>
        /// Väderstationer med mätdata.
        /// </summary>
        /// <param name="APIKey">Användarens unika nyckel.</param>
        public WeatherStation(String APIKey) : base(APIKey) { }

        /// <summary>
        /// SchemaVersion versionen som biblioteken använder.
        /// </summary>
        public override String CurrentSchemaVersion => "1";

        public override WeatherStationResponse[] ExecuteRequest() => ExecuteRequest("WeatherStation", CurrentSchemaVersion);

        /// <param name="XMLRequest">Custom requests must be written in XML, check "https://api.trafikinfo.trafikverket.se/API/TheRequest" in order to create custom requests.</param>
        public override WeatherStationResponse[] ExecuteRequest(String XMLRequest) => ExecuteRequest("WeatherStation", CurrentSchemaVersion, XMLRequest);
    }
}
