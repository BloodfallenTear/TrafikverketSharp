using System;
using TrafikverketdotNET.Subs;
using TrafikverketdotNET.Subs.MeasurementDataResponse;
using Newtonsoft.Json;

namespace TrafikverketdotNET
{
    public sealed class MeasurementData20Response : BaseTrafikverketResponse
    {
        [JsonProperty("County")] internal Int32 _County { get; set; }
        [JsonProperty("CrossfallRutBottom")] internal Double _CrossfallRutBottom { get; set; }
        [JsonProperty("Curvature")] internal Double _Curvature { get; set; }
        [JsonProperty("Deleted")] internal Boolean _Deleted { get; set; }
        [JsonProperty("Direction")] internal Direction _Direction { get; set; }
        [JsonProperty("EdgeDepth")] internal Double _EdgeDepth { get; set; }
        [JsonProperty("EndContinuousLength")] internal Int32 _EndContinuousLength { get; set; }
        [JsonProperty("Hilliness")] internal Double _Hilliness { get; set; }
        [JsonProperty("IRILeft")] internal Double _IRILeft { get; set; }
        [JsonProperty("IRIRight")] internal Double _IRIRight { get; set; }
        [JsonProperty("Lane")] internal Int32 _Lane { get; set; }
        [JsonProperty("Length")] internal Int32 _Length { get; set; }
        [JsonProperty("MeasurementDataType")] internal MeasurementDataType _MeasurementDataType { get; set; }
        [JsonProperty("MeasurementDate")] internal DateTime _MeasurementDate { get; set; }
        [JsonProperty("MeasurementDateSpecific")] internal DateTime _MeasurementDateSpecific { get; set; }
        [JsonProperty("MeasurementVehicleSpeed")] internal Double _MeasurementVehicleSpeed { get; set; }
        [JsonProperty("MegatextureLeft")] internal Double _MegatextureLeft { get; set; }
        [JsonProperty("MegatextureRight")] internal Double _MegatextureRight { get; set; }
        [JsonProperty("ModifiedTime")] internal DateTime _ModifiedTime { get; set; }
        [JsonProperty("MPDMacrotextureLeft")] internal Double _MPDMacrotextureLeft { get; set; }
        [JsonProperty("MPDMacrotextureMiddle")] internal Double _MPDMacrotextureMiddle { get; set; }
        [JsonProperty("MPDMacrotextureRight")] internal Double _MPDMacrotextureRight { get; set; }
        [JsonProperty("RoadMainNumber")] internal Int32 _RoadMainNumber { get; set; }
        [JsonProperty("RoadSubNumber")] internal Int32 _RoadSubNumber { get; set; }
        [JsonProperty("RutArea")] internal Double _RutArea { get; set; }
        [JsonProperty("RutBottomDistance")] internal Double _RutBottomDistance { get; set; }
        [JsonProperty("RutDepthLeft17")] internal Double _RutDepthLeft17 { get; set; }
        [JsonProperty("RutDepthMax15")] internal Double _RutDepthMax15 { get; set; }
        [JsonProperty("RutDepthMax17")] internal Double _RutDepthMax17 { get; set; }
        [JsonProperty("RutDepthRight15")] internal Double _RutDepthRight15 { get; set; }
        [JsonProperty("RutDepthRight17")] internal Double _RutDepthRight17 { get; set; }
        [JsonProperty("RutWidthLeft")] internal Double _RutWidthLeft { get; set; }
        [JsonProperty("RutWidthRight")] internal Double _RutWidthRight { get; set; }
        [JsonProperty("StartContinuousLength")] internal Int32 _StartContinuousLength { get; set; }
        [JsonProperty("TimeStamp")] internal DateTime _TimeStamp { get; set; }
        [JsonProperty("WaterArea")] internal Double _WaterArea { get; set; }

