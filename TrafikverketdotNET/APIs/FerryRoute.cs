using System;
using System.Collections.Generic;
using TrafikverketdotNET.Subs;
using TrafikverketdotNET.Subs.FerryRouteResponse;
using Newtonsoft.Json;

namespace TrafikverketdotNET
{
    public sealed class FerryRouteResponse : BaseTrafikverketResponse
    {
        [JsonProperty("Deleted")] internal Boolean _Deleted { get; set; }
        [JsonProperty("DeviationId")] internal String _DeviationId { get; set; }
        [JsonProperty("Geometry")] internal Geometry _Geometry { get; set; }
        [JsonProperty("Harbor")] internal Harbor[] _Harbor { get; set; }
        [JsonProperty("Id")] internal Int32 _Id { get; set; }
        [JsonProperty("ModifiedTime")] internal DateTime _ModifiedTime { get; set; }
        [JsonProperty("Name")] internal String _Name { get; set; }
        [JsonProperty("Shortname")] internal String _Shortname { get; set; }
        [JsonProperty("Timetable")] internal Timetable[] _Timetable { get; set; }
        [JsonProperty("Type")] internal TrafikverketdotNET.Subs.Type _Type { get; set; }

        /// <summary>
        /// Anger att dataposten raderats.
        /// </summary>
        [JsonIgnore] public Boolean Deleted => _Deleted;
        /// <summary>
        /// Referens till Deviation.Id i objektet Situation.
        /// </summary>
        [JsonIgnore] public String DeviationId => _DeviationId;
        /// <summary>
        /// Geometrisk punkt i koordinatsystem. Fältet kan användas för geo-frågor.
        /// </summary>
        [JsonIgnore] public Geometry Geometry => _Geometry;
        /// <summary>
        /// Hamn.
        /// </summary>
        [JsonIgnore] public Harbor[] Harbor => _Harbor;
        /// <summary>
        /// Ledens id. Fältet är nyckel för objektet.
        /// </summary>
        [JsonIgnore] public Int32 Id => _Id;
        /// <summary>
        /// Tidpunkt då dataposten ändrades.
        /// </summary>
        [JsonIgnore] public DateTime ModifiedTime => _ModifiedTime;
        /// <summary>
        /// Ledens namn.
        /// </summary>
        [JsonIgnore] public String Name => _Name;
        /// <summary>
        /// Förkortning av ledens namn.
        /// </summary>
        [JsonIgnore] public String Shortname => _Shortname;
        /// <summary>
        /// Tidtabel.
        /// </summary>
        [JsonIgnore] public Timetable[] Timetable => _Timetable;
        /// <summary>
        /// Ledtyp.
        /// </summary>
        [JsonIgnore] public TrafikverketdotNET.Subs.Type Type => _Type;

        internal FerryRouteResponse() { }
    }

    public class FerryRouteRequest : BaseTrafikverketRequest
    {
        public override ObjectType ObjectType => ObjectType.FerryRoute;
        public override string SchemaVersion => Trafikverket.SchemaVersions[this.ObjectType];

        public FerryRouteRequest(Filter Filter) : base(Filter) { }
        public FerryRouteRequest(String ID = null, Boolean IncludeDeletedObjects = false,
                                 UInt32 Limit = 0, String OrderBy = null, UInt32 Skip = 0,
                                 Boolean LastModified = false, Int32 ChangeID = 0,
                                 String Include = null, String Exclude = null, String Distinct = null) : base(ID, IncludeDeletedObjects,
                                                                                                              Limit, OrderBy, Skip, LastModified,
                                                                                                              ChangeID, Include, Exclude, Distinct) { }
        public FerryRouteRequest(String ID = null, Boolean IncludeDeletedObjects = false,
                                 UInt32 Limit = 0, String OrderBy = null, UInt32 Skip = 0,
                                 Boolean LastModified = false, Int32 ChangeID = 0,
                                 String Include = null, String Exclude = null, String Distinct = null, Filter Filter = null) : base(ID, IncludeDeletedObjects,
                                                                                                                                    Limit, OrderBy, Skip, LastModified,
                                                                                                                                    ChangeID, Include, Exclude, Distinct, Filter) { }
        public FerryRouteRequest(String ID = null, Boolean IncludeDeletedObjects = false,
                                 UInt32 Limit = 0, String OrderBy = null, UInt32 Skip = 0,
                                 Boolean LastModified = false, Int32 ChangeID = 0,
                                 String[] Include = null, String[] Exclude = null, String Distinct = null) : base(ID, IncludeDeletedObjects,
                                                                                                                          Limit, OrderBy, Skip, LastModified,
                                                                                                                          ChangeID, Include, Exclude, Distinct) { }
        public FerryRouteRequest(String ID = null, Boolean IncludeDeletedObjects = false,
                                 UInt32 Limit = 0, String OrderBy = null, UInt32 Skip = 0,
                                 Boolean LastModified = false, Int32 ChangeID = 0,
                                 String[] Include = null, String[] Exclude = null, String Distinct = null, Filter Filter = null) : base(ID, IncludeDeletedObjects,
                                                                                                                                                Limit, OrderBy, Skip, LastModified,
                                                                                                                                                ChangeID, Include, Exclude, Distinct, Filter) { }

    }

    /// <summary>
    /// Information om färjeleder.
    /// </summary>
    /// <exception cref="Exception">Thrown when there's an error returned from Trafikverket.</exception>
    public sealed class FerryRoute : BaseTrafikverket<FerryRouteResponse[]>
    {
        /// <summary>
        /// Information om färjeleder.
        /// </summary>
        /// <param name="APIKey">Användarens unika nyckel.</param>
        /// <exception cref="Exception">Thrown when there's an error returned from Trafikverket.</exception>
        public FerryRoute(String APIKey) : base(APIKey) { }

        internal override ObjectType ObjectType => ObjectType.FerryRoute;
        /// <summary>
        /// SchemaVersion versionen som biblioteken använder.
        /// </summary>
        public override String CurrentSchemaVersion => Trafikverket.SchemaVersions[this.ObjectType];

        public override FerryRouteResponse[] ExecuteRequest() => base.ExecuteRequest("FerryRoute", CurrentSchemaVersion);
        /// <param name="XMLRequest">Custom requests must be written in XML, check "https://api.trafikinfo.trafikverket.se/API/TheRequest" in order to create custom requests.</param>s
        public override FerryRouteResponse[] ExecuteRequest(String XMLRequest) => base.ExecuteRequest("FerryRoute", CurrentSchemaVersion, XMLRequest);
        public override FerryRouteResponse[] ExecuteRequest(BaseTrafikverketRequest Request) => base.ExecuteCustomRequest(Request);
    }
}
