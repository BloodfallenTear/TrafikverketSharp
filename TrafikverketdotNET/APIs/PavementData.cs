using System;
using System.Collections.Generic;
using TrafikverketdotNET.Subs;
using Newtonsoft.Json;

namespace TrafikverketdotNET
{
    public sealed class PavementDataResponse : BaseTrafikverketResponse
    {
        [JsonProperty("BallMillValue")] internal Double _BallMillValue { get; set; }
        [JsonProperty("Binder")] internal String _Binder { get; set; }
        [JsonProperty("Contractor")] internal String _Contractor { get; set; }
        [JsonProperty("County")] internal Int32 _County { get; set; }
        [JsonProperty("Coverage")] internal String _Coverage { get; set; }
        [JsonProperty("Deleted")] internal Boolean _Deleted { get; set; }
        [JsonProperty("Direction")] internal Direction _Direction { get; set; }
        [JsonProperty("EndContinuousLength")] internal Int32 _EndContinuousLength { get; set; }
        [JsonProperty("FinalInspectionDate")] internal DateTime _FinalInspectionDate { get; set; }
        [JsonProperty("Lane")] internal Int32 _Lane { get; set; }
        [JsonProperty("Length")] internal Int32 _Length { get; set; }
        [JsonProperty("ManufacturingMethod")] internal String _ManufacturingMethod { get; set; }
        [JsonProperty("MaxStoneSize")] internal Int32 _MaxStoneSize { get; set; }
        [JsonProperty("ModifiedTime")] internal DateTime _ModifiedTime { get; set; }
        [JsonProperty("PavementDate")] internal DateTime _PavementDate { get; set; }
        [JsonProperty("PavementType")] internal String _PavementType { get; set; }
        [JsonProperty("PavingMethod")] internal String _PavingMethod { get; set; }
        [JsonProperty("RoadMainNumber")] internal Int32 _RoadMainNumber { get; set; }
        [JsonProperty("RoadSubNumber")] internal Int32 _RoadSubNumber { get; set; }
        [JsonProperty("StartContinuousLength")] internal Int32 _StartContinuousLength { get; set; }
        [JsonProperty("Thickness")] internal Double _Thickness { get; set; }
        [JsonProperty("TimeStamp")] internal DateTime _TimeStamp { get; set; }
        [JsonProperty("TreatmentCategory")] internal String _TreatmentCategory { get; set; }
        [JsonProperty("Warranty")] internal Int32 _Warranty { get; set; }
        [JsonProperty("WarrantyIsDue")] internal DateTime _WarrantyIsDue { get; set; }