        /// <summary>
        /// Län. Fältet är nyckel för objektet.
        /// </summary>
        [JsonIgnore] public Int32 County => _County;
        /// <summary>
        /// Spårbottentvärfall. Enhet %.
        /// </summary>
        [JsonIgnore] public Double CrossfallRutBottom => _CrossfallRutBottom;
        /// <summary>
        /// Kurvatur. Enhet 10000/r. Kurvatur beskriver medelvärdet av krökningsradien (r) över 20m. 
        /// </summary>
        [JsonIgnore] public Double Curvature => _Curvature;
        /// <summary>
        /// Anger att dataposten raderats.
        /// </summary>
        [JsonIgnore] public Boolean Deleted => _Deleted;
        /// <summary>
        /// Riktning. 
        /// </summary>
        [JsonIgnore] public Direction Direction => _Direction;
        /// <summary>
        /// Kantdjup. Enhet mm. Kantdjup avser att detektera skador närmast vägrenen. 
        /// Mäts inte direkt av mätbil utan beräknas i efterbearbetning baserat på mätta 20m data om tvärprofil (se VTI Rapport 718).
        /// </summary>
        [JsonIgnore] public Double EdgeDepth => _EdgeDepth;
        /// <summary>
        /// Slut löpande längd. Anges i meter. 
        /// Slutet för aktuell data angivet i antal meter från vägnumrets start inom det länet, i aktuell riktning. Fältet är nyckel för objektet.
        /// </summary>
        [JsonIgnore] public Int32 EndContinuousLength => _EndContinuousLength;
        /// <summary>
        /// Backighet. Anges i %. Backighet är medellutningen för 20m väg i mätriktningen. Uppför har positivt tecken och utför negativt. 
        /// </summary>
        [JsonIgnore] public Double Hilliness => _Hilliness;
        /// <summary>
        /// IRI vänster. Enhet mm/m. IRI (International Roughness Index) Beräknat mått baserat på uppmätt längsprofil i vänster hjulspår. Avser jämnhet i längsled.
        /// </summary>
        [JsonIgnore] public Double IRILeft => _IRILeft;
        /// <summary>
        /// IRI höger. Enhet mm/m. IRI (International Roughness Index) Beräknat mått baserat på uppmätt längsprofil i höger hjulspår. Avser jämnhet i längsled.
        /// </summary>
        [JsonIgnore] public Double IRIRight => _IRIRight;
        /// <summary>
        /// Körfält. Räknas från höger sida och startar med körfält 10. Nästa är 20 och kan gå upp till 50. Fältet är nyckel för objektet.
        /// </summary>
        [JsonIgnore] public Int32 Lane => _Lane;
        /// <summary>
        /// Längd i antal meter.
        /// </summary>
        [JsonIgnore] public Int32 Length => _Length;
        /// <summary>
        /// Mätdatatyp. 
        /// </summary>
        [JsonIgnore] public MeasurementDataType MeasurementDataType => _MeasurementDataType;
        /// <summary>
        /// Mätdatum. Ett gemensamt datum för en hel mätperiod. Är detta datum som visas i graferna i PMSV3 Analysera sträcka. 
        /// </summary>
        [JsonIgnore] public DateTime MeasurementDate => _MeasurementDate;
        /// <summary>
        /// Mätdatum exakt. Det exakta mätdatumet för aktuellt mätdata. 
        /// </summary>
        [JsonIgnore] public DateTime MeasurementDateSpecific => _MeasurementDateSpecific;
        /// <summary>
        /// Mätbilens hastighet.
        /// </summary>
        [JsonIgnore] public Double MeasurementVehicleSpeed => _MeasurementVehicleSpeed;
        /// <summary>
        /// Megatextur vänster. Enhet mm.
        /// </summary>
        [JsonIgnore] public Double MegatextureLeft => _MegatextureLeft;
        /// <summary>
        /// Megatextur höger. Enhet mm. 
        /// </summary>
        [JsonIgnore] public Double MegatextureRight => _MegatextureRight;
        /// <summary>
        /// Tidpunkt då dataposten ändrades.
        /// </summary>
        [JsonIgnore] public DateTime ModifiedTime => _ModifiedTime;
        /// <summary>
        /// MPD Makrotextur vänster. Enhet mm. Makrotextur beräknad som MPD (Mean Profile Depth beräknat enligt ISO 13473-1), beskriver vägytans 'skrovlighet' i våglängdsintervallet 0,5-50 mm. 
        /// </summary>
        [JsonIgnore] public Double MPDMacrotextureLeft => _MPDMacrotextureLeft;
        /// <summary>
        /// MPD Makrotextur mellan. Enhet mm. Makrotextur beräknad som MPD (Mean Profile Depth beräknat enligt ISO 13473-1), beskriver vägytans 'skrovlighet' i våglängdsintervallet 0,5-50 mm.
        /// </summary>
        [JsonIgnore] public Double MPDMacrotextureMiddle => _MPDMacrotextureMiddle;
        /// <summary>
        /// MPD Makrotextur höger. Enhet mm. Makrotextur beräknad som MPD (Mean Profile Depth beräknat enligt ISO 13473-1), beskriver vägytans 'skrovlighet' i våglängdsintervallet 0,5-50 mm. 
        /// </summary>
        [JsonIgnore] public Double MPDMacrotextureRight => _MPDMacrotextureRight;
        /// <summary>
        /// Huvudvägnummer. Fältet är nyckel för objektet.
        /// </summary>
        [JsonIgnore] public Int32 RoadMainNumber => _RoadMainNumber;
        /// <summary>
        /// Undervägnummer. Kallas ibland även punktväg. Måste användas ihop med huvudvägnumret. Fältet är nyckel för objektet.
        /// </summary>
        [JsonIgnore] public Int32 RoadSubNumber => _RoadSubNumber;
        /// <summary>
        /// Spårarea. Enhet dm2. Mått för deformation i tvärled, komplement till spårdjup max. 
        /// Mäts inte direkt av mätbil utan beräknas i efterbearbetning baserat på mätta 20m data om tvärprofil (se VTI Rapport 718).
        /// </summary>
        [JsonIgnore] public Double RutArea => _RutArea;
        /// <summary>
        /// Spårbottenavstånd. Enhet mm. Avstånd mellan de djupaste spåren i vänster resp höger del av tvärprofilen. 
        /// Mäts inte direkt av mätbil utan beräknas i efterbearbetning baserat på mätta 20m data om tvärprofil (se VTI Rapport 718). 
        /// </summary>
        [JsonIgnore] public Double RutBottomDistance => _RutBottomDistance;
        /// <summary>
        /// Spårdjup vänster17. Enhet mm. 17 lasrar.
        /// </summary>
        [JsonIgnore] public Double RutDepthLeft17 => _RutDepthLeft17;
        /// <summary>
        /// Spårdjup max15. Maxvärde 15 lasrar.
        /// </summary>
        [JsonIgnore] public Double RutDepthMax15 => _RutDepthMax15;
        /// <summary>
        /// Spårdjup max17. Maxvärde 17 lasrar.
        /// </summary>
        [JsonIgnore] public Double RutDepthMax17 => _RutDepthMax17;
        /// <summary>
        /// Spårdjup höger15. Enhet mm. 15 lasrar. 
        /// </summary>
        [JsonIgnore] public Double RutDepthRight15 => _RutDepthRight15;
        /// <summary>
        /// Spårdjup höger17. Enhet mm. 17 lasrar. 
        /// </summary>
        [JsonIgnore] public Double RutDepthRight17 => _RutDepthRight17;
        /// <summary>
        /// Spårbredd vänster. Enhet mm. Vänster hjulspårs bredd. 
        /// Mäts inte direkt av mätbil utan beräknas i efterbearbetning baserat på mätta 20m data om tvärprofil (se VTI Rapport 718).
        /// </summary>
        [JsonIgnore] public Double RutWidthLeft => _RutWidthLeft;
        /// <summary>
        /// Spårbredd höger. Enhet mm. Höger hjulspårs bredd. 
        /// Mäts inte direkt av mätbil utan beräknas i efterbearbetning baserat på mätta 20m data om tvärprofil (se VTI Rapport 718).
        /// </summary>
        [JsonIgnore] public Double RutWidthRight => _RutWidthRight;
        /// <summary>
        /// Start löpande längd. Anges i meter. Starten för aktuell data angivet i antal meter från vägnumrets start inom det länet, i aktuell riktning. Fältet är nyckel för objektet.
        /// </summary>
        [JsonIgnore] public Int32 StartContinuousLength => _StartContinuousLength;
        /// <summary>
        /// Datum för när mätdata hämtades ut från källsystemen.
        /// </summary>
        [JsonIgnore] public DateTime TimeStamp => _TimeStamp;
        /// <summary>
        /// Vattenarea. Enhet dm2. Mått för deformation i tvärled, komplement till spårdjup max. 
        /// Mäts inte direkt av mätbil utan beräknas i efterbearbetning baserat på mätta 20m data om tvärprofil (se VTI Rapport 718).
        /// </summary>
        [JsonIgnore] public Double WaterArea => _WaterArea;

