using System;
using TrafikverketdotNET.Subs;
using Newtonsoft.Json;

namespace TrafikverketdotNET
{
    public sealed class RoadGeometryResponse : BaseTrafikverketResponse
    {
        [JsonProperty("RoadGeometry")] internal RoadGeometryData[] _Data { get; set; }
        [JsonProperty("INFO")] internal Info _Info { get; set; }

        [JsonIgnore] public RoadGeometryData[] Data => _Data;
        [JsonIgnore] public Info Info => _Info;

        internal RoadGeometryResponse() { }
    }

    public sealed class RoadGeometryData
    {
        [JsonProperty("County")] internal Int32 _County { get; set; }
        [JsonProperty("Deleted")] internal Boolean _Deleted { get; set; }
        [JsonProperty("Direction")] internal Direction _Direction { get; set; }
        [JsonProperty("Geometry")] internal TrafikverketdotNET.Subs.RoadGeometryResponse.Geometry _Geometry { get; set; }
        [JsonProperty("Length")] internal Int32 _Length { get; set; }
        [JsonProperty("ModifiedTime")] internal DateTime _ModifiedTime { get; set; }
        [JsonProperty("RoadMainNumber")] internal Int32 _RoadMainNumber { get; set; }
        [JsonProperty("RoadSubNumber")] internal Int32 _RoadSubNumber { get; set; }
        [JsonProperty("TimeStamp")] internal DateTime _TimeStamp { get; set; }

        /// <summary>
        /// Län. Fältet är nyckel för objektet.
        /// </summary>
        [JsonIgnore] public Int32 County => _County;
        /// <summary>
        /// Anger att dataposten raderats.
        /// </summary>
        [JsonIgnore] public Boolean Deleted => _Deleted;
        /// <summary>
        /// Riktning. 
        /// </summary>
        [JsonIgnore] public Direction Direction => _Direction;
        /// <summary>
        /// Geometrisk 3D punkt i koordinatsystem. Fältet kan användas för geo-frågor.
        /// </summary>
        [JsonIgnore] public TrafikverketdotNET.Subs.RoadGeometryResponse.Geometry Geometry => _Geometry;
        /// <summary>
        /// Längd. 
        /// </summary>
        [JsonIgnore] public Int32 Length => _Length;
        /// <summary>
        /// Tidpunkt då dataposten ändrades.
        /// </summary>
        [JsonIgnore] public DateTime ModifiedTime => _ModifiedTime;
        /// <summary>
        /// Huvudvägnummer. Fältet är nyckel för objektet.
        /// </summary>
        [JsonIgnore] public Int32 RoadMainNumber => _RoadMainNumber;
        /// <summary>
        /// Undervägnummer. Kallas ibland även punktväg. Måste användas ihop med huvudvägnumret. Fältet är nyckel för objektet.
        /// </summary>
        [JsonIgnore] public Int32 RoadSubNumber => _RoadSubNumber;
        /// <summary>
        /// Datum för när vägdata hämtades ut från källsystemen. 
        /// </summary>
        [JsonIgnore] public DateTime TimeStamp => _TimeStamp;

        internal RoadGeometryData() { }
    }

    public sealed class RoadGeometryRequest : BaseTrafikverketRequest
    {
        public override ObjectType ObjectType => ObjectType.RoadGeometry;
        public override string SchemaVersion => Trafikverket.SchemaVersions[this.ObjectType];

        public RoadGeometryRequest(Filter Filter) : base(Filter) { }
        public RoadGeometryRequest(String ID = null, Boolean IncludeDeletedObjects = false,
                                   UInt32 Limit = 0, String OrderBy = null, UInt32 Skip = 0,
                                   Boolean LastModified = false, Int32 ChangeID = 0, Boolean SSEURL = false,
                                   String[] Include = null, String[] Exclude = null, String Distinct = null, Filter Filter = null) : base(ID, IncludeDeletedObjects,
                                                                                                                                          Limit, OrderBy, Skip, LastModified,
                                                                                                                                          ChangeID, SSEURL, Include, Exclude, Distinct, Filter) { }
    }

    /// <summary>
    /// Vägens geometri relaterat till det data vi tillhandahåller från PMS-systemen med data om beläggningar och mätdata.
    /// Vi kan ej garantera att geometrin är dagsaktuell från NVDB. Datum för när data hämtades framgår av posten TimeStamp. 
    /// </summary>
    public sealed class RoadGeometry : BaseTrafikverket<RoadGeometryResponse, RoadGeometryRequest>
    {
        /// <summary>
        /// Vägens geometri relaterat till det data vi tillhandahåller från PMS-systemen med data om beläggningar och mätdata.
        /// Vi kan ej garantera att geometrin är dagsaktuell från NVDB. Datum för när data hämtades framgår av posten TimeStamp. 
        /// </summary>
        /// <param name="APIKey">Användarens unika nyckel.</param>
        /// <exception cref="TrafikverketException">Thrown when there's an error returned from Trafikverket.</exception>
        public RoadGeometry(String APIKey) : base(APIKey) { }

        internal override ObjectType ObjectType => ObjectType.RoadGeometry;
        /// <summary>
        /// SchemaVersion versionen som biblioteken använder.
        /// </summary>
        public override String CurrentSchemaVersion => Trafikverket.SchemaVersions[this.ObjectType];

        /// <exception cref="TrafikverketException">Thrown when there's an error returned from Trafikverket.</exception>
        public override RoadGeometryResponse ExecuteRequest() => base.ExecuteRequest("RoadGeometry", CurrentSchemaVersion);
        /// <param name="XMLRequest">Custom requests must be written in XML, check "https://api.trafikinfo.trafikverket.se/API/TheRequest" in order to create custom requests.</param>
        /// <exception cref="TrafikverketException">Thrown when there's an error returned from Trafikverket.</exception>
        public override RoadGeometryResponse ExecuteRequest(String XMLRequest) => base.ExecuteRequest("RoadGeometry", CurrentSchemaVersion, XMLRequest);
        /// <exception cref="TrafikverketException">Thrown when there's an error returned from Trafikverket.</exception>
        public override RoadGeometryResponse ExecuteRequest(RoadGeometryRequest Request) => base.ExecuteCustomRequest(Request);
    }
}
