using System;
using TrafikverketdotNET.Subs.RoadConditionResponse;
using Newtonsoft.Json;

namespace TrafikverketdotNET
{
    public sealed class RoadConditionResponse : BaseTrafikverketResponse
    {
        [JsonProperty("Cause")] internal String[] _Cause { get; set; }
        [JsonProperty("ConditionCode")] internal Int32 _ConditionCode { get; set; }
        [JsonProperty("ConditionInfo")] internal String[] _ConditionInfo { get; set; }
        [JsonProperty("ConditionText")] internal String _ConditionText { get; set; }
        [JsonProperty("CountyNo")] internal Int32[] _CountyNo { get; set; }
        [JsonProperty("Creator")] internal String _Creator { get; set; }
        [JsonProperty("Deleted")] internal Boolean _Deleted { get; set; }
        [JsonProperty("EndTime")] internal DateTime _EndTime { get; set; }
        [JsonProperty("Geometry")] internal Geometry _Geometry { get; set; }
        [JsonProperty("IconId")] internal String _IconId { get; set; }
        [JsonProperty("Id")] internal String _Id { get; set; }
        [JsonProperty("LocationText")] internal String _LocationText { get; set; }
        [JsonProperty("Measurement")] internal String[] _Measurement { get; set; }
        [JsonProperty("ModifiedTime")] internal DateTime _ModifiedTime { get; set; }
        [JsonProperty("RoadNumber")] internal String _RoadNumber { get; set; }
        [JsonProperty("RoadNumberNumeric")] internal Int32 _RoadNumberNumeric { get; set; }
        [JsonProperty("SafetyRelatedMessage")] internal Boolean _SafetyRelatedMessage { get; set; }
        [JsonProperty("StartTime")] internal DateTime _StartTime { get; set; }
        [JsonProperty("Warning")] internal String[] _Warning { get; set; }

        /// <summary>
        /// Orsak (https://github.com/BloodfallenTear/Trafikverket.NET/blob/master/docs/RoadCondition.Cause.txt).
        /// </summary>
        [JsonIgnore] public String[] Cause => _Cause;
        /// <summary>
        /// Väglagskod (https://github.com/BloodfallenTear/Trafikverket.NET/blob/master/docs/RoadCondition.ConditionCode.txt).
        /// </summary>
        [JsonIgnore] public Int32 ConditionCode => _ConditionCode;
        /// <summary>
        /// Väglagsbeskrivning.
        /// </summary>
        [JsonIgnore] public String[] ConditionInfo => _ConditionInfo;
        /// <summary>
        /// Väglagskod som text
        /// </summary>
        [JsonIgnore] public String ConditionText => _ConditionText;
        /// <summary>
        /// Länsnummer (https://github.com/BloodfallenTear/Trafikverket.NET/blob/master/docs/Trafikverket.Lansnummer.txt). 
        /// </summary>
        [JsonIgnore] public Int32[] CountyNo => _CountyNo;
        /// <summary>
        /// Källa till datat.
        /// </summary>
        [JsonIgnore] public String Creator => _Creator;
        /// <summary>
        /// Anger att dataposten raderats
        /// </summary>
        [JsonIgnore] public Boolean Deleted => _Deleted;
        /// <summary>
        /// Väglagsbeskrivningen gäller till och med.
        /// </summary>
        [JsonIgnore] public DateTime EndTime => _EndTime;
        /// <summary>
        /// Geometrisk punkt i koordinatsystem. Fältet kan användas för geo-frågor.
        /// </summary>
        [JsonIgnore] public Geometry Geometry => _Geometry;
        /// <summary>
        /// Ikonid.
        /// </summary>
        [JsonIgnore] public String IconId => _IconId;
        /// <summary>
        /// Datapostens id. Fältet är nyckel för objektet.
        /// </summary>
        [JsonIgnore] public String Id => _Id;
        /// <summary>
        /// Beskrivning av vägsträckningen.
        /// </summary>
        [JsonIgnore] public String LocationText => _LocationText;
        /// <summary>
        /// Åtgärd (https://github.com/BloodfallenTear/Trafikverket.NET/blob/master/docs/RoadCondition.Measurement.txt).
        /// </summary>
        [JsonIgnore] public String[] Measurement => _Measurement;
        /// <summary>
        /// Tidpunkt då dataposten ändrades.
        /// </summary>
        [JsonIgnore] public DateTime ModifiedTime => _ModifiedTime;
        /// <summary>
        /// Vägnummer, ex. "Väg 73".
        /// </summary>
        [JsonIgnore] public String RoadNumber => _RoadNumber;
        /// <summary>
        /// Vägnummer som nummeriskt värde, ex. 73.
        /// </summary>
        [JsonIgnore] public Int32 RoadNumberNumeric => _RoadNumberNumeric;
        /// <summary>
        /// Indikerar att meddelandet är säkerhetsrelaterat i enlighet med 
        /// Kommisionens Delegerade Förordning (EU) nr 886/2013 vad gäller data och förfaranden för kostnadsfritt tillhandahållande, 
        /// när så är möjligt, av ett minimum av vägsäkerhetsrelaterad universell trafikinformation för användare.
        /// </summary>
        [JsonIgnore] public Boolean SafetyRelatedMessage => _SafetyRelatedMessage;
        /// <summary>
        /// Väglagsbeskrivningen gäller från och med.
        /// </summary>
        [JsonIgnore] public DateTime StartTime => _StartTime;
        /// <summary>
        /// Varning (https://github.com/BloodfallenTear/Trafikverket.NET/blob/master/docs/RoadCondition.Warning.txt).
        /// </summary>
        [JsonIgnore] public String[] Warning => _Warning;