        internal MeasurementData20Response() { }
    }

    public class MeasurementData20Request : BaseTrafikverketRequest
    {
        public override ObjectType ObjectType => ObjectType.MeasurementData100;
        public override string SchemaVersion => Trafikverket.SchemaVersions[this.ObjectType];

        public MeasurementData20Request(Filter Filter) : base(Filter) { }
        public MeasurementData20Request(String ID = null, Boolean IncludeDeletedObjects = false,
                                        UInt32 Limit = 0, String OrderBy = null, UInt32 Skip = 0,
                                        Boolean LastModified = false, Int32 ChangeID = 0,
                                        String Include = null, String Exclude = null, String Distinct = null) : base(ID, IncludeDeletedObjects,
                                                                                                                     Limit, OrderBy, Skip, LastModified,
                                                                                                                     ChangeID, Include, Exclude, Distinct) { }
        public MeasurementData20Request(String ID = null, Boolean IncludeDeletedObjects = false,
                                        UInt32 Limit = 0, String OrderBy = null, UInt32 Skip = 0,
                                        Boolean LastModified = false, Int32 ChangeID = 0,
                                        String Include = null, String Exclude = null, String Distinct = null, Filter Filter = null) : base(ID, IncludeDeletedObjects,
                                                                                                                                           Limit, OrderBy, Skip, LastModified,
                                                                                                                                           ChangeID, Include, Exclude, Distinct, Filter) { }
        public MeasurementData20Request(String ID = null, Boolean IncludeDeletedObjects = false,
                                        UInt32 Limit = 0, String OrderBy = null, UInt32 Skip = 0,
                                        Boolean LastModified = false, Int32 ChangeID = 0,
                                        String[] Include = null, String[] Exclude = null, String Distinct = null) : base(ID, IncludeDeletedObjects,
                                                                                                                                 Limit, OrderBy, Skip, LastModified,
                                                                                                                                 ChangeID, Include, Exclude, Distinct) { }
        public MeasurementData20Request(String ID = null, Boolean IncludeDeletedObjects = false,
                                        UInt32 Limit = 0, String OrderBy = null, UInt32 Skip = 0,
                                        Boolean LastModified = false, Int32 ChangeID = 0,
                                        String[] Include = null, String[] Exclude = null, String Distinct = null, Filter Filter = null) : base(ID, IncludeDeletedObjects,
                                                                                                                                                       Limit, OrderBy, Skip, LastModified,
                                                                                                                                                       ChangeID, Include, Exclude, Distinct, Filter) { }

    }

