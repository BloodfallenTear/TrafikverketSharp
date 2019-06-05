using System;
using System.Collections.Generic;
using TrafikverketdotNET.Subs;
using TrafikverketdotNET.Subs.ParkingResponse;
using Newtonsoft.Json;

namespace TrafikverketdotNET
{
    public sealed class ParkingResponse : BaseTrafikverketResponse
    {
        [JsonProperty("CountyNo")] internal Int32[] _CountyNo { get; set; }
        [JsonProperty("Deleted")] internal Boolean _Deleted { get; set; }
        [JsonProperty("Description")] internal String _Description { get; set; }
        [JsonProperty("DistanceToNearestCity")] internal String _DistanceToNearestCity { get; set; }
        [JsonProperty("Equipment")] internal Equipment[] _Equipment { get; set; }
        [JsonProperty("Facility")] internal Facility[] _Facility { get; set; }
        [JsonProperty("Geometry")] internal Geometry _Geometry { get; set; }
        [JsonProperty("IconId")] internal String _IconId { get; set; }
        [JsonProperty("Id")] internal String _Id { get; set; }
        [JsonProperty("LocationDescription")] internal String _LocationDescription { get; set; }
        [JsonProperty("ModifiedTime")] internal DateTime _ModifiedTime { get; set; }
        [JsonProperty("Name")] internal String _Name { get; set; }
        [JsonProperty("OpenStatus")] internal String _OpenStatus { get; set; }
        [JsonProperty("OperationStatus")] internal String _OperationStatus { get; set; }
        [JsonProperty("Operator")] internal Operator _Operator { get; set; }
        [JsonProperty("ParkingAccess")] internal ParkingAccess[] _ParkingAccess { get; set; }
        [JsonProperty("Photo")] internal Photo[] _Photo { get; set; }
        [JsonProperty("TariffsAndPayment")] internal TariffsAndPayment _TariffsAndPayment { get; set; }
        [JsonProperty("UsageSenario")] internal String[] _UsageSenario { get; set; }
        [JsonProperty("VehicleCharacteristics")] internal VehicleCharacteristics[] _VehicleCharacteristics { get; set; }

        /// <summary>
        /// Länsnummer (https://github.com/BloodfallenTear/Trafikverket.NET/blob/master/docs/Trafikverket.Lansnummer.txt). 
        /// </summary>
        [JsonIgnore] public Int32[] CountyNo => _CountyNo;
        /// <summary>
        /// Anger att dataposten raderats.
        /// </summary>
        [JsonIgnore] public Boolean Deleted => _Deleted;
        /// <summary>
        /// Beskrivning av parkeringen
        /// </summary>
        [JsonIgnore] public String Description => _Description;
        /// <summary>
        /// Avstånd till närmaste stad.
        /// </summary>
        [JsonIgnore] public String DistanceToNearestCity => _DistanceToNearestCity;
        /// <summary>
        /// Utrustning.
        /// </summary>
        [JsonIgnore] public Equipment[] Equipment => _Equipment;
        /// <summary>
        /// Serviceanläggning.
        /// </summary>
        [JsonIgnore] public Facility[] Facility => _Facility;
        /// <summary>
        /// Geometrisk punkt i koordinatsystem. Fältet kan användas för geo-frågor.
        /// </summary>
        [JsonIgnore] public Geometry Geometry => _Geometry;
        /// <summary>
        /// Ikonid.
        /// </summary>
        [JsonIgnore] public String IconId => _IconId;
        /// <summary>
        /// Parkeringens id. Fältet är nyckel för objektet.
        /// </summary>
        [JsonIgnore] public String Id => _Id;
        /// <summary>
        /// Lägesbeskrivning.
        /// </summary>
        [JsonIgnore] public String LocationDescription => _LocationDescription;
        /// <summary>
        /// Tidpunkt då dataposten ändrades.
        /// </summary>
        [JsonIgnore] public DateTime ModifiedTime => _ModifiedTime;
        /// <summary>
        /// Parkeringens namn
        /// </summary>
        [JsonIgnore] public String Name => _Name;
        /// <summary>
        /// Anger om rastplatsen är öppen eller stängd (open, closed).
        /// </summary>
        [JsonIgnore] public String OpenStatus => _OpenStatus;
        /// <summary>
        /// Anger om det finns några driftstörningar på rastplatsen (limitedOperation) eller om allt fungerar (inOperation)
        /// </summary>
        [JsonIgnore] public String OperationStatus => _OperationStatus;
        /// <summary>
        /// Operatören.
        /// </summary>
        [JsonIgnore] public Operator Operator => _Operator;
        /// <summary>
        /// Parkeringens anslutning som en geometrisk punkt.
        /// </summary>
        [JsonIgnore] public ParkingAccess[] ParkingAccess => _ParkingAccess;
        /// <summary>
        /// Foto.
        /// </summary>
        [JsonIgnore] public Photo[] Photo => _Photo;
        [JsonIgnore] public TariffsAndPayment TariffsAndPayment => _TariffsAndPayment;
        /// <summary>
        /// Anger användningsområde.
        /// </summary>
        [JsonIgnore] public String[] UsageSenario => _UsageSenario;
        [JsonIgnore] public VehicleCharacteristics[] VehicleCharacteristics => _VehicleCharacteristics;
        
