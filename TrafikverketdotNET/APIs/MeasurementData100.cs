using System;
using TrafikverketdotNET.Subs;
using TrafikverketdotNET.Subs.MeasurementDataResponse;
using Newtonsoft.Json;

namespace TrafikverketdotNET
{
    public sealed class MeasurementData100Response : BaseTrafikverketResponse
    {
        [JsonProperty("County")] internal Int32 _County { get; set; }
        [JsonProperty("Deleted")] internal Boolean _Deleted { get; set; }
        [JsonProperty("Direction")] internal Direction _Direction { get; set; }
        [JsonProperty("EdgeDepthAverageValue")] internal Double _EdgeDepthAverageValue { get; set; }
        [JsonProperty("EndContinuousLength")] internal Int32 _EndContinuousLength { get; set; }
        [JsonProperty("IRIRightAverageValue")] internal Double _IRIRightAverageValue { get; set; }
        [JsonProperty("Lane")] internal Int32 _Lane { get; set; }
        [JsonProperty("Length")] internal Int32 _Length { get; set; }
        [JsonProperty("MeasurementDataType")] internal MeasurementDataType _MeasurementDataType { get; set; }
        [JsonProperty("MeasurementDate")] internal DateTime _MeasurementDate { get; set; }
        [JsonProperty("MeasurementDateSpecific")] internal DateTime _MeasurementDateSpecific { get; set; }
        [JsonProperty("ModifiedTime")] internal DateTime _ModifiedTime { get; set; }
        [JsonProperty("MPDMacrotextureAverageValue")] internal Double _MPDMacrotextureAverageValue { get; set; }
        [JsonProperty("RoadMainNumber")] internal Int32 _RoadMainNumber { get; set; }
        [JsonProperty("RoadSubNumber")] internal Int32 _RoadSubNumber { get; set; }
        [JsonProperty("RutDepthMax15AverageValue")] internal Double _RutDepthMax15AverageValue { get; set; }
        [JsonProperty("RutDepthMax17AverageValue")] internal Double _RutDepthMax17AverageValue { get; set; }
        [JsonProperty("StartContinuousLength")] internal Int32 _StartContinuousLength { get; set; }
        [JsonProperty("TimeStamp")] internal DateTime _TimeStamp { get; set; }

        /// <summary>
        /// Län. Fältet är nyckel för objektet.
        /// </summary>
        [JsonIgnore] public Int32 County => _County;
        /// <summary>
        /// Anger att dataposten raderats
        /// </summary>
        [JsonIgnore] public Boolean Deleted => _Deleted;
        /// <summary>
        /// Riktning.
        /// </summary>
        [JsonIgnore] public Direction Direction => _Direction;
        /// <summary>
        /// Kantdjup medelvärde. 
        /// Kantdjup avser att detektera skador närmast vägrenen. 
        /// Mäts inte direkt av mätbil utan beräknas i efterbearbetning baserat på mätta 20m data om tvärprofil. 
        /// </summary>
        [JsonIgnore] public Double EdgeDepthAverageValue => _EdgeDepthAverageValue;
        /// <summary>
        /// Slut löpnande längd. Anges i meter. 
        /// Slutet för aktuell åtgärdsinformation angivet i antal meter från vägnumrets start inom det länet, i aktuell riktning. Fältet är nyckel för objektet.
        /// </summary>
        [JsonIgnore] public Int32 EndContinuousLength => _EndContinuousLength;
        /// <summary>
        /// IRI höger medelvärde. Avser jämnhet i längsled. IRI (International Roughness Index). 
        /// Beräknat mått baserat på uppmätt längsprofil i höger hjulspår. 
        /// </summary>
        [JsonIgnore] public Double IRIRightAverageValue => _IRIRightAverageValue;
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
        /// Tidpunkt då dataposten ändrades.
        /// </summary>
        [JsonIgnore] public DateTime ModifiedTime => _ModifiedTime;
        /// <summary>
        /// MPD Makrotextur medelvärde. 
        /// Beskriver vägytans 'skrovlighet' i våglängdsintervallet 0,5-50 mm. Makrotextur beräknad som MPD (Mean Profile Depth beräknat enligt ISO 13473-1).
        /// </summary>
        [JsonIgnore] public Double MPDMacrotextureAverageValue => _MPDMacrotextureAverageValue;
        /// <summary>
        /// Huvudvägnummer. Fältet är nyckel för objektet.
        /// </summary>
        [JsonIgnore] public Int32 RoadMainNumber => _RoadMainNumber;
        /// <summary>
        /// Undervägnummer. Kallas ibland även punktväg. Måste användas ihop med huvudvägnumret. Fältet är nyckel för objektet.
        /// </summary>
        [JsonIgnore] public Int32 RoadSubNumber => _RoadSubNumber;
        /// <summary>
        /// Spårdjup max15 medelvärde. 15 lasrar.
        /// </summary>
        [JsonIgnore] public Double RutDepthMax15AverageValue => RutDepthMax15AverageValue;
        /// <summary>
        /// Spårdjup max17 medelvärde. 17 lasrar. 
        /// Medelvärdet av de största spårdjupen beräknade enligt 'trådprincipen' för 200 profiler inom 20m sträckan. 
        /// Se TRV metodbeskrivningar för vägytemätning. 
        /// </summary>
        [JsonIgnore] public Double RutDepthMax17AverageValue => _RutDepthMax17AverageValue;
        /// <summary>
        /// Start löpande längd. Anges i meter. 
        /// Starten för aktuell åtgärdsinformation angivet i antal meter från vägnumrets start inom det länet, i aktuell riktning. Fältet är nyckel för objektet.
        /// </summary>
        [JsonIgnore] public Int32 StartContinuousLength => _StartContinuousLength;
        /// <summary>
        /// Datum för när mätdata hämtades ut från källsystemen och 100m-data skapades.
        /// </summary>
        [JsonIgnore] public DateTime TimeStamp => _TimeStamp;
    }

