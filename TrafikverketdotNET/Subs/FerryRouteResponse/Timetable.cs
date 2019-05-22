using System;
using Newtonsoft.Json;

namespace TrafikverketdotNET.Subs.FerryRouteResponse
{
    public sealed class Timetable
    {
        [JsonProperty("Description")] internal String _Description { get; set; }
        [JsonProperty("Period")] internal Period[] _Period { get; set; }
        [JsonProperty("Priority")] internal Int32 _Priority { get; set; }
        [JsonProperty("Valid")] internal Valid[] _Valid { get; set; }

        /// <summary>
        /// Tidtabellens beskrivning.
        /// </summary>
        [JsonIgnore] public String Description => _Description;
        [JsonIgnore] public Period[] Period => _Period;
        /// <summary>
        /// Tidtabellens prioritet, det kan finnas flera tidtabeller som är giltiga samma datum, den med högst prioritet gäller.
        /// </summary>
        [JsonIgnore] public Int32 Priority => _Priority;
        [JsonIgnore] public Valid[] Valid => _Valid;

        internal Timetable() { }
    }

    public sealed class Period
    {
        [JsonProperty("Name")] internal String _Name { get; set; }
        [JsonProperty("Schedule")] internal Schedule[] _Schedule { get; set; }
        [JsonProperty("SortOrder")] internal Int32 _SortOrder { get; set; }
        [JsonProperty("Weekday")] internal Weekday[] _Weekday { get; set; }

        /// <summary>
        /// Periodens namn.
        /// </summary>
        [JsonIgnore] public String Name => _Name;
        [JsonIgnore] public Schedule[] Schedule => _Schedule;
        /// <summary>
        /// Periodens sorteringsordning
        /// </summary>
        [JsonIgnore] public Int32 SortOrder => _SortOrder;
        [JsonIgnore] public Weekday[] Weekday => _Weekday;

        internal Period() { }
    }

    public sealed class Schedule
    {
        [JsonProperty("Deviation")] internal Deviation[] _Deviation { get; set; }
        [JsonProperty("Harbor")] internal Harbor _Harbor { get; set; }
        [JsonProperty("SortOrder")] internal Int32 _SortOrder { get; set; }
        [JsonProperty("StopType")] internal StopType _StopType { get; set; }
        [JsonProperty("Time")] internal String _Time { get; set; }

        [JsonIgnore] public Deviation[] Deviation => _Deviation;
        [JsonIgnore] public Harbor Harbor => _Harbor;
        /// <summary>
        /// Sorteringsordning.
        /// </summary>
        [JsonIgnore] public Int32 SortOrder => _SortOrder;
        /// <summary>
        /// Stopptyp.
        /// </summary>
        [JsonIgnore] public StopType StopType => _StopType;
        /// <summary>
        /// Tidpunkt för händelse.
        /// </summary>
        [JsonIgnore] public String Time => _Time;

        internal Schedule() { }
    }

    public sealed class Deviation
    {
        [JsonProperty("Description")] internal String _Description { get; set; }
        [JsonProperty("FromDate")] internal String _FromDate { get; set; }
        [JsonProperty("Id")] internal String _Id { get; set; }
        [JsonProperty("SpecDate")] internal String _SpecDate { get; set; }
        [JsonProperty("ToDate")] internal String _ToDate { get; set; }
        [JsonProperty("Type")] internal TrafikverketdotNET.Subs.Type _Type { get; set; }

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

        internal Deviation() { }
    }

    public sealed class Weekday
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

        internal Weekday() { }
    }

    public sealed class Valid
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

        internal Valid() { }
    }
}