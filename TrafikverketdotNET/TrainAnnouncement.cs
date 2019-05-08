using System;
using System.Net.Http;
using System.Threading.Tasks;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TrafikverketdotNET
{
    public sealed class FromLocation
    {
        [JsonProperty("LocationName")] internal String _LocationName { get; set; }
        [JsonProperty("Order")] internal Int32 _Order { get; set; }
        [JsonProperty("Priority")] internal Int32 _Priority { get; set; }

        /// <summary>
        /// Namn på frånstation. 
        /// Notera att det avser vad som ska annonseras för resenärerna, det vill säga vad som ska visas på skyltar o.dyl. 
        /// FromLocation kan med andra ord ha olika innehåll för samma tåg vid olika stationer och olika innehåll vad ankomster respektive avgångar. 
        /// Fältet anger hur från-stationer ska annonseras.
        /// </summary>
        [JsonIgnore] public String LocationName => _LocationName;
        /// <summary>
        /// Vilken ordning stationer ska visas.
        /// </summary>
        [JsonIgnore] public Int32 Order => _Order;
        /// <summary>
        /// Prioritet för vilka stationer som ska visas.
        /// </summary>
        [JsonIgnore] public Int32 Priority => _Priority;

        internal FromLocation() { }
    }

    public sealed class ToLocation
    {
        [JsonProperty("LocationName")] internal String _LocationName { get; set; }
        [JsonProperty("Order")] internal Int32 _Order { get; set; }
        [JsonProperty("Priority")] internal Int32 _Priority { get; set; }

        /// <summary>
        /// Tillstation för tåget. 
        /// Notera att det avser vad som ska annonseras för resenärerna, det vill säga vad som ska visas på skyltar o.dyl. 
        /// ToLocation kan med andra ord ha olika innehåll för samma tåg vid olika stationer och olika innehåll vad ankomster respektive avgångar. 
        /// Fältet anger hur till-stationer ska annonseras.
        /// </summary>
        [JsonIgnore] public String LocationName => _LocationName;
        /// <summary>
        /// Vilken ordning stationer ska visas.
        /// </summary>
        [JsonIgnore] public Int32 Order => _Order;
        /// <summary>
        /// Prioritet för vilka stationer som ska visas.
        /// </summary>
        [JsonIgnore] public Int32 Priority => _Priority;

        internal ToLocation() { }
    }

    public sealed class ViaFromLocation
    {
        [JsonProperty("LocationName")] internal String _LocationName { get; set; }
        [JsonProperty("Order")] internal Int32 _Order { get; set; }
        [JsonProperty("Priority")] internal Int32 _Priority { get; set; }

        /// <summary>
        /// Namn på via frånstation. 
        /// Notera att det avser vad som ska annonseras för resenärerna, det vill säga vad som ska visas på skyltar o.dyl.
        /// ViaFromLocation kan med andra ord ha olika innehåll för samma tåg vid olika stationer och olika innehåll vad ankomster respektive avgångar.
        /// Fältet anger hur från-stationer ska annonseras.
        /// </summary>
        [JsonIgnore] public String LocationName => _LocationName;
        /// <summary>
        /// Vilken ordning stationer ska visas.
        /// </summary>
        [JsonIgnore] public Int32 Order => _Order;
        /// <summary>
        /// Prioritet för vilka stationer som ska visas.
        /// </summary>
        [JsonIgnore] public Int32 Priority => _Priority;

        internal ViaFromLocation() { }
    }

    public sealed class ViaToLocation
    {
        [JsonProperty("LocationName")] internal String _LocationName { get; set; }
        [JsonProperty("Order")] internal Int32 _Order { get; set; }
        [JsonProperty("Priority")] internal Int32 _Priority { get; set; }

        /// <summary>
        /// Namn på vi. 
        /// Notera att det avser vad som ska annonseras för resenärerna, det vill säga vad som ska visas på skyltar o.dyl. 
        /// ViaToLocation kan med andra ord ha olika innehåll för samma tåg vid olika stationer och olika innehåll vad ankomster respektive avgångar. 
        /// Fältet anger hur till-stationer ska annonseras.
        /// </summary>
        [JsonIgnore] public String LocationName => _LocationName;
        /// <summary>
        /// Vilken ordning stationer ska visas.
        /// </summary>
        [JsonIgnore] public Int32 Order => _Order;
        /// <summary>
        /// Prioritet för vilka stationer som ska visas.
        /// </summary>
        [JsonIgnore] public Int32 Priority => _Priority;

        internal ViaToLocation() { }
    }

    public sealed class TrainAnnouncementResponse
    {
        [JsonProperty("ActivityId")] internal String _ActivityId { get; set; }
        [JsonProperty("ActivityType")] internal String _ActivityType { get; set; }
        [JsonProperty("Advertised")] internal Boolean _Advertised { get; set; }
        [JsonProperty("AdvertisedTimeAtLocation")] internal DateTime _AdvertisedTimeAtLocation { get; set; }
        [JsonProperty("AdvertisedTrainIdent")] internal String _AdvertisedTrainIdent { get; set; }
        [JsonProperty("Booking")] internal String[] _Booking { get; set; }
        [JsonProperty("Canceled")] internal Boolean _Canceled { get; set; }
        [JsonProperty("Deleted")] internal Boolean _Deleted { get; set; }
        [JsonProperty("Deviation")] internal String[] _Deviation { get; set; }
        [JsonProperty("EstimatedTimeAtLocation")] internal DateTime _EstimatedTimeAtLocation { get; set; }
        [JsonProperty("EstimatedTimeIsPreliminary")] internal Boolean _EstimatedTimeIsPreliminary { get; set; }
        [JsonProperty("InformationOwner")] internal String _InformationOwner { get; set; }
        [JsonProperty("LocationSignature")] internal String _LocationSignature { get; set; }
        [JsonProperty("MobileWebLink")] internal String _MobileWebLink { get; set; }
        [JsonProperty("ModifiedTime")] internal DateTime _ModifiedTime { get; set; }
        [JsonProperty("NewEquipment")] internal Int32 _NewEquipment { get; set; }
        [JsonProperty("Operator")] internal String _Operator { get; set; }
        [JsonProperty("OtherInformation")] internal String[] _OtherInformation { get; set; }
        [JsonProperty("PlannedEstimatedTimeAtLocation")] internal DateTime _PlannedEstimatedTimeAtLocation { get; set; }
        [JsonProperty("PlannedEstimatedTimeAtLocationIsValid")] internal Boolean _PlannedEstimatedTimeAtLocationIsValid { get; set; }
        [JsonProperty("ProductInformation")] internal String[] _ProductInformation { get; set; }
        [JsonProperty("ScheduledDepartureDateTime")] internal DateTime _ScheduledDepartureDateTime { get; set; }
        [JsonProperty("Service")] internal String[] _Service { get; set; }
        [JsonProperty("TechnicalDateTime")] internal DateTime _TechnicalDateTime { get; set; }
        [JsonProperty("TechnicalTrainIdent")] internal String _TechnicalTrainIdent { get; set; }
        [JsonProperty("TimeAtLocation")] internal DateTime _TimeAtLocation { get; set; }
        [JsonProperty("TimeAtLocationWithSeconds")] internal DateTime _TimeAtLocationWithSeconds { get; set; }
        [JsonProperty("TrackAtLocation")] internal String _TrackAtLocation { get; set; }
        [JsonProperty("TrainComposition")] internal String[] _TrainComposition { get; set; }
        [JsonProperty("TrainOwner")] internal String _TrainOwner { get; set; }
        [JsonProperty("TypeOfTraffic")] internal String _TypeOfTraffic { get; set; }
        [JsonProperty("WebLink")] internal String _WebLink { get; set; }
        [JsonProperty("WebLinkName")] internal String _WebLinkName { get; set; }
        [JsonProperty("FromLocation")] internal FromLocation[] _FromLocation { get; set; }
        [JsonProperty("ToLocation")] internal ToLocation[] _ToLocation { get; set; }
        [JsonProperty("ViaFromLocation")] internal ViaFromLocation[] _ViaFromLocation { get; set; }
        [JsonProperty("ViaToLocation")] internal ViaToLocation[] _ViaToLocation { get; set; }

        /// <summary>
        /// Aktivitetens unika id. Fältet är nyckel för objektet.
        /// </summary>
        [JsonIgnore] public String ActivityId => _ActivityId;
        /// <summary>
        /// "Ankomst" eller "Avgang".
        /// </summary>
        [JsonIgnore] public String ActivityType => _ActivityType;
        /// <summary>
        /// Anger om ankomsten/avgången annonseras i tidtabell.
        /// </summary>
        [JsonIgnore] public Boolean Advertised => _Advertised;
        /// <summary>
        /// Tidtabellstid.
        /// </summary>
        [JsonIgnore] public DateTime AdvertisedTimeAtLocation => _AdvertisedTimeAtLocation;
        /// <summary>
        /// Annonserat tågnummer (tågnumret som står på biljetten).
        /// </summary>
        [JsonIgnore] public String AdvertisedTrainIdent => _AdvertisedTrainIdent;
        /// <summary>
        /// Bokningsinformation, ex: "Vagn 4 obokad.".
        /// </summary>
        [JsonIgnore] public String[] Booking => _Booking;
        /// <summary>
        /// Anger om ankomsten/avgången är inställd.
        /// </summary>
        [JsonIgnore] public Boolean Canceled => _Canceled;
        /// <summary>
        /// Anger att dataposten raderats
        /// </summary>
        [JsonIgnore] public Boolean Deleted => _Deleted;
        /// <summary>
        /// Eventuell avvikelse, ex: "Buss ersätter", "Spårändrat", "Kort tåg", "Ej servering" o.s.v.
        /// </summary>
        [JsonIgnore] public String[] Deviation => _Deviation;
        /// <summary>
        /// Tidpunkt för beräknad ankomst eller avgång.
        /// </summary>
        [JsonIgnore] public DateTime EstimatedTimeAtLocation => _EstimatedTimeAtLocation;
        /// <summary>
        /// Anger om en beräknad tid är preliminär. 
        /// Notera att om den beräknade tiden är preliminär så innebär det att den kan ändras både framåt och bakåt, 
        /// ett tåg kan alltså t.ex avgå tidigare än beräknad tidpunkt om den också är markerad som preliminär.
        /// </summary>
        [JsonIgnore] public Boolean EstimatedTimeIsPreliminary => _EstimatedTimeIsPreliminary;
        /// <summary>
        /// Namnet på trafikinformationsägaren.
        /// </summary>
        [JsonIgnore] public String InformationOwner => _InformationOwner;
        /// <summary>
        /// Signatur för stationen.
        /// </summary>
        [JsonIgnore] public String LocationSignature => _LocationSignature;
        /// <summary>
        /// Url till trafikägarens mobila hemsida.
        /// </summary>
        [JsonIgnore] public String MobileWebLink => _MobileWebLink;
        /// <summary>
        /// Tidpunkt då dataposten ändrades.
        /// </summary>
        [JsonIgnore] public DateTime ModifiedTime => _ModifiedTime;
        /// <summary>
        /// Anger i vilken ordning tåget nyutrustats. Om ingen nyutrustning skett kommer värdet vara noll.
        /// </summary>
        [JsonIgnore] public Int32 NewEquipment => _NewEquipment;
        /// <summary>
        /// Det järnvägsföretag som utför järnvägstrafik, alltså kör tåget, för en trafikorganisatör.
        /// </summary>
        [JsonIgnore] public String Operator => _Operator;
        /// <summary>
        /// Övrig annonseringsinformation, ex. "Trevlig resa!", "Bakre fordon går låst!", "Ingen påstigning".
        /// </summary>
        [JsonIgnore] public String[] OtherInformation => _OtherInformation;
        /// <summary>
        /// Anger en planerad försening och dess giltighet anges med PlannedEstimatedTimeAtLocationIsValid-flaggan.
        /// </summary>
        [JsonIgnore] public DateTime PlannedEstimatedTimeAtLocation => _PlannedEstimatedTimeAtLocation;
        /// <summary>
        /// Anger om PlaneradBeraknadTid är giltig. Kommer sättas till false när en operativ beräknad tidrapport, tidrapport eller slopningsrapport skapas.
        /// </summary>
        [JsonIgnore] public Boolean PlannedEstimatedTimeAtLocationIsValid => _PlannedEstimatedTimeAtLocationIsValid;
        /// <summary>
        /// Beskrivning av tåget, ex. "Tågkompaniet", "SJ InterCity", "TiB/Tågkomp".
        /// </summary>
        [JsonIgnore] public String[] ProductInformation => _ProductInformation;
        /// <summary>
        /// Tågets annonserade avgångsdatum
        /// </summary>
        [JsonIgnore] public DateTime ScheduledDepartureDateTime => _ScheduledDepartureDateTime;
        /// <summary>
        /// Lite extra utöver produktinformation, ex "Bistro", "Sov-och liggv".
        /// </summary>
        [JsonIgnore] public String[] Service => _Service;
        /// <summary>
        /// Teknisk tid
        /// </summary>
        [JsonIgnore] public DateTime TechnicalDateTime => _TechnicalDateTime;
        /// <summary>
        /// Tekniskt tågnummer.
        /// </summary>
        [JsonIgnore] public String TechnicalTrainIdent => _TechnicalTrainIdent;
        /// <summary>
        /// När tåget har ankommit eller avgått.
        /// </summary>
        [JsonIgnore] public DateTime TimeAtLocation => _TimeAtLocation;
        /// <summary>
        /// När tåget har ankommit eller avgått, med sekunder
        /// </summary>
        [JsonIgnore] public DateTime TimeAtLocationWithSeconds => _TimeAtLocationWithSeconds;
        /// <summary>
        /// Spår.
        /// </summary>
        [JsonIgnore] public String TrackAtLocation => _TrackAtLocation;
        /// <summary>
        /// Tågsammansättning, ex: "Vagnsordning 7, 6, 5, 4, 2, 1".
        /// </summary>
        [JsonIgnore] public String[] TrainComposition => _TrainComposition;
        /// <summary>
        /// Ägaren av det aktuella tågläget.
        /// </summary>
        [JsonIgnore] public String TrainOwner => _TrainOwner;
        /// <summary>
        /// Trafiktypen, ex. "Tåg", "Direktbuss", "Extrabuss", "Ersättningsbuss", "Taxi".
        /// </summary>
        [JsonIgnore] public String TypeOfTraffic => _TypeOfTraffic;
        /// <summary>
        /// Url till trafikägarens hemsida.
        /// </summary>
        [JsonIgnore] public String WebLink => _WebLink;
        /// <summary>
        /// Namn på trafikinfoägaren att använda i länkar.
        /// </summary>
        [JsonIgnore] public String WebLinkName => _WebLinkName;
        [JsonIgnore] public FromLocation[] FromLocation => _FromLocation;
        [JsonIgnore] public ToLocation[] ToLocation => _ToLocation;
        [JsonIgnore] public ViaFromLocation[] ViaFromLocation => _ViaFromLocation;
        [JsonIgnore] public ViaToLocation[] ViaToLocation => _ViaToLocation;

        internal TrainAnnouncementResponse() { }
    }

    /// <summary>
    /// Tidtabellsinformation, d.v.s information om tåg på trafikplatser (stationer, hållplatser) varje post motsvarar ett visst tåg vid respektive trafikplats.
    /// </summary>
    public sealed class TrainAnnouncement : BaseTrafikverket<TrainAnnouncementResponse[]>
    {
        /// <summary>
        /// Tidtabellsinformation, d.v.s information om tåg på trafikplatser (stationer, hållplatser) varje post motsvarar ett visst tåg vid respektive trafikplats.
        /// </summary>
        /// <param name="APIKey">Användarens unika nyckel.</param>
        public TrainAnnouncement(String APIKey) : base(APIKey) { }

        public override TrainAnnouncementResponse[] ExecuteRequest() => ExecuteRequest("TrainAnnouncement", "1.4");
    }
}
