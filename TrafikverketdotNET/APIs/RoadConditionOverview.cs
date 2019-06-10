using System;
using System.Collections.Generic;
using TrafikverketdotNET.Subs;
using Newtonsoft.Json;

namespace TrafikverketdotNET
{
    public sealed class RoadConditionOverviewResponse : BaseTrafikverketResponse
    {
        [JsonProperty("CountyNo")] internal Int32[] _CountyNo { get; set; }
        [JsonProperty("Deleted")] internal Boolean _Deleted { get; set; }
        [JsonProperty("EndTime")] internal DateTime _EndTime { get; set; }
        [JsonProperty("Geometry")] internal Geometry _Geometry { get; set; }
        [JsonProperty("Id")] internal String _Id { get; set; }
        [JsonProperty("LocationText")] internal String _LocationText { get; set; }
        [JsonProperty("ModifiedTime")] internal DateTime _ModifiedTime { get; set; }
        [JsonProperty("StartTime")] internal DateTime _StartTime { get; set; }
        [JsonProperty("Text")] internal String _Text { get; set; }
        [JsonProperty("ValidUntilFurtherNotice")] internal Boolean _ValidUntilFurtherNotice { get; set; }

        /// <summary>
        /// Länsnummer (https://github.com/BloodfallenTear/Trafikverket.NET/blob/master/docs/Trafikverket.Lansnummer.txt).
        /// </summary>
        [JsonIgnore] public Int32[] CountyNo => _CountyNo;
        /// <summary>
        /// Anger att dataposten raderats.
        /// </summary>
        [JsonIgnore] public Boolean Deleted => _Deleted;
        /// <summary>
        /// Väglagsöversikten gäller till och med.
        /// </summary>
        [JsonIgnore] public DateTime EndTime => _EndTime;
        /// <summary>
        /// Geometrisk punkt i koordinatsystem. Fältet kan användas för geo-frågor.
        /// </summary>
        [JsonIgnore] public Geometry Geometry => _Geometry;
        /// <summary>
        /// Datapostens id. Fältet är nyckel för objektet.
        /// </summary>
        [JsonIgnore] public String Id => _Id;
        /// <summary>
        /// Beskrivning av väglagsöversiktens område.
        /// </summary>
        [JsonIgnore] public String LocationText => _LocationText;
        /// <summary>
        /// Tidpunkt då dataposten ändrades.
        /// </summary>
        [JsonIgnore] public DateTime ModifiedTime => _ModifiedTime;
        /// <summary>
        /// Väglagsöversikten gäller från och med.
        /// </summary>
        [JsonIgnore] public DateTime StartTime => _StartTime;
        /// <summary>
        /// Väglagsöversikt.
        /// </summary>
        [JsonIgnore] public String Text => _Text;
        /// <summary>
        /// Väglagsöversikten gäller på obestämd framtid.
        /// </summary>
        [JsonIgnore] public Boolean ValidUntilFurtherNotice => _ValidUntilFurtherNotice;

        internal RoadConditionOverviewResponse() { }
    }

    public class RoadConditionOverviewRequest : BaseTrafikverketRequest
    {
        public override ObjectType ObjectType => ObjectType.RoadConditionOverview;
        public override string SchemaVersion => Trafikverket.SchemaVersions[this.ObjectType];

        public RoadConditionOverviewRequest(Filter Filter) : base(Filter) { }
        public RoadConditionOverviewRequest(String ID = null, Boolean IncludeDeletedObjects = false,
                                            UInt32 Limit = 0, String OrderBy = null, UInt32 Skip = 0,
                                            Boolean LastModified = false, Int32 ChangeID = 0,
                                            String Include = null, String Exclude = null, String Distinct = null) : base(ID, IncludeDeletedObjects,
                                                                                                                         Limit, OrderBy, Skip, LastModified,
                                                                                                                         ChangeID, Include, Exclude, Distinct) { }
        public RoadConditionOverviewRequest(String ID = null, Boolean IncludeDeletedObjects = false,
                                            UInt32 Limit = 0, String OrderBy = null, UInt32 Skip = 0,
                                            Boolean LastModified = false, Int32 ChangeID = 0,
                                            List<String> Include = null, List<String> Exclude = null, String Distinct = null) : base(ID, IncludeDeletedObjects,
                                                                                                                                     Limit, OrderBy, Skip, LastModified,
                                                                                                                                     ChangeID, Include, Exclude, Distinct) { }
        public RoadConditionOverviewRequest(String ID = null, Boolean IncludeDeletedObjects = false,
                                            UInt32 Limit = 0, String OrderBy = null, UInt32 Skip = 0,
                                            Boolean LastModified = false, Int32 ChangeID = 0,
                                            String Include = null, String Exclude = null, String Distinct = null, Filter Filter = null) : base(ID, IncludeDeletedObjects,
                                                                                                                                               Limit, OrderBy, Skip, LastModified,
                                                                                                                                               ChangeID, Include, Exclude, Distinct, Filter) { }
        public RoadConditionOverviewRequest(String ID = null, Boolean IncludeDeletedObjects = false,
                                            UInt32 Limit = 0, String OrderBy = null, UInt32 Skip = 0,
                                            Boolean LastModified = false, Int32 ChangeID = 0,
                                            List<String> Include = null, List<String> Exclude = null, String Distinct = null, Filter Filter = null) : base(ID, IncludeDeletedObjects,
                                                                                                                                                           Limit, OrderBy, Skip, LastModified,
                                                                                                                                                           ChangeID, Include, Exclude, Distinct, Filter){ }
    }

    public sealed class RoadConditionOverview : BaseTrafikverket<RoadConditionOverviewResponse[]>
    {
        /// <summary>
        /// Information om väglagsöversikt.
        /// </summary>
        /// <param name="APIKey">Användarens unika nyckel.</param>
        public RoadConditionOverview(String APIKey) : base(APIKey) { }

        internal override ObjectType ObjectType => ObjectType.RoadConditionOverview;
        /// <summary>
        /// SchemaVersion versionen som biblioteken använder.
        /// </summary>
        public override String CurrentSchemaVersion => Trafikverket.SchemaVersions[this.ObjectType];

        public override RoadConditionOverviewResponse[] ExecuteRequest() => base.ExecuteRequest("RoadConditionOverview", CurrentSchemaVersion);
        /// <param name="XMLRequest">Custom requests must be written in XML, check "https://api.trafikinfo.trafikverket.se/API/TheRequest" in order to create custom requests.</param>
        public override RoadConditionOverviewResponse[] ExecuteRequest(String XMLRequest) => base.ExecuteRequest("RoadConditionOverview", CurrentSchemaVersion, XMLRequest);
        public override RoadConditionOverviewResponse[] ExecuteRequest(BaseTrafikverketRequest Request) => base.ExecuteCustomRequest(Request);
    }
}
