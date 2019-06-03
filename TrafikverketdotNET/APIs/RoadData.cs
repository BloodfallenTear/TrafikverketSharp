using System;
using TrafikverketdotNET.Subs;
using TrafikverketdotNET.Subs.RoadDataResponse;
using Newtonsoft.Json;

namespace TrafikverketdotNET
{
    public sealed class RoadDataResponse
    {
        [JsonProperty("AADT")] internal Int32 _AADT { get; set; }
        [JsonProperty("AADTHeavyVehicles")] internal Int32 _AADTHeavyVehicles { get; set; }
        [JsonProperty("AADTMeasurementMethod")] internal AADTMeasurementMethod _AADTMeasurementMethod { get; set; }
        [JsonProperty("AADTMeasurementYear")] internal Int32 _AADTMeasurementYear { get; set; }
        [JsonProperty("BearingCapacity")] internal BearingCapacity _BearingCapacity { get; set; }
        [JsonProperty("County")] internal Int32 _County { get; set; }
        [JsonProperty("Deleted")] internal Boolean _Deleted { get; set; }
        [JsonProperty("Direction")] internal Direction _Direction { get; set; }
        [JsonProperty("EndContinuousLength")] internal Int32 _EndContinuousLength { get; set; }
        [JsonProperty("LaneDescription")] internal Int32 _LaneDescription { get; set; }
        [JsonProperty("Length")] internal Int32 _Length { get; set; }
        [JsonProperty("ModifiedTime")] internal DateTime _ModifiedTime { get; set; }
        [JsonProperty("RoadCategory")] internal RoadCategory _RoadCategory { get; set; }
        [JsonProperty("RoadConstruction2009")] internal Int32 _RoadConstruction2009 { get; set; }
        [JsonProperty("RoadMainNumber")] internal Int32 _RoadMainNumber { get; set; }
        [JsonProperty("RoadOwner")] internal RoadOwner _RoadOwner { get; set; }
        [JsonProperty("RoadSubNumber")] internal Int32 _RoadSubNumber { get; set; }
        [JsonProperty("RoadType")] internal RoadType _RoadType { get; set; }
        [JsonProperty("RoadWidth")] internal Double _RoadWidth { get; set; }
        [JsonProperty("SpeedLimit")] internal Int32 _SpeedLimit { get; set; }
        [JsonProperty("StartContinuousLength")] internal Int32 _StartContinuousLength { get; set; }
        [JsonProperty("TimeStamp")] internal DateTime _TimeStamp { get; set; }
        [JsonProperty("WearLayer")] internal Int32 _WearLayer { get; set; }
        [JsonProperty("Winter2003")] internal Winter2003 _Winter2003 { get; set; }

