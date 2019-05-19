using System;
using Newtonsoft.Json;

namespace TrafikverketdotNET
{
    public sealed class FerryRouteResponse
    {
        [JsonProperty("Deleted")] internal Boolean _Deleted { get; set; }
        [JsonProperty("DeviationId")] internal String _DeviationId { get; set; }
        [JsonProperty("Geometry")] internal Geometry _Geometry { get; set; }
        [JsonProperty("Harbor")] internal HarborResp[] _Harbor { get; set; }
        [JsonProperty("Id")] internal Int32 _Id { get; set; }
        [JsonProperty("ModifiedTime")] internal DateTime _ModifiedTime { get; set; }
        [JsonProperty("Name")] internal String _Name { get; set; }
        [JsonProperty("Shortname")] internal String _Shortname { get; set; }
        [JsonProperty("Timetable")] internal TimetableResp[] _Timetable { get; set; }
        [JsonProperty("Type")] internal TrafikverketdotNET.Type _Type { get; set; }

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
        [JsonIgnore] public HarborResp[] Harbor => _Harbor;
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
        [JsonIgnore] public TimetableResp[] Timetable => _Timetable;
        /// <summary>
        /// Ledtyp.
        /// </summary>
        [JsonIgnore] public TrafikverketdotNET.Type Type => _Type;

        public sealed class HarborResp
        {
            [JsonProperty("Id")] internal Int32 _Id { get; set; }
            [JsonProperty("Name")] internal String _Name { get; set; }
            [JsonProperty("SortOrder")] internal Int32 _SortOrder { get; set; }
            [JsonProperty("StopType")] internal StopTypeResp _StopType { get; set; }

            /// <summary>
            /// Hamnens id.
            /// </summary>
            [JsonIgnore] public Int32 Id => _Id;
            /// <summary>
            /// Hamnens namn.
            /// </summary>
            [JsonIgnore] public String Name => _Name;
            /// <summary>
            /// Sorteringsordning.
            /// </summary>
            [JsonIgnore] public Int32 SortOrder => _SortOrder;
            /// <summary>
            /// Stopptyp.
            /// </summary>
            [JsonIgnore] public StopTypeResp StopType => _StopType;
        }

        public sealed class StopTypeResp
        {
            [JsonProperty("Id")] internal Int32 _Id { get; set; }
            [JsonProperty("Name")] internal String _Name { get; set; }
            [JsonProperty("Visible")] internal Boolean _Visible { get; set; }

            /// <summary>
            /// Stopptypens id.
            /// </summary>
            [JsonIgnore] public Int32 Id => _Id;
            /// <summary>
            /// Namn på stopptypen. Det finns tre olika "Avg", "Ank/Avg" och "Ank".
            /// </summary>
            [JsonIgnore] public String Name => _Name;
            /// <summary>
            /// De med värdet true är synliga i tidtabellen.
            /// </summary>
            [JsonIgnore] public Boolean Visible => _Visible;
        }

        public sealed class TimetableResp
        {
            [JsonProperty("Description")] internal String _Description { get; set; }
            [JsonProperty("Period")] internal PeriodResp[] _Period { get; set; }
            [JsonProperty("Priority")] internal Int32 _Priority { get; set; }
            [JsonProperty("Valid")] internal ValidResp[] _Valid { get; set; }

            /// <summary>
            /// Tidtabellens beskrivning.
            /// </summary>
            [JsonIgnore] public String Description => _Description;
            [JsonIgnore] public PeriodResp[] Period => _Period;
            /// <summary>
            /// Tidtabellens prioritet, det kan finnas flera tidtabeller som är giltiga samma datum, den med högst prioritet gäller.
            /// </summary>
            [JsonIgnore] public Int32 Priority => _Priority;
            [JsonIgnore] public ValidResp[] Valid => _Valid;

            public sealed class PeriodResp
            {
                [JsonProperty("Name")] internal String _Name { get; set; }
                [JsonProperty("Schedule")] internal ScheduleResp[] _Schedule { get; set; }
                [JsonProperty("SortOrder")] internal Int32 _SortOrder { get; set; }
                [JsonProperty("Weekday")] internal WeekdayResp[] _Weekday { get; set; }

                /// <summary>
                /// Periodens namn.
                /// </summary>
                [JsonIgnore] public String Name => _Name;
                [JsonIgnore] public ScheduleResp[] Schedule => _Schedule;
                /// <summary>
                /// Periodens sorteringsordning
                /// </summary>
                [JsonIgnore] public Int32 SortOrder => _SortOrder;
                [JsonIgnore] public WeekdayResp[] Weekday => _Weekday;

