using System;
using Newtonsoft.Json;

namespace TrafikverketdotNET
{
    public sealed class SituationResponse
    {
        [JsonProperty("CountryCode")] internal String _CountryCode { get; set; }
        [JsonProperty("Deleted")] internal Boolean _Deleted { get; set; }
        [JsonProperty("Deviation")] internal DeviationResp[] _Deviation { get; set; }
        [JsonProperty("Id")] internal String _Id { get; set; }
        [JsonProperty("ModifiedTime")] internal DateTime _ModifiedTime { get; set; }
        [JsonProperty("PublicationTime")] internal DateTime _PublicationTime { get; set; }
        [JsonProperty("VersionTime")] internal DateTime _VersionTime { get; set; }

        /// <summary>
        /// Landsbeteckning (https://github.com/BloodfallenTear/Trafikverket.NET/blob/master/docs/Trafikverket.CountryCode.txt).
        /// </summary>
        [JsonIgnore] public String CountryCode => _CountryCode;
        /// <summary>
        /// Anger att dataposten raderats.
        /// </summary>
        [JsonIgnore] public Boolean Deleted => _Deleted;
        [JsonIgnore] public DeviationResp[] Deviation => _Deviation;
        /// <summary>
        /// Datapostens id. Fältet är nyckel för objektet.
        /// </summary>
        [JsonIgnore] public String Id => _Id;
        /// <summary>
        /// Tidpunkt då dataposten ändrades.
        /// </summary>
        [JsonIgnore] public DateTime ModifiedTime => _ModifiedTime;
        /// <summary>
        /// Tidpunkt då dataposten publicerades.
        /// </summary>
        [JsonIgnore] public DateTime PublicationTime => _PublicationTime;
        /// <summary>
        /// Aktuell versionstid för situationen.
        /// </summary>
        [JsonIgnore] public DateTime VersionTime => _VersionTime;

        public sealed class DeviationResp
        {
            [JsonProperty("CountyNo")] internal Int32[] _CountyNo { get; set; }
            [JsonProperty("CreationTime")] internal DateTime _CreationTime { get; set; }
            [JsonProperty("Creator")] internal String _Creator { get; set; }
            [JsonProperty("EndTime")] internal DateTime _EndTime { get; set; }
            [JsonProperty("Geometry")] internal Geometry _Geometry { get; set; }
            [JsonProperty("Header")] internal String _Header { get; set; }
            [JsonProperty("IconId")] internal String _IconId { get; set; }
            [JsonProperty("Id")] internal String _Id { get; set; }
            [JsonProperty("Image")] internal ImageResp[] _Image { get; set; }
            [JsonProperty("JourneyReference")] internal String _JourneyReference { get; set; }
            [JsonProperty("LocationDescriptor")] internal String _LocationDescriptor { get; set; }
            [JsonProperty("ManagedCause")] internal Boolean _ManagedCause { get; set; }
            [JsonProperty("Message")] internal String _Message { get; set; }
            [JsonProperty("MessageCode")] internal String _MessageCode { get; set; }
            [JsonProperty("MessageCodeValue")] internal String _MessageCodeValue { get; set; }
            [JsonProperty("MessageType")] internal String _MessageType { get; set; }
            [JsonProperty("MessageTypeValue")] internal String _MessageTypeValue { get; set; }
            [JsonProperty("NumberOfLanesRestricted")] internal Int32 _NumberOfLanesRestricted { get; set; }
            [JsonProperty("PositionalDescription")] internal String _PositionalDescription { get; set; }
            [JsonProperty("RoadNumber")] internal String _RoadNumber { get; set; }
            [JsonProperty("RoadNumberNumeric")] internal Int32 _RoadNumberNumeric { get; set; }
            [JsonProperty("SafetyRelatedMessage")] internal Boolean _SafetyRelatedMessage { get; set; }
            [JsonProperty("Schedule")] internal ScheduleResp[] _Schedule { get; set; }
            [JsonProperty("SeverityCode")] internal Int32 _SeverityCode { get; set; }
            [JsonProperty("SeverityText")] internal String _SeverityText { get; set; }
            [JsonProperty("StartTime")] internal DateTime _StartTime { get; set; }
            [JsonProperty("TemporaryLimit")] internal String _TemporaryLimit { get; set; }
            [JsonProperty("TrafficRestrictionType")] internal String _TrafficRestrictionType { get; set; }
            [JsonProperty("ValidUntilFurtherNotice")] internal Boolean _ValidUntilFurtherNotice { get; set; }
            [JsonProperty("WebLink")] internal String _WebLink { get; set; }
            [JsonProperty("VersionTime")] internal DateTime _VersionTime { get; set; }

