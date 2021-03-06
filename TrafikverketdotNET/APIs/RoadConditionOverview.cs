﻿using System;
using TrafikverketdotNET.Subs;
using Newtonsoft.Json;

namespace TrafikverketdotNET
{
    public sealed class RoadConditionOverviewResponse : BaseTrafikverketResponse
    {
        [JsonProperty("RoadConditionOverview")] internal RoadConditionOverviewData[] _Data { get; set; }
        [JsonProperty("INFO")] internal Info _Info { get; set; }

        [JsonIgnore] public RoadConditionOverviewData[] Data => _Data;
        [JsonIgnore] public Info Info => _Info;

        internal RoadConditionOverviewResponse() { }
    }

    public sealed class RoadConditionOverviewData
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

        internal RoadConditionOverviewData() { }
    }

    public sealed class RoadConditionOverviewRequest : BaseTrafikverketRequest
    {
        public override ObjectType ObjectType => ObjectType.RoadConditionOverview;
        public override string SchemaVersion => Trafikverket.SchemaVersions[this.ObjectType];

        public RoadConditionOverviewRequest(Filter Filter) : base(Filter) { }
        public RoadConditionOverviewRequest(String ID = null, Boolean IncludeDeletedObjects = false,
                                            UInt32 Limit = 0, String OrderBy = null, UInt32 Skip = 0,
                                            Boolean LastModified = false, Int32 ChangeID = 0, Boolean SSEURL = false,
                                            String[] Include = null, String[] Exclude = null, String Distinct = null, Filter Filter = null) : base(ID, IncludeDeletedObjects,
                                                                                                                                                   Limit, OrderBy, Skip, LastModified,
                                                                                                                                                   ChangeID, SSEURL, Include, Exclude, Distinct, Filter){ }
    }

    /// <summary>
    /// Information om väglagsöversikt.
    /// </summary>
    public sealed class RoadConditionOverview : BaseTrafikverket<RoadConditionOverviewResponse, RoadConditionOverviewRequest>
    {
        /// <summary>
        /// Information om väglagsöversikt.
        /// </summary>
        /// <param name="APIKey">Användarens unika nyckel.</param>
        /// <exception cref="TrafikverketException">Thrown when there's an error returned from Trafikverket.</exception>
        public RoadConditionOverview(String APIKey) : base(APIKey) { }

        internal override ObjectType ObjectType => ObjectType.RoadConditionOverview;
        /// <summary>
        /// SchemaVersion versionen som biblioteken använder.
        /// </summary>
        public override String CurrentSchemaVersion => Trafikverket.SchemaVersions[this.ObjectType];

        /// <exception cref="TrafikverketException">Thrown when there's an error returned from Trafikverket.</exception>
        public override RoadConditionOverviewResponse ExecuteRequest() => base.ExecuteRequest("RoadConditionOverview", CurrentSchemaVersion);
        /// <param name="XMLRequest">Custom requests must be written in XML, check "https://api.trafikinfo.trafikverket.se/API/TheRequest" in order to create custom requests.</param>
        /// <exception cref="TrafikverketException">Thrown when there's an error returned from Trafikverket.</exception>
        public override RoadConditionOverviewResponse ExecuteRequest(String XMLRequest) => base.ExecuteRequest("RoadConditionOverview", CurrentSchemaVersion, XMLRequest);
        /// <exception cref="TrafikverketException">Thrown when there's an error returned from Trafikverket.</exception>
        public override RoadConditionOverviewResponse ExecuteRequest(RoadConditionOverviewRequest Request) => base.ExecuteCustomRequest(Request);
    }
}
