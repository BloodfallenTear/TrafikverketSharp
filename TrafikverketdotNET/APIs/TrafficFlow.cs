using System;
using TrafikverketdotNET.Subs;
using Newtonsoft.Json;

namespace TrafikverketdotNET
{
    public sealed class TrafficFlowResponse : BaseTrafikverketResponse
    {
        [JsonProperty("AverageVehicleSpeed")] internal Int32 _AverageVehicleSpeed { get; set; }
        [JsonProperty("CountyNo")] internal Int32[] _CountyNo { get; set; }
        [JsonProperty("Deleted")] internal Boolean _Deleted { get; set; }
        [JsonProperty("Geometry")] internal Geometry _Geometry { get; set; }
        [JsonProperty("MeasurementOrCalculationPeriod")] internal Int32 _MeasurementOrCalculationPeriod { get; set; }
        [JsonProperty("MeasurementSide")] internal String _MeasurementSide { get; set; }
        [JsonProperty("MeasurementTime")] internal DateTime _MeasurementTime { get; set; }
        [JsonProperty("ModifiedTime")] internal DateTime _ModifiedTime { get; set; }
        [JsonProperty("RegionId")] internal Int32 _RegionId { get; set; }
        [JsonProperty("SiteId")] internal Int32 _SiteId { get; set; }
        [JsonProperty("SpecificLane")] internal String _SpecificLane { get; set; }
        [JsonProperty("VehicleFlowRate")] internal Int32 _VehicleFlowRate { get; set; }
        [JsonProperty("VehicleType")] internal String _VehicleType { get; set; }

        /// <summary>
        /// En genomsnittlig mätning eller beräkning av hastigheten på fordon på den angivna platsen.
        /// </summary>
        [JsonIgnore] public Int32 AverageVehicleSpeed => _AverageVehicleSpeed;
        /// <summary>
        /// Länsnummer (https://github.com/BloodfallenTear/Trafikverket.NET/blob/master/docs/Lansnummer.txt).
        /// </summary>
        [JsonIgnore] public Int32[] CountyNo => _CountyNo;
        /// <summary>
        /// Anger att dataposten raderats.
        /// </summary>
        [JsonIgnore] public Boolean Deleted => _Deleted;
        /// <summary>
        /// Geometrisk punkt i koordinatsystem. Fältet kan användas för geo-frågor.
        /// </summary>
        [JsonIgnore] public Geometry Geometry => _Geometry;
        /// <summary>
        /// Den tid som förflutit mellan början och slutet av provtagnings- eller mätperioden. 
        /// Det här objektet kan skilja sig från enhetens attribut t.ex. ett timmeflöde kan uppskattas från en 5-minuters mätperiod.
        /// </summary>
        [JsonIgnore] public Int32 MeasurementOrCalculationPeriod => _MeasurementOrCalculationPeriod;
        /// <summary>
        /// Riktning som detektorn mäter i.
        /// </summary>
        [JsonIgnore] public String MeasurementSide => _MeasurementSide;
        /// <summary>
        /// Tidpunkt då detta specifika värde eller uppsättning värden har uppmätts. Det är slutet på perioden som skickas från källsystemet.
        /// </summary>
        [JsonIgnore] public DateTime MeasurementTime => _MeasurementTime;
        /// <summary>
        /// Tidpunkt då dataposten ändrades.
        /// </summary>
        [JsonIgnore] public DateTime ModifiedTime => _ModifiedTime;
        /// <summary>
        /// Regionsnummer (https://github.com/BloodfallenTear/Trafikverket.NET/blob/master/docs/TrafficFlow.RegionId.txt).
        /// </summary>
        [JsonIgnore] public Int32 RegionId => _RegionId;
        /// <summary>
        /// Detektorns id. Fältet är nyckel för objektet.
        /// </summary>
        [JsonIgnore] public Int32 SiteId => _SiteId;
        /// <summary>
        /// Det körfält som detektorn mäter vid.
        /// </summary>
        [JsonIgnore] public String SpecificLane => _SpecificLane;
        /// <summary>
        /// Flöde uttryckt i fordon per timme.
        /// </summary>
        [JsonIgnore] public Int32 VehicleFlowRate => _VehicleFlowRate;
        /// <summary>
        /// Fordonets typ (https://github.com/BloodfallenTear/Trafikverket.NET/blob/master/docs/TrafficFlow.VehicleType.md). Fältet är nyckel för objektet.
        /// </summary>
        [JsonIgnore] public String VehicleType => _VehicleType;

        internal TrafficFlowResponse() { }
    }

    public class TrafficFlowRequest : BaseTrafikverketRequest
    {
        public override ObjectType ObjectType => ObjectType.TrafficFlow;
        public override string SchemaVersion => Trafikverket.SchemaVersions[this.ObjectType];

        public TrafficFlowRequest(Filter Filter) : base(Filter) { }
        public TrafficFlowRequest(String ID = null, Boolean IncludeDeletedObjects = false,
                                  UInt32 Limit = 0, String OrderBy = null, UInt32 Skip = 0,
                                  Boolean LastModified = false, Int32 ChangeID = 0,
                                  String[] Include = null, String[] Exclude = null, String Distinct = null, Filter Filter = null) : base(ID, IncludeDeletedObjects,
                                                                                                                                                 Limit, OrderBy, Skip, LastModified,
                                                                                                                                                 ChangeID, Include, Exclude, Distinct, Filter) { }
    }

    /// <summary>
    /// Uppmätta eller härledda värden relaterat till trafik eller enskilda fordonets rörelser på en viss sektion eller vid en specifik punkt på vägnätet.
    /// </summary>
    public sealed class TrafficFlow : BaseTrafikverket<TrafficFlowResponse, TrafficFlowRequest>
    {
        /// <summary>
        /// Uppmätta eller härledda värden relaterat till trafik eller enskilda fordonets rörelser på en viss sektion eller vid en specifik punkt på vägnätet.
        /// </summary>
        /// <param name="APIKey">Användarens unika nyckel.</param>
        /// <exception cref="TrafikverketException">Thrown when there's an error returned from Trafikverket.</exception>
        public TrafficFlow(String APIKey) : base(APIKey) { }

        internal override ObjectType ObjectType => ObjectType.TrafficFlow;
        /// <summary>
        /// SchemaVersion versionen som biblioteken använder.
        /// </summary>
        public override String CurrentSchemaVersion => Trafikverket.SchemaVersions[this.ObjectType];

        /// <exception cref="TrafikverketException">Thrown when there's an error returned from Trafikverket.</exception>
        public override TrafficFlowResponse[] ExecuteRequest() => base.ExecuteRequest("TrafficFlow", CurrentSchemaVersion);
        /// <param name="XMLRequest">Custom requests must be written in XML, check "https://api.trafikinfo.trafikverket.se/API/TheRequest" in order to create custom requests.</param>
        /// <exception cref="TrafikverketException">Thrown when there's an error returned from Trafikverket.</exception>
        public override TrafficFlowResponse[] ExecuteRequest(String XMLRequest) => base.ExecuteRequest("TrafficFlow", CurrentSchemaVersion, XMLRequest);
        /// <exception cref="TrafikverketException">Thrown when there's an error returned from Trafikverket.</exception>
        public override TrafficFlowResponse[] ExecuteRequest(TrafficFlowRequest Request) => base.ExecuteCustomRequest(Request);
    }
}
