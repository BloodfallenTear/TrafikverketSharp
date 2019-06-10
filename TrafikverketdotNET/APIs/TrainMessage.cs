using System;
using System.Collections.Generic;
using TrafikverketdotNET.Subs;
using TrafikverketdotNET.Subs.TrainMessageResponse;
using Newtonsoft.Json;

namespace TrafikverketdotNET
{
    public sealed class TrainMessageResponse : BaseTrafikverketResponse
    {
        [JsonProperty("AffectedLocation")] internal String[] _AffectedLocation { get; set; }
        [JsonProperty("CountyNo")] internal Int32[] _CountyNo { get; set; }
        [JsonProperty("Deleted")] internal Boolean _Deleted { get; set; }
        [JsonProperty("EndDateTime")] internal DateTime _EndDateTime { get; set; }
        [JsonProperty("EventId")] internal String _EventId { get; set; }
        [JsonProperty("ExpectTrafficImpact")] internal Boolean _ExpectTrafficImpact { get; set; }
        [JsonProperty("ExternalDescription")] internal String _ExternalDescription { get; set; }
        [JsonProperty("Header")] internal String _Header { get; set; }
        [JsonProperty("LastUpdateDateTime")] internal DateTime _LastUpdateDateTime { get; set; }
        [JsonProperty("ModifiedTime")] internal DateTime _ModifiedTime { get; set; }
        [JsonProperty("PrognosticatedEndDateTimeTrafficImpact")] internal DateTime _PrognosticatedEndDateTimeTrafficImpact { get; set; }
        [JsonProperty("ReasonCodeText")] internal String _ReasonCodeText { get; set; }
        [JsonProperty("StartDateTime")] internal DateTime _StartDateTime { get; set; }
        [JsonProperty("Geometry")] internal Geometry _Geometry { get; set; }
        [JsonProperty("TrafficImpact")] internal TrafficImpact[] _TrafficImpact { get; set; }

        /// <summary>
        /// Påverkade trafikplatser (stationssignatur).
        /// </summary>
        [JsonIgnore] public String[] AffectedLocation => _AffectedLocation;
        /// <summary>
        /// Länsnummer (https://github.com/BloodfallenTear/Trafikverket.NET/blob/master/docs/Trafikverket.Lansnummer.txt).
        /// </summary>
        [JsonIgnore] public Int32[] CountyNo => _CountyNo;
        /// <summary>
        /// Anger att dataposten raderats.
        /// </summary>
        [JsonIgnore] public Boolean Deleted => _Deleted;
        /// <summary>
        /// Händelsens sluttid.
        /// </summary>
        [JsonIgnore] public DateTime EndDateTime => _EndDateTime;
        /// <summary>
        /// Unikt id för händelsen. Fältet är nyckel för objektet.
        /// </summary>
        [JsonIgnore] public String EventId => _EventId;
        /// <summary>
        /// Händelse kommer förmodligen att påverka trafiken, men trafikpåverkan och prognostiserad sluttidpunkt för trafikpåverkan är ännu inte specificerad.
        /// </summary>
        [JsonIgnore] public Boolean ExpectTrafficImpact => _ExpectTrafficImpact;
        /// <summary>
        /// Informationstext.
        /// </summary>
        [JsonIgnore] public String ExternalDescription => _ExternalDescription;
        /// <summary>
        /// Redaktörssatt rubrik för händelsen, kan i vissa fall vara samma som ReasonCodeText.
        /// </summary>
        [JsonIgnore] public String Header => _Header;
        /// <summary>
        /// Tidpunkt då händelsen uppdaterades.
        /// </summary>
        [JsonIgnore] public DateTime LastUpdateDateTime => _LastUpdateDateTime;
        /// <summary>
        /// Tidpunkt då dataposten ändrades.
        /// </summary>
        [JsonIgnore] public DateTime ModifiedTime => _ModifiedTime;
        /// <summary>
        /// Prognos för då händelsen inte längre väntas påverka trafiken.
        /// </summary>
        [JsonIgnore] public DateTime PrognosticatedEndDateTimeTrafficImpact => _PrognosticatedEndDateTimeTrafficImpact;
        /// <summary>
        /// Händelsens eventuella orsak.
        /// </summary>
        [JsonIgnore] public String ReasonCodeText => _ReasonCodeText;
        /// <summary>
        /// Händelsens starttid.
        /// </summary>
        [JsonIgnore] public DateTime StartDateTime => _StartDateTime;
        /// <summary>
        /// Geometrisk punkt i koordinatsystem. Fältet kan användas för geo-frågor.
        /// </summary>
        [JsonIgnore] public Geometry Geometry => _Geometry;
        /// <summary>
        /// Påverkade stationer.
        /// </summary>
        [JsonIgnore] public TrafficImpact[] TrafficImpact => _TrafficImpact;