        internal RoadConditionResponse() { }
    }

    public class RoadConditionRequest : BaseTrafikverketRequest
    {
        public override ObjectType ObjectType => ObjectType.RoadCondition;
        public override string SchemaVersion => Trafikverket.SchemaVersions[this.ObjectType];

        public RoadConditionRequest(Filter Filter) : base(Filter) { }
        public RoadConditionRequest(String ID = null, Boolean IncludeDeletedObjects = false,
                                    UInt32 Limit = 0, String OrderBy = null, UInt32 Skip = 0,
                                    Boolean LastModified = false, Int32 ChangeID = 0,
                                    String Include = null, String Exclude = null, String Distinct = null) : base(ID, IncludeDeletedObjects,
                                                                                                                 Limit, OrderBy, Skip, LastModified,
                                                                                                                 ChangeID, Include, Exclude, Distinct) { }
        public RoadConditionRequest(String ID = null, Boolean IncludeDeletedObjects = false,
                                    UInt32 Limit = 0, String OrderBy = null, UInt32 Skip = 0,
                                    Boolean LastModified = false, Int32 ChangeID = 0,
                                    String Include = null, String Exclude = null, String Distinct = null, Filter Filter = null) : base(ID, IncludeDeletedObjects,
                                                                                                                                       Limit, OrderBy, Skip, LastModified,
                                                                                                                                       ChangeID, Include, Exclude, Distinct, Filter) { }
        public RoadConditionRequest(String ID = null, Boolean IncludeDeletedObjects = false,
                                    UInt32 Limit = 0, String OrderBy = null, UInt32 Skip = 0,
                                    Boolean LastModified = false, Int32 ChangeID = 0,
                                    String[] Include = null, String[] Exclude = null, String Distinct = null) : base(ID, IncludeDeletedObjects,
                                                                                                                             Limit, OrderBy, Skip, LastModified,
                                                                                                                             ChangeID, Include, Exclude, Distinct) { }
        public RoadConditionRequest(String ID = null, Boolean IncludeDeletedObjects = false,
                                    UInt32 Limit = 0, String OrderBy = null, UInt32 Skip = 0,
                                    Boolean LastModified = false, Int32 ChangeID = 0,
                                    String[] Include = null, String[] Exclude = null, String Distinct = null, Filter Filter = null) : base(ID, IncludeDeletedObjects,
                                                                                                                                                   Limit, OrderBy, Skip, LastModified,
                                                                                                                                                   ChangeID, Include, Exclude, Distinct, Filter) { }
    }

    /// <summary>
    /// Information om väglag.
    /// </summary>
    /// <exception cref="Exception">Thrown when there's an error returned from Trafikverket.</exception>
    public sealed class RoadCondition : BaseTrafikverket<RoadConditionResponse[]>
    {
        /// <summary>
        /// Information om väglag.
        /// </summary>
        /// <param name="APIKey">Användarens unika nyckel.</param>
        /// <exception cref="Exception">Thrown when there's an error returned from Trafikverket.</exception>
        public RoadCondition(String APIKey) : base(APIKey) { }

        internal override ObjectType ObjectType => ObjectType.RoadCondition;
        /// <summary>
        /// SchemaVersion versionen som biblioteken använder.
        /// </summary>
        public override String CurrentSchemaVersion => Trafikverket.SchemaVersions[this.ObjectType];

        public override RoadConditionResponse[] ExecuteRequest() => base.ExecuteRequest("RoadCondition", CurrentSchemaVersion);
        /// <param name="XMLRequest">Custom requests must be written in XML, check "https://api.trafikinfo.trafikverket.se/API/TheRequest" in order to create custom requests.</param>
        public override RoadConditionResponse[] ExecuteRequest(String XMLRequest) => base.ExecuteRequest("RoadCondition", CurrentSchemaVersion, XMLRequest);
        public override RoadConditionResponse[] ExecuteRequest(BaseTrafikverketRequest Request) => base.ExecuteCustomRequest(Request);
    }
}