            /// <summary>
            /// Länsnummer (https://github.com/BloodfallenTear/Trafikverket.NET/blob/master/docs/Trafikverket.Lansnummer.txt).
            /// </summary>
            [JsonIgnore] public Int32[] CountyNo => _CountyNo;
            /// <summary>
            /// Tidpunkt då dataposten skapades.
            /// </summary>
            [JsonIgnore] public DateTime CreationTime => _CreationTime;
            /// <summary>
            /// Källa till datat.
            /// </summary>
            [JsonIgnore] public String Creator => _Creator;
            /// <summary>
            /// Dataposten är giltig till och med
            /// </summary>
            [JsonIgnore] public DateTime EndTime => _EndTime;
            /// <summary>
            /// Geometrisk punkt i koordinatsystem. Fältet kan användas för geo-frågor.
            /// </summary>
            [JsonIgnore] public Geometry Geometry => _Geometry;
            /// <summary>
            /// Titel.
            /// </summary>
            [JsonIgnore] public String Header => _Header;
            /// <summary>
            /// Ikonid.
            /// </summary>
            [JsonIgnore] public String IconId => _IconId;
            /// <summary>
            /// Datapostens id.
            /// </summary>
            [JsonIgnore] public String Id => _Id;
            [JsonIgnore] public ImageResp[] Image => _Image;
            /// <summary>
            /// Färjeled.
            /// </summary>
            [JsonIgnore] public String JourneyReference => _JourneyReference;
            /// <summary>
            /// Beskrivning av position.
            /// </summary>
            [JsonIgnore] public String LocationDescriptor => _LocationDescriptor;
            /// <summary>
            /// Objektet är orsaken till situationen.
            /// </summary>
            [JsonIgnore] public Boolean ManagedCause => _ManagedCause;
            /// <summary>
            /// Meddelandetext.
            /// </summary>
            [JsonIgnore] public String Message => _Message;
            /// <summary>
            /// Meddelandekod, ex. "Beläggningsarbete".
            /// </summary>
            [JsonIgnore] public String MessageCode => _MessageCode;
            /// <summary>
            /// Meddelandekodsvärde, ex. "resurfacingWork".
            /// </summary>
            [JsonIgnore] public String MessageCodeValue => _MessageCodeValue;
            /// <summary>
            /// Meddelandetyp, ex: "Vägarbete" (https://github.com/BloodfallenTear/Trafikverket.NET/blob/master/docs/Situation.MessageType.txt).
            /// </summary>
            [JsonIgnore] public String MessageType => _MessageType;
            /// <summary>
            /// Meddelandetypsvärde, ex: "MaintenanceWorks"
            /// </summary>
            [JsonIgnore] public String MessageTypeValue => _MessageTypeValue;
            /// <summary>
            /// Antal påverkade körfält.
            /// </summary>
            [JsonIgnore] public Int32 NumberOfLanesRestricted => _NumberOfLanesRestricted;
            /// <summary>
            /// Påverkad del, ex. "vägren".
            /// </summary>
            [JsonIgnore] public String PositionalDescription => _PositionalDescription;
            /// <summary>
            /// Vägnummer, ex. "Väg 73".
            /// </summary>
            [JsonIgnore] public String RoadNumber => _RoadNumber;
            /// <summary>
            /// Vägnummer som nummeriskt värde, ex: 73.
            /// </summary>
            [JsonIgnore] public Int32 RoadNumberNumeric => _RoadNumberNumeric;
            /// <summary>
            /// Indikerar att meddelandet är säkerhetsrelaterat i enlighet med 
            /// Kommisionens Delegerade Förordning (EU) nr 886/2013 vad gäller data och förfaranden för kostnadsfritt tillhandahållande, 
            /// när så är möjligt, av ett minimum av vägsäkerhetsrelaterad universell trafikinformation för användare.
            /// </summary>
            [JsonIgnore] public Boolean SafetyRelatedMessage => _SafetyRelatedMessage;
            [JsonIgnore] public ScheduleResp[] Schedule => _Schedule;
            /// <summary>
            /// Påverkansgrad, värden: 1, 2, 4, 5.
            /// </summary>
            [JsonIgnore] public Int32 SeverityCode => _SeverityCode;
            /// <summary>
            /// Påverkan (https://github.com/BloodfallenTear/Trafikverket.NET/blob/master/docs/Situation.SeverityText.txt).
            /// </summary>
            [JsonIgnore] public String SeverityText => _SeverityText;
            /// <summary>
            /// Dataposten är giltig från och med.
            /// </summary>
            [JsonIgnore] public DateTime StartTime => _StartTime;
            /// <summary>
            /// Tillfälliga begränsningar, ex. "bruttovikt 8 ton".
            /// </summary>
            [JsonIgnore] public String TemporaryLimit => _TemporaryLimit;
            /// <summary>
            /// Trafikrestriktion, ex. "körfält blockerat".
            /// </summary>
            [JsonIgnore] public String TrafficRestrictionType => _TrafficRestrictionType;
            /// <summary>
            /// Dataposten gäller på obestämd framtid.
            /// </summary>
            [JsonIgnore] public Boolean ValidUntilFurtherNotice => _ValidUntilFurtherNotice;
            /// <summary>
            /// Url till färjans hemsida.
            /// </summary>
            [JsonIgnore] public String WebLink => _WebLink;
            /// <summary>
            /// Aktuell versionstid för störningen.
            /// </summary>
            [JsonIgnore] public DateTime VersionTime => _VersionTime;

