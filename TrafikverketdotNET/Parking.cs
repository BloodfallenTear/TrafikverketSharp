using System;
using Newtonsoft.Json;

namespace TrafikverketdotNET
{
    public sealed class ParkingResponse
    {
        [JsonProperty("CountyNo")] internal Int32[] _CountyNo { get; set; }
        [JsonProperty("Deleted")] internal Boolean _Deleted { get; set; }
        [JsonProperty("Description")] internal String _Description { get; set; }
        [JsonProperty("DistanceToNearestCity")] internal String _DistanceToNearestCity { get; set; }
        [JsonProperty("Equipment")] internal EquipmentResp[] _Equipment { get; set; }
        [JsonProperty("Facility")] internal FacilityResp[] _Facility { get; set; }
        [JsonProperty("Geometry")] internal Geometry _Geometry { get; set; }
        [JsonProperty("IconId")] internal String _IconId { get; set; }
        [JsonProperty("Id")] internal String _Id { get; set; }
        [JsonProperty("LocationDescription")] internal String _LocationDescription { get; set; }
        [JsonProperty("ModifiedTime")] internal DateTime _ModifiedTime { get; set; }
        [JsonProperty("Name")] internal String _Name { get; set; }
        [JsonProperty("OpenStatus")] internal String _OpenStatus { get; set; }
        [JsonProperty("OperationStatus")] internal String _OperationStatus { get; set; }
        [JsonProperty("Operator")] internal OperatorResp _Operator { get; set; }
        [JsonProperty("ParkingAccess")] internal ParkingAccessResp[] _ParkingAccess { get; set; }
        [JsonProperty("Photo")] internal PhotoResp[] _Photo { get; set; }
        [JsonProperty("TariffsAndPayment")] internal TariffsAndPaymentResp _TariffsAndPayment { get; set; }
        [JsonProperty("UsageSenario")] internal String[] _UsageSenario { get; set; }
        [JsonProperty("VehicleCharacteristics")] internal VehicleCharacteristicsResp[] _VehicleCharacteristics { get; set; }

        /// <summary>
        /// Länsnummer (https://github.com/BloodfallenTear/Trafikverket.NET/blob/master/docs/Lansnummer.txt). 
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
        [JsonIgnore] public EquipmentResp[] Equipment => _Equipment;
        /// <summary>
        /// Serviceanläggning.
        /// </summary>
        [JsonIgnore] public FacilityResp[] Facility => _Facility;
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
        [JsonIgnore] public OperatorResp Operator => _Operator;
        /// <summary>
        /// Parkeringens anslutning som en geometrisk punkt.
        /// </summary>
        [JsonIgnore] public ParkingAccessResp[] ParkingAccess => _ParkingAccess;
        /// <summary>
        /// Foto.
        /// </summary>
        [JsonIgnore] public PhotoResp[] Photo => _Photo;
        [JsonIgnore] public TariffsAndPaymentResp TariffsAndPayment => _TariffsAndPayment;
        /// <summary>
        /// Anger användningsområde.
        /// </summary>
        [JsonIgnore] public String[] UsageSenario => _UsageSenario;
        [JsonIgnore] public VehicleCharacteristicsResp[] VehicleCharacteristics => _VehicleCharacteristics;

        public sealed class EquipmentResp
        {
            [JsonProperty("Accessibility")] internal String _Accessibility { get; set; }
            [JsonProperty("Type")] internal String _Type { get; set; }

            /// <summary>
            /// Utrustningens tillgänglighet (https://github.com/BloodfallenTear/Trafikverket.NET/blob/master/docs/Equipment.Accessibility.txt).
            /// </summary>
            [JsonIgnore] public String Accessibility => _Accessibility;
            /// <summary>
            /// Typ av utrustning (https://github.com/BloodfallenTear/Trafikverket.NET/blob/master/docs/Equipment.Type.txt).
            /// </summary>
            [JsonIgnore] public String Type => _Type;

            internal EquipmentResp() { }
        }

        public sealed class FacilityResp
        {
            [JsonProperty("Accessibility")] internal String _Accessibility { get; set; }
            [JsonProperty("Type")] internal String _Type { get; set; }

            /// <summary>
            /// Serviceanläggningens tillgänglighet (https://github.com/BloodfallenTear/Trafikverket.NET/blob/master/docs/Facility.Accessibility.txt).
            /// </summary>
            [JsonIgnore] public String Accessibility => _Accessibility;
            /// <summary>
            /// Serviceanläggningar vid parkeringen (https://github.com/BloodfallenTear/Trafikverket.NET/blob/master/docs/Facility.Type.txt).
            /// </summary>
            [JsonIgnore] public String Type => _Type;