        /// <summary>
        /// ÅDT fordon. På mötesseparerad väg anges ÅDT för en riktning i taget. 
        /// Dvs. den siffra som anges är trafiken i en riktning. 
        /// På vanlig väg, dvs där trafiken går i båda riktningar, utan mittseparering, gäller ÅDT-siffran båda riktningar tillsammans. 
        /// Om det finns fler än ett körfält gäller angivna ÅDT-siffran för alla körfält tillsammans. 
        /// T.ex: Om ÅDT = 20000 fordon och det finns 3 körfält, så kommer ÅDT att anges som 20000 för varje körfält. 
        /// </summary>
        [JsonIgnore] public Int32 AADT => _AADT;
        /// <summary>
        /// ÅDT tung. ÅDT lastbilar avser trafikflöde lastbilar (Antal lastbilar per årsmedeldygn). 
        /// </summary>
        [JsonIgnore] public Int32 AADTHeavyVehicles => _AADTHeavyVehicles;
        /// <summary>
        /// ÅDT mätmetod. 
        /// </summary>
        [JsonIgnore] public AADTMeasurementMethod AADTMeasurementMethod => _AADTMeasurementMethod;
        /// <summary>
        /// ÅDT mätår.
        /// </summary>
        [JsonIgnore] public Int32 AADTMeasurementYear => _AADTMeasurementYear;
        /// <summary>
        /// Bärighetsklass. Upplåten bärighetsklass på statliga och kommunala vägar. 
        /// </summary>
        [JsonIgnore] public BearingCapacity BearingCapacity => _BearingCapacity;
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
        /// Slut löpande längd. Anges i meter. 
        /// Slutet för aktuell data angivet i antal meter från vägnumrets start inom det länet, i aktuell riktning. Fältet är nyckel för objektet. 
        /// </summary>
        [JsonIgnore] public Int32 EndContinuousLength => _EndContinuousLength;
        /// <summary>
        /// Körfältsbeskrivning. Beskrivning av körfältskombinationer, främst för att utskilja vilka vägar som har s.k. 2+1 körfältsuppdelning. 
        /// </summary>
        [JsonIgnore] public Int32 LaneDescription => _LaneDescription;
        /// <summary>
        /// Längd.
        /// </summary>
        [JsonIgnore] public Int32 Length => _Length;
        /// <summary>
        /// Tidpunkt då dataposten ändrades.
        /// </summary>
        [JsonIgnore] public DateTime ModifiedTime => _ModifiedTime;
        /// <summary>
        /// Vägkategori. 
        /// </summary>
        [JsonIgnore] public RoadCategory RoadCategory => _RoadCategory;
        /// <summary>
        /// Vägnybyggnadsår 2009. Det årtal som en nybyggnad utförts på vägen, vägsträckan byggdes, och det årtal som ett förstärkningsarbete utförts på en vägsträcka. 
        /// </summary>
        [JsonIgnore] public Int32 RoadConstruction2009 => _RoadConstruction2009;
        /// <summary>
        /// Huvudvägnummer. Fältet är nyckel för objektet.
        /// </summary>
        [JsonIgnore] public Int32 RoadMainNumber => _RoadMainNumber;
        /// <summary>
        /// Väghållare. 
        /// </summary>
        [JsonIgnore] public RoadOwner RoadOwner => _RoadOwner;
        /// <summary>
        /// Undervägnummer. Kallas ibland även punktväg. Måste användas ihop med huvudvägnumret. Fältet är nyckel för objektet.
        /// </summary>
        [JsonIgnore] public Int32 RoadSubNumber => _RoadSubNumber;
        /// <summary>
        /// Vägtyp. 
        /// </summary>
        [JsonIgnore] public RoadType RoadType => _RoadType;
        /// <summary>
        /// Vägbredd.
        /// </summary>
        [JsonIgnore] public Double RoadWidth => _RoadWidth;
        /// <summary>
        /// Hastighetsgräns. Skyltad hastighet. Vid variabel hastighet visar pmsv3 1000 km/h för att markera att hastigheten inte är entydig. 
        /// </summary>
        [JsonIgnore] public Int32 SpeedLimit => _SpeedLimit;
        /// <summary>
        /// Start löpande längd. Anges i meter. Starten för aktuell data angivet i antal meter från vägnumrets start inom det länet, i aktuell riktning. Fältet är nyckel för objektet.
        /// </summary>
        [JsonIgnore] public Int32 StartContinuousLength => _StartContinuousLength;
        /// <summary>
        /// Datum för när vägdata hämtades ut från källsystemet.
        /// </summary>
        [JsonIgnore] public DateTime TimeStamp => _TimeStamp;
        /// <summary>
        /// Slitlager.
        /// </summary>
        [JsonIgnore] public Int32 WearLayer => _WearLayer;
        /// <summary>
        /// Vinter2003. Vinter2003/Klassificering map vinterväghållningstandard. 
        /// </summary>
        [JsonIgnore] public Winter2003 Winter2003 => _Winter2003;

        internal RoadDataResponse() { }
    }

    public class RoadDataRequest : BaseTrafikverketRequest { public RoadDataRequest(Query Query) : base(Query) { } }

    public sealed class RoadData : BaseTrafikverket<RoadDataResponse[]>
    {
        /// <summary>
        /// Vägdata från NVDB som är relevant tillsammans med PMS-systemens beläggnings och mätdata. 
        /// Vi kan ej garantera att det är dagsaktuell data från NVDB. Datum för när data hämtades framgår av posten TimeStamp. 
        /// För att se källa för respektive data, gå till fliken Om variabler i systemet PMSV3.
        /// </summary>
        /// <param name="APIKey">Användarens unika nyckel.</param>
        public RoadData(String APIKey) : base(APIKey) { }

        /// <summary>
        /// SchemaVersion versionen som biblioteken använder.
        /// </summary>
        public override String CurrentSchemaVersion => "1";

        public override RoadDataResponse[] ExecuteRequest() => base.ExecuteRequest("RoadData", CurrentSchemaVersion);
        /// <param name="XMLRequest">Custom requests must be written in XML, check "https://api.trafikinfo.trafikverket.se/API/TheRequest" in order to create custom requests.</param>
        public override RoadDataResponse[] ExecuteRequest(String XMLRequest) => base.ExecuteRequest("RoadData", CurrentSchemaVersion, XMLRequest);
        public override RoadDataResponse[] ExecuteRequest(BaseTrafikverketRequest Request) => base.ExecuteCustomRequest(Request);
    }
}
