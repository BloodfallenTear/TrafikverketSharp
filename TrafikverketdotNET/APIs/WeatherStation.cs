using System;
using System.Collections.Generic;
using TrafikverketdotNET.Subs;
using TrafikverketdotNET.Subs.WeatherStationResponse;
using Newtonsoft.Json;

namespace TrafikverketdotNET
{
    public sealed class WeatherStationResponse : BaseTrafikverketResponse
    {
        [JsonProperty("Active")] internal Boolean _Active { get; set; }
        [JsonProperty("CountyNo")] internal Int32[] _CountyNo { get; set; }
        [JsonProperty("Deleted")] internal Boolean _Deleted { get; set; }
        [JsonProperty("Geometry")] internal Geometry _Geometry { get; set; }
        [JsonProperty("IconId")] internal String _IconId { get; set; }
        [JsonProperty("Id")] internal String _Id { get; set; }
        [JsonProperty("Measurement")] internal Measurement _Measurement { get; set; }
        [JsonProperty("MeasurementHistory")] internal MeasurementHistory[] _MeasurementHistory { get; set; }
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
        [JsonIgnore] public Measurement Measurement => _Measurement;
        [JsonIgnore] public MeasurementHistory[] MeasurementHistory => _MeasurementHistory;
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

        internal WeatherStationResponse() { }
    }

    public class WeatherStationRequest : BaseTrafikverketRequest
    {
        public override ObjectType ObjectType => ObjectType.WeatherStation;
        public override string SchemaVersion => Trafikverket.GetSchemaVersion[this.ObjectType];

        public WeatherStationRequest(Filter Filter) : base(Filter) { }
        public WeatherStationRequest(String ID = null, Boolean IncludeDeletedObjects = false,
                                     UInt32 Limit = 0, String OrderBy = null, UInt32 Skip = 0,
                                     Boolean LastModified = false, Int32 ChangeID = 0,
                                     String Include = null, String Exclude = null, String Distinct = null) : base(ID, IncludeDeletedObjects,
                                                                                                                  Limit, OrderBy, Skip, LastModified,
                                                                                                                  ChangeID, Include, Exclude, Distinct) { }
        public WeatherStationRequest(String ID = null, Boolean IncludeDeletedObjects = false,
                                     UInt32 Limit = 0, String OrderBy = null, UInt32 Skip = 0,
                                     Boolean LastModified = false, Int32 ChangeID = 0,
                                     List<String> Include = null, List<String> Exclude = null, String Distinct = null) : base(ID, IncludeDeletedObjects,
                                                                                                                              Limit, OrderBy, Skip, LastModified,
                                                                                                                              ChangeID, Include, Exclude, Distinct) { }
        public WeatherStationRequest(String ID = null, Boolean IncludeDeletedObjects = false,
                                     UInt32 Limit = 0, String OrderBy = null, UInt32 Skip = 0,
                                     Boolean LastModified = false, Int32 ChangeID = 0,
                                     String Include = null, String Exclude = null, String Distinct = null, Filter Filter = null) : base(ID, IncludeDeletedObjects,
                                                                                                                                        Limit, OrderBy, Skip, LastModified,
                                                                                                                                        ChangeID, Include, Exclude, Distinct, Filter) { }
        public WeatherStationRequest(String ID = null, Boolean IncludeDeletedObjects = false,
                                     UInt32 Limit = 0, String OrderBy = null, UInt32 Skip = 0,
                                     Boolean LastModified = false, Int32 ChangeID = 0,
                                     List<String> Include = null, List<String> Exclude = null, String Distinct = null, Filter Filter = null) : base(ID, IncludeDeletedObjects,
                                                                                                                                                    Limit, OrderBy, Skip, LastModified,
                                                                                                                                                    ChangeID, Include, Exclude, Distinct, Filter) { }
    }

    public sealed class WeatherStation : BaseTrafikverket<WeatherStationResponse[]>
    {
        /// <summary>
        /// Väderstationer med mätdata.
        /// </summary>
        /// <param name="APIKey">Användarens unika nyckel.</param>
        public WeatherStation(String APIKey) : base(APIKey) { }

        internal override ObjectType ObjectType => ObjectType.WeatherStation;
        /// <summary>
        /// SchemaVersion versionen som biblioteken använder.
        /// </summary>
        public override String CurrentSchemaVersion => Trafikverket.GetSchemaVersion[this.ObjectType];

        public override WeatherStationResponse[] ExecuteRequest() => base.ExecuteRequest("WeatherStation", CurrentSchemaVersion);
        /// <param name="XMLRequest">Custom requests must be written in XML, check "https://api.trafikinfo.trafikverket.se/API/TheRequest" in order to create custom requests.</param>
        public override WeatherStationResponse[] ExecuteRequest(String XMLRequest) => base.ExecuteRequest("WeatherStation", CurrentSchemaVersion, XMLRequest);
        public override WeatherStationResponse[] ExecuteRequest(BaseTrafikverketRequest Request) => base.ExecuteCustomRequest(Request);
    }
}