            internal FacilityResp() { }
        }

        public sealed class OperatorResp
        {
            [JsonProperty("Contact")] internal String _Contact { get; set; }
            [JsonProperty("ContactEmail")] internal String _ContactEmail { get; set; }
            [JsonProperty("ContactTelephoneNumber")] internal String _ContactTelephoneNumber { get; set; }
            [JsonProperty("Name")] internal String _Name { get; set; }

            /// <summary>
            /// Namn på operatörens kontakt.
            /// </summary>
            [JsonIgnore] public String Contact => _Contact;
            /// <summary>
            /// Operatörens kontaktmail.
            /// </summary>
            [JsonIgnore] public String ContactEmail => _ContactEmail;
            /// <summary>
            /// Operatörens kontakttelefon.
            /// </summary>
            [JsonIgnore] public String ContactTelephoneNumber => _ContactTelephoneNumber;
            /// <summary>
            /// Operatörens namn
            /// </summary>
            [JsonIgnore] public String Name => _Name;

            internal OperatorResp() { }
        }

        public sealed class ParkingAccessResp
        {
            [JsonProperty("SWEREF99TM")] internal String _SWEREF99TM { get; set; }
            [JsonProperty("WGS84")] internal String _WGS84 { get; set; }

            /// <summary>
            /// Parkeringens anslutning som en geometrisk punkt i koordinatsystemet SWEREF99TM.
            /// </summary>
            [JsonIgnore] public String SWEREF99TM => _SWEREF99TM;
            /// <summary>
            /// Parkeringens anslutning som en geometrisk punkt i koordinatsystemet WGS84.
            /// </summary>
            [JsonIgnore] public String WGS84 => _WGS84;

            internal ParkingAccessResp() { }
        }

        public sealed class PhotoResp
        {
            [JsonProperty("Title")] internal String _Title { get; set; }
            [JsonProperty("Url")] internal String _Url { get; set; }

            /// <summary>
            /// Namn på foto.
            /// </summary>
            [JsonIgnore] public String Title => _Title;
            /// <summary>
            /// Url till foto.
            /// </summary>
            [JsonIgnore] public String Url => _Url;

            internal PhotoResp() { }
        }

        public sealed class TariffsAndPaymentResp
        {
            [JsonProperty("FreeOfCharge")] internal Boolean _FreeOfCharge { get; set; }
            [JsonProperty("Tariff")] internal String _Tariff { get; set; }

            /// <summary>
            /// Anger om parkeringen är gratis att använda.
            /// </summary>
            [JsonIgnore] public Boolean FreeOfCharge => _FreeOfCharge;
            /// <summary>
            /// Anger parkeringens avgift.
            /// </summary>
            [JsonIgnore] public String Tariff => _Tariff;

            internal TariffsAndPaymentResp() { }
        }

        public sealed class VehicleCharacteristicsResp
        {
            [JsonProperty("LoadType")] internal String _LoadType { get; set; }
            [JsonProperty("NumberOfSpaces")] internal Byte _NumberOfSpaces { get; set; }
            [JsonProperty("VeichleType")] internal String _VeichleType { get; set; }

            /// <summary>
            /// Typ av last parkeringen är avsedd för, exempelvis fryst gods (refrigeratedGoods).
            /// </summary>
            [JsonIgnore] public String LoadType => _LoadType;
            /// <summary>
            /// Antal platser för fordonstypen inkl släp.
            /// </summary>
            [JsonIgnore] public Byte NumberOfSpaces => _NumberOfSpaces;
            /// <summary>
            /// Fordonstyp parkeringen är avsedd för.
            /// </summary>
            [JsonIgnore] public String VeichleType => _VeichleType;

            internal VehicleCharacteristicsResp() { }
        }
        
        internal ParkingResponse() { }
    }

    public sealed class Parking : BaseTrafikverket<ParkingResponse[]>
    {
        /// <summary>
        /// Information om rastplatser och parkeringar.
        /// </summary>
        /// <param name="APIKey">Användarens unika nyckel.</param>
        public Parking(String APIKey) : base(APIKey) { }

        /// <summary>
        /// SchemaVersion versionen som biblioteken använder.
        /// </summary>
        public override String CurrentSchemaVersion => "1";

        public override ParkingResponse[] ExecuteRequest() => ExecuteRequest("Parking", CurrentSchemaVersion);

        /// <param name="XMLRequest">Custom requests must be written in XML, check "https://api.trafikinfo.trafikverket.se/API/TheRequest" in order to create custom requests.</param>
        public override ParkingResponse[] ExecuteRequest(String XMLRequest) => ExecuteRequest("Parking", CurrentSchemaVersion, XMLRequest);
    }
}