        internal TrainMessageResponse() { }
    }

    public class TrainMessageRequest : BaseTrafikverketRequest
    {
        public override ObjectType ObjectType => ObjectType.TrainMessage;
        public override string SchemaVersion => Trafikverket.SchemaVersions[this.ObjectType];

        public TrainMessageRequest(Filter Filter) : base(Filter) { }
        public TrainMessageRequest(String ID = null, Boolean IncludeDeletedObjects = false,
                                   UInt32 Limit = 0, String OrderBy = null, UInt32 Skip = 0,
                                   Boolean LastModified = false, Int32 ChangeID = 0,
                                   String Include = null, String Exclude = null, String Distinct = null) : base(ID, IncludeDeletedObjects,
                                                                                                                Limit, OrderBy, Skip, LastModified,
                                                                                                                ChangeID, Include, Exclude, Distinct) { }
        public TrainMessageRequest(String ID = null, Boolean IncludeDeletedObjects = false,
                                   UInt32 Limit = 0, String OrderBy = null, UInt32 Skip = 0,
                                   Boolean LastModified = false, Int32 ChangeID = 0,
                                   List<String> Include = null, List<String> Exclude = null, String Distinct = null) : base(ID, IncludeDeletedObjects,
                                                                                                                            Limit, OrderBy, Skip, LastModified,
                                                                                                                            ChangeID, Include, Exclude, Distinct) { }
        public TrainMessageRequest(String ID = null, Boolean IncludeDeletedObjects = false,
                                   UInt32 Limit = 0, String OrderBy = null, UInt32 Skip = 0,
                                   Boolean LastModified = false, Int32 ChangeID = 0,
                                   String Include = null, String Exclude = null, String Distinct = null, Filter Filter = null) : base(ID, IncludeDeletedObjects,
                                                                                                                                      Limit, OrderBy, Skip, LastModified,
                                                                                                                                      ChangeID, Include, Exclude, Distinct, Filter) { }
        public TrainMessageRequest(String ID = null, Boolean IncludeDeletedObjects = false,
                                   UInt32 Limit = 0, String OrderBy = null, UInt32 Skip = 0,
                                   Boolean LastModified = false, Int32 ChangeID = 0,
                                   List<String> Include = null, List<String> Exclude = null, String Distinct = null, Filter Filter = null) : base(ID, IncludeDeletedObjects,
                                                                                                                                                  Limit, OrderBy, Skip, LastModified,
                                                                                                                                                  ChangeID, Include, Exclude, Distinct, Filter) { }
    }

    /// <summary>
    /// Tågtrafikmeddelande, exempelvis information kring banarbete, tågfel, anläggningsfel och dylikt.
    /// </summary>
    public sealed class TrainMessage : BaseTrafikverket<TrainMessageResponse[]>
    {
        /// <summary>
        /// Tågtrafikmeddelande, exempelvis information kring banarbete, tågfel, anläggningsfel och dylikt.
        /// </summary>
        /// <param name="APIKey">Användarens unika nyckel.</param>
        public TrainMessage(String APIKey) : base(APIKey) { }

        internal override ObjectType ObjectType => ObjectType.TrainMessage;
        /// <summary>
        /// SchemaVersion versionen som biblioteken använder.
        /// </summary>
        public override String CurrentSchemaVersion => Trafikverket.SchemaVersions[this.ObjectType];


        public override TrainMessageResponse[] ExecuteRequest() => base.ExecuteRequest("TrainMessage", CurrentSchemaVersion);
        /// <param name="XMLRequest">Custom requests must be written in XML, check "https://api.trafikinfo.trafikverket.se/API/TheRequest" in order to create custom requests.</param>
        public override TrainMessageResponse[] ExecuteRequest(String XMLRequest) => base.ExecuteRequest("TrainMessage", "1.4", XMLRequest);
        public override TrainMessageResponse[] ExecuteRequest(BaseTrafikverketRequest Request) => base.ExecuteCustomRequest(Request);
    }
}