        internal ParkingResponse() { }
    }

    public class ParkingRequest : BaseTrafikverketRequest
    {
        public override ObjectType ObjectType => ObjectType.Parking;
        public override string SchemaVersion => Trafikverket.GetSchemaVersion[this.ObjectType];

        public ParkingRequest(Filter Filter) : base(Filter) { }
        public ParkingRequest(String ID = null, Boolean IncludeDeletedObjects = false,
                              UInt32 Limit = 0, String OrderBy = null, UInt32 Skip = 0,
                              Boolean LastModified = false, Int32 ChangeID = 0,
                              String Include = null, String Exclude = null, String Distinct = null) : base(ID, IncludeDeletedObjects,
                                                                                                           Limit, OrderBy, Skip, LastModified,
                                                                                                           ChangeID, Include, Exclude, Distinct) { }
        public ParkingRequest(String ID = null, Boolean IncludeDeletedObjects = false,
                              UInt32 Limit = 0, String OrderBy = null, UInt32 Skip = 0,
                              Boolean LastModified = false, Int32 ChangeID = 0,
                              List<String> Include = null, List<String> Exclude = null, String Distinct = null) : base(ID, IncludeDeletedObjects,
                                                                                                                       Limit, OrderBy, Skip, LastModified,
                                                                                                                       ChangeID, Include, Exclude, Distinct) { }
        public ParkingRequest(String ID = null, Boolean IncludeDeletedObjects = false,
                              UInt32 Limit = 0, String OrderBy = null, UInt32 Skip = 0,
                              Boolean LastModified = false, Int32 ChangeID = 0,
                              String Include = null, String Exclude = null, String Distinct = null, Filter Filter = null) : base(ID, IncludeDeletedObjects,
                                                                                                                                 Limit, OrderBy, Skip, LastModified,
                                                                                                                                 ChangeID, Include, Exclude, Distinct, Filter) { }
        public ParkingRequest(String ID = null, Boolean IncludeDeletedObjects = false,
                              UInt32 Limit = 0, String OrderBy = null, UInt32 Skip = 0,
                              Boolean LastModified = false, Int32 ChangeID = 0,
                              List<String> Include = null, List<String> Exclude = null, String Distinct = null, Filter Filter = null) : base(ID, IncludeDeletedObjects,
                                                                                                                                             Limit, OrderBy, Skip, LastModified,
                                                                                                                                             ChangeID, Include, Exclude, Distinct, Filter) { }
    }

    public sealed class Parking : BaseTrafikverket<ParkingResponse[]>
    {
        /// <summary>
        /// Information om rastplatser och parkeringar.
        /// </summary>
        /// <param name="APIKey">Användarens unika nyckel.</param>
        public Parking(String APIKey) : base(APIKey) { }

        internal override ObjectType ObjectType => ObjectType.Parking;
        /// <summary>
        /// SchemaVersion versionen som biblioteken använder.
        /// </summary>
        public override String CurrentSchemaVersion => Trafikverket.GetSchemaVersion[this.ObjectType];

        public override ParkingResponse[] ExecuteRequest() => base.ExecuteRequest("Parking", CurrentSchemaVersion);
        /// <param name="XMLRequest">Custom requests must be written in XML, check "https://api.trafikinfo.trafikverket.se/API/TheRequest" in order to create custom requests.</param>
        public override ParkingResponse[] ExecuteRequest(String XMLRequest) => base.ExecuteRequest("Parking", CurrentSchemaVersion, XMLRequest);
        public override ParkingResponse[] ExecuteRequest(BaseTrafikverketRequest Request) => base.ExecuteCustomRequest(Request);
    }
}