            public sealed class ImageResp
            {
                [JsonProperty("HasFullSizePhoto")] internal Boolean _HasFullSizePhoto { get; set; }
                [JsonProperty("Url")] internal String _Url { get; set; }

                /// <summary>
                /// Gäller för meddelandetyp 'Viktig trafikinformation': anger om det finns ett högupplöst foto.
                /// </summary>
                [JsonIgnore] public Boolean HasFullSizePhoto => _HasFullSizePhoto;
                /// <summary>
                /// Gäller för meddelandetyp 'Viktig trafikinformation': bildens URL.
                /// </summary>
                [JsonIgnore] public String Url => _Url;

                internal ImageResp() { }
            }

            public sealed class ScheduleResp
            {
                [JsonProperty("EndOfPeriod")] internal DateTime _EndOfPeriod { get; set; }
                [JsonProperty("RecurringTimePeriodOfDay")] internal RecurringTimePeriodOfDayResp[] _RecurringTimePeriodOfDay { get; set; }
                [JsonProperty("StartOfPeriod")] internal DateTime _StartOfPeriod { get; set; }

                /// <summary>
                /// Objektet är aktivt till och med period.
                /// </summary>
                [JsonIgnore] public DateTime EndOfPeriod => _EndOfPeriod;
                [JsonIgnore] public RecurringTimePeriodOfDayResp[] RecurringTimePeriodOfDay => _RecurringTimePeriodOfDay;
                /// <summary>
                /// Objektet är aktivt från och med period.
                /// </summary>
                [JsonIgnore] public DateTime StartOfPeriod => _StartOfPeriod;

                public sealed class RecurringTimePeriodOfDayResp
                {
                    [JsonProperty("End")] internal String _End { get; set; }
                    [JsonProperty("Start")] internal String _Start { get; set; }

                    /// <summary>
                    /// Per dag återkommande aktiv till och med tidpunkt, ex: "16:00".
                    /// </summary>
                    [JsonIgnore] public String End => _End;
                    /// <summary>
                    /// Per dag återkommande aktiv från och med tidpunkt, ex. "07:00".
                    /// </summary>
                    [JsonIgnore] public String Start => _Start;

                    internal RecurringTimePeriodOfDayResp() { }
                }

                internal ScheduleResp() { }
            }

            internal DeviationResp() { }
        }

        internal SituationResponse() { }
    }

    public sealed class Situation : BaseTrafikverket<SituationResponse[]>
    {
        /// <summary>
        /// Situationer innehållandes händelser och störningar som trafikmeddelanden, vägarbeten, olyckor, restiktioner m.m.
        /// </summary>
        /// <param name="APIKey">Användarens unika nyckel.</param>
        public Situation(String APIKey) : base(APIKey) { }

        /// <summary>
        /// SchemaVersion versionen som biblioteken använder.
        /// </summary>
        public override String CurrentSchemaVersion => "1.2";

        public override SituationResponse[] ExecuteRequest() => ExecuteRequest("Situation", CurrentSchemaVersion);

        /// <param name="XMLRequest">Custom requests must be written in XML, check "https://api.trafikinfo.trafikverket.se/API/TheRequest" in order to create custom requests.</param>
        public override SituationResponse[] ExecuteRequest(String XMLRequest) => ExecuteRequest("Situation", CurrentSchemaVersion, XMLRequest);
    }
}