    /// <summary>
    /// Mätdata per 20 meter. 
    /// Data från vägytemätningar med laserscanning alternativt som beräknats fram baserat på dem. 
    /// Mätningarna utförs årligen eller vartannat år beroende på trafikmängd. 
    /// Senast gällande mätdata finns att hämta dvs ej historik. 
    /// Källsystem är PMS-systemen.
    /// </summary>
    /// <exception cref="Exception">Thrown when there's an error returned from Trafikverket.</exception>
    public sealed class MeasurementData20 : BaseTrafikverket<MeasurementData20Response[]>
    {
        /// <summary>
        /// Mätdata per 20 meter. 
        /// Data från vägytemätningar med laserscanning alternativt som beräknats fram baserat på dem. 
        /// Mätningarna utförs årligen eller vartannat år beroende på trafikmängd. 
        /// Senast gällande mätdata finns att hämta dvs ej historik. 
        /// Källsystem är PMS-systemen.
        /// </summary>
        /// <param name="APIKey">Användarens unika nyckel.</param>
        /// <exception cref="Exception">Thrown when there's an error returned from Trafikverket.</exception>
        public MeasurementData20(String APIKey) : base(APIKey) { }

        internal override ObjectType ObjectType => ObjectType.MeasurementData20;
        /// <summary>
        /// SchemaVersion versionen som biblioteken använder.
        /// </summary>
        public override String CurrentSchemaVersion => Trafikverket.SchemaVersions[this.ObjectType];

        public override MeasurementData20Response[] ExecuteRequest() => base.ExecuteRequest("MeasurementData20", CurrentSchemaVersion);
        /// <param name="XMLRequest">Custom requests must be written in XML, check "https://api.trafikinfo.trafikverket.se/API/TheRequest" in order to create custom requests.</param>
        public override MeasurementData20Response[] ExecuteRequest(String XMLRequest) => base.ExecuteRequest("MeasurementData20", CurrentSchemaVersion, XMLRequest);
        public override MeasurementData20Response[] ExecuteRequest(BaseTrafikverketRequest Request) => base.ExecuteCustomRequest(Request);
    }
}