    public class MeasurementData100Request : BaseTrafikverketRequest
    {
        public override ObjectType ObjectType => ObjectType.MeasurementData100;
        public override string SchemaVersion => Trafikverket.SchemaVersions[this.ObjectType];

        public MeasurementData100Request(Filter Filter) : base(Filter) { }
        public MeasurementData100Request(String ID = null, Boolean IncludeDeletedObjects = false,
                                         UInt32 Limit = 0, String OrderBy = null, UInt32 Skip = 0,
                                         Boolean LastModified = false, Int32 ChangeID = 0,
                                         String[] Include = null, String[] Exclude = null, String Distinct = null, Filter Filter = null) : base(ID, IncludeDeletedObjects,
                                                                                                                                                        Limit, OrderBy, Skip, LastModified,
                                                                                                                                                        ChangeID, Include, Exclude, Distinct, Filter){ }
    }

    /// <summary>
    /// Mätdata per 100 meter. 
    /// Ett medelvärde har räknats fram för 100 meter baserat på de ingående 20-metersvärdena (se mer info i MeasurementData20). 
    /// Observera att det inte finns 100-metersdata för alla våra 20-metersvariabler. 
    /// Källsystem är PMS-systemen.
    /// </summary>
    public sealed class MeasurementData100 : BaseTrafikverket<MeasurementData100Response, MeasurementData100Request>
    {
        /// <summary>
        /// Mätdata per 100 meter. 
        /// Ett medelvärde har räknats fram för 100 meter baserat på de ingående 20-metersvärdena (se mer info i MeasurementData20). 
        /// Observera att det inte finns 100-metersdata för alla våra 20-metersvariabler. 
        /// Källsystem är PMS-systemen.
        /// </summary>
        /// <param name="APIKey">Användarens unika nyckel.</param>
        /// <exception cref="TrafikverketException">Thrown when there's an error returned from Trafikverket.</exception>
        public MeasurementData100(String APIKey) : base(APIKey) { }

        internal override ObjectType ObjectType => ObjectType.MeasurementData100;
        /// <summary>
        /// SchemaVersion versionen som biblioteken använder.
        /// </summary>
        public override String CurrentSchemaVersion => Trafikverket.SchemaVersions[this.ObjectType];

        /// <exception cref="TrafikverketException">Thrown when there's an error returned from Trafikverket.</exception>
        public override MeasurementData100Response[] ExecuteRequest() => base.ExecuteRequest("MeasurementData100", CurrentSchemaVersion);
        /// <param name="XMLRequest">Custom requests must be written in XML, check "https://api.trafikinfo.trafikverket.se/API/TheRequest" in order to create custom requests.</param>
        /// <exception cref="TrafikverketException">Thrown when there's an error returned from Trafikverket.</exception>
        public override MeasurementData100Response[] ExecuteRequest(String XMLRequest) => base.ExecuteRequest("MeasurementData100", CurrentSchemaVersion, XMLRequest);
        /// <exception cref="TrafikverketException">Thrown when there's an error returned from Trafikverket.</exception>
        public override MeasurementData100Response[] ExecuteRequest(MeasurementData100Request Request) => base.ExecuteCustomRequest(Request);
    }
}