                public sealed class ScheduleResp
                {
                    [JsonProperty("Deviation")] internal DeviationResp[] _Deviation { get; set; }
                    [JsonProperty("Harbor")] internal HarborResp _Harbor { get; set; }
                    [JsonProperty("SortOrder")] internal Int32 _SortOrder { get; set; }
                    [JsonProperty("StopType")] internal StopTypeResp _StopType { get; set; }
                    [JsonProperty("Time")] internal String _Time { get; set; }

                    [JsonIgnore] public DeviationResp[] Deviation => _Deviation;
                    [JsonIgnore] public HarborResp Harbor => _Harbor;
                    /// <summary>
                    /// Sorteringsordning.
                    /// </summary>
                    [JsonIgnore] public Int32 SortOrder => _SortOrder;
                    /// <summary>
                    /// Stopptyp.
                    /// </summary>
                    [JsonIgnore] public StopTypeResp StopType => _StopType;
                    /// <summary>
                    /// Tidpunkt för händelse.
                    /// </summary>
                    [JsonIgnore] public String Time => _Time;

                    public sealed class DeviationResp
                    {
                        [JsonProperty("Description")] internal String _Description { get; set; }
                        [JsonProperty("FromDate")] internal String _FromDate { get; set; }
                        [JsonProperty("Id")] internal String _Id { get; set; }
                        [JsonProperty("SpecDate")] internal String _SpecDate { get; set; }
                        [JsonProperty("ToDate")] internal String _ToDate { get; set; }
                        [JsonProperty("Type")] internal Type _Type { get; set; }

                        /// <summary>
                        /// Beskrivning av avvikelsen.
                        /// </summary>
                        [JsonIgnore] public String Description => _Description;
                        /// <summary>
                        /// Om avvikelsen gäller under en period så finns den en sträng fråndatum med formatet "mmdd".
                        /// </summary>
                        [JsonIgnore] public String FromDate => _FromDate;
                        /// <summary>
                        /// Avvikelsens id.
                        /// </summary>
                        [JsonIgnore] public String Id => _Id;
                        /// <summary>
                        /// Om avvikelsen gäller specifika datum läggs de till en sträng med formatet "mmdd, mmdd".
                        /// </summary>
                        [JsonIgnore] public String SpecDate => _SpecDate;
                        /// <summary>
                        /// Om avvikelsen gäller under en period så finns den en sträng slutdatum med formatet "mmdd".
                        /// </summary>
                        [JsonIgnore] public String ToDate => _ToDate;
                        [JsonIgnore] public Type Type => _Type;
                    }
                }

                public sealed class WeekdayResp
                {
                    [JsonProperty("Day")] internal String _Day { get; set; }
                    [JsonProperty("Id")] internal Int32 _Id { get; set; }

                    /// <summary>
                    /// Veckodagar som ingår i perioden (dagens namn).
                    /// </summary>
                    [JsonIgnore] public String Day => _Day;
                    /// <summary>
                    /// Veckodagar som ingår i perioden (dagens id).
                    /// </summary>
                    [JsonIgnore] public Int32 Id => _Id;
                }
            }

            public sealed class ValidResp
            {
                [JsonProperty("From")] internal DateTime _From { get; set; }
                [JsonProperty("To")] internal DateTime _To { get; set; }

                /// <summary>
                /// Datumet då tidtabellen börjar gälla.
                /// </summary>
                [JsonIgnore] public DateTime From => _From;
                /// <summary>
                /// Datumet då tidtabellen slutar gälla
                /// </summary>
                [JsonIgnore] public DateTime To => _To;
            }
        }
    }

    public sealed class FerryRoute : BaseTrafikverket<FerryRouteResponse[]>
    {
        /// <summary>
        /// Information om färjeleder.
        /// </summary>
        /// <param name="APIKey">Användarens unika nyckel.</param>
        public FerryRoute(String APIKey) : base(APIKey) { }

        /// <summary>
        /// SchemaVersion versionen som biblioteken använder.
        /// </summary>
        public override String CurrentSchemaVersion => "1.2";

        public override FerryRouteResponse[] ExecuteRequest() => ExecuteRequest("FerryRoute", CurrentSchemaVersion);

        /// <param name="XMLRequest">Custom requests must be written in XML, check "https://api.trafikinfo.trafikverket.se/API/TheRequest" in order to create custom requests.</param>s
        public override FerryRouteResponse[] ExecuteRequest(String XMLRequest) => ExecuteRequest("FerryRoute", CurrentSchemaVersion, XMLRequest);
    }
}