        /// <summary>
        /// Kulkvarnsvärde som är aktuell i beläggningsåtgärden.
        /// </summary>
        [JsonIgnore] public Double BallMillValue => _BallMillValue;
        /// <summary>
        /// Bindemedel som är aktuellt i beläggningen. 
        /// </summary>
        [JsonIgnore] public String Binder => _Binder;
        /// <summary>
        /// Entreprenör. Den som utfört åtgärden.
        /// </summary>
        [JsonIgnore] public String Contractor => _Contractor;
        /// <summary>
        /// Län. Fältet är nyckel för objektet.
        /// </summary>
        [JsonIgnore] public Int32 County => _County;
        /// <summary>
        /// Täckning. I vilken utsträckning åtgärden omfattar hela längden angiven för åtgärden eller bredden på körfältet. 
        /// </summary>
        [JsonIgnore] public String Coverage => _Coverage;
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
        /// Slutet för aktuell åtgärdsinformation angivet i antal meter från vägnumrets start inom det länet, i aktuell riktning. Fältet är nyckel för objektet.
        /// </summary>
        [JsonIgnore] public Int32 EndContinuousLength => _EndContinuousLength;
        /// <summary>
        /// Datum för besiktningen av åtgärden.
        /// </summary>
        [JsonIgnore] public DateTime FinalInspectionDate => _FinalInspectionDate;
        /// <summary>
        /// Körfält. Räknas från höger sida och startar med körfält 10. Nästa är 20 och kan gå upp till 50. Fältet är nyckel för objektet.
        /// </summary>
        [JsonIgnore] public Int32 Lane => _Lane;
        /// <summary>
        /// Längd i antal meter.
        /// </summary>
        [JsonIgnore] public Int32 Length => _Length;
        /// <summary>
        /// Tillverkningsmetod som använts för beläggningen.
        /// </summary>
        [JsonIgnore] public String ManufacturingMethod => _ManufacturingMethod;
        /// <summary>
        /// Stenstorlek i beläggningen.
        /// </summary>
        [JsonIgnore] public Int32 MaxStoneSize => _MaxStoneSize;
        /// <summary>
        /// Tidpunkt då dataposten ändrades.
        /// </summary>
        [JsonIgnore] public DateTime ModifiedTime => _ModifiedTime;
        /// <summary>
        /// Beläggningsdatum. Datum när åtgärd utfördes (om flera åtgärder på samma sträcka anges senaste datumet).
        /// </summary>
        [JsonIgnore] public DateTime PavementDate => _PavementDate;
        /// <summary>
        /// Typ av åtgärd. 
        /// </summary>
        [JsonIgnore] public String PavementType => _PavementType;
        /// <summary>
        /// Utläggningsmetod.
        /// </summary>
        [JsonIgnore] public String PavingMethod => _PavingMethod;
        /// <summary>
        /// Huvudvägnummer. Fältet är nyckel för objektet.
        /// </summary>
        [JsonIgnore] public Int32 RoadMainNumber => _RoadMainNumber;
        /// <summary>
        /// Undervägnummer. Kallas ibland även punktväg. Måste användas ihop med huvudvägnumret. Fältet är nyckel för objektet.
        /// </summary>
        [JsonIgnore] public Int32 RoadSubNumber => _RoadSubNumber;
        /// <summary>
        /// Start löpande längd. Anges i meter. 
        /// Starten för aktuell åtgärdsinformation angivet i antal meter från vägnumrets start inom det länet, i aktuell riktning. Fältet är nyckel för objektet.
        /// </summary>
        [JsonIgnore] public Int32 StartContinuousLength => _StartContinuousLength;
        /// <summary>
        /// Tjocklek. Medelvärde för beläggningsåtgärdens tjocklek. 
        /// </summary>
        [JsonIgnore] public Double Thickness => _Thickness;
        /// <summary>
        /// Datum för när NVDB-data och beläggningsdata hämtades ut från källsystemen.
        /// </summary>
        [JsonIgnore] public DateTime TimeStamp => _TimeStamp;
        /// <summary>
        /// Åtgärdskategori. Gruppering av åtgärder som är av liknande karaktär. 
        /// </summary>
        [JsonIgnore] public String TreatmentCategory => _TreatmentCategory;
        /// <summary>
        /// Garantitid. Det antal år som garantitiden gäller för utförd åtgärd. 
        /// </summary>
        [JsonIgnore] public Int32 Warranty => _Warranty;
        /// <summary>
        /// Garantitid förfaller år. Datum då garantin för åtgärden förfaller.
        /// </summary>
        [JsonIgnore] public DateTime WarrantyIsDue => _WarrantyIsDue;

        internal PavementDataResponse() { }
    }

    public class PavementDataRequest : BaseTrafikverketRequest
    {
        public override ObjectType ObjectType => ObjectType.PavementData;
        public override string SchemaVersion => Trafikverket.SchemaVersions[this.ObjectType];

        public PavementDataRequest(Filter Filter) : base(Filter) { }
        public PavementDataRequest(String ID = null, Boolean IncludeDeletedObjects = false,
                                   UInt32 Limit = 0, String OrderBy = null, UInt32 Skip = 0,
                                   Boolean LastModified = false, Int32 ChangeID = 0,
                                   String Include = null, String Exclude = null, String Distinct = null) : base(ID, IncludeDeletedObjects,
                                                                                                                Limit, OrderBy, Skip, LastModified,
                                                                                                                ChangeID, Include, Exclude, Distinct){ }
        public PavementDataRequest(String ID = null, Boolean IncludeDeletedObjects = false,
                                   UInt32 Limit = 0, String OrderBy = null, UInt32 Skip = 0,
                                   Boolean LastModified = false, Int32 ChangeID = 0,
                                   String Include = null, String Exclude = null, String Distinct = null, Filter Filter = null) : base(ID, IncludeDeletedObjects,
                                                                                                                                      Limit, OrderBy, Skip, LastModified,
                                                                                                                                      ChangeID, Include, Exclude, Distinct, Filter) { }
        public PavementDataRequest(String ID = null, Boolean IncludeDeletedObjects = false,
                                   UInt32 Limit = 0, String OrderBy = null, UInt32 Skip = 0,
                                   Boolean LastModified = false, Int32 ChangeID = 0,
                                   String[] Include = null, String[] Exclude = null, String Distinct = null) : base(ID, IncludeDeletedObjects,
                                                                                                                            Limit, OrderBy, Skip, LastModified,
                                                                                                                            ChangeID, Include, Exclude, Distinct) { }
        public PavementDataRequest(String ID = null, Boolean IncludeDeletedObjects = false,
                                   UInt32 Limit = 0, String OrderBy = null, UInt32 Skip = 0,
                                   Boolean LastModified = false, Int32 ChangeID = 0,
                                   String[] Include = null, String[] Exclude = null, String Distinct = null, Filter Filter = null) : base(ID, IncludeDeletedObjects,
                                                                                                                                                  Limit, OrderBy, Skip, LastModified,
                                                                                                                                                  ChangeID, Include, Exclude, Distinct, Filter) { }
    }

    /// <summary>
    /// Beläggningsdata från PMS-systemen kombinerat med relevant vägdata från NVDB. 
    /// Vi kan ej garantera att det är helt aktuellt data från NVDB. Datum för när data hämtades framgår av posten TimeStamp. 
    /// För att se källa för respektive data, gå till fliken Om variabler i systemet PMSV3.
    /// </summary>
    /// <exception cref="Exception">Thrown when there's an error returned from Trafikverket.</exception>
    public class PavementData : BaseTrafikverket<PavementDataResponse[]>
    {
        /// <summary>
        /// Beläggningsdata från PMS-systemen kombinerat med relevant vägdata från NVDB. 
        /// Vi kan ej garantera att det är helt aktuellt data från NVDB. Datum för när data hämtades framgår av posten TimeStamp. 
        /// För att se källa för respektive data, gå till fliken Om variabler i systemet PMSV3.
        /// </summary>
        /// <param name="APIKey">Användarens unika nyckel.</param>
        /// <exception cref="Exception">Thrown when there's an error returned from Trafikverket.</exception>
        public PavementData(String APIKey) : base(APIKey) { }

        internal override ObjectType ObjectType => ObjectType.PavementData;
        /// <summary>
        /// SchemaVersion versionen som biblioteken använder.
        /// </summary>
        public override String CurrentSchemaVersion => Trafikverket.SchemaVersions[this.ObjectType];

        public override PavementDataResponse[] ExecuteRequest() => base.ExecuteRequest("PavementData", CurrentSchemaVersion);
        /// <param name="XMLRequest">Custom requests must be written in XML, check "https://api.trafikinfo.trafikverket.se/API/TheRequest" in order to create custom requests.</param>
        public override PavementDataResponse[] ExecuteRequest(String XMLRequest) => base.ExecuteRequest("PavementData", CurrentSchemaVersion, XMLRequest);
        public override PavementDataResponse[] ExecuteRequest(BaseTrafikverketRequest Request) => base.ExecuteCustomRequest(Request);
    }
}
