using System;
using System.Collections.Generic;
using TrafikverketdotNET.Subs.TravelTimeRouteResponse;
using Newtonsoft.Json;

namespace TrafikverketdotNET
{
    public sealed class TravelTimeRouteResponse : BaseTrafikverketResponse
    {
        [JsonProperty("AverageFunctionalRoadClass")] internal Int32 _AverageFunctionalRoadClass { get; set; }
        [JsonProperty("CountryCode")] internal String _CountryCode { get; set; }
        [JsonProperty("CountyNo")] internal Int32[] _CountyNo { get; set; }
        [JsonProperty("Deleted")] internal Boolean _Deleted { get; set; }
        [JsonProperty("ExpectedFreeFlowTravelTime")] internal Int32 _ExpectedFreeFlowTravelTime { get; set; }
        [JsonProperty("FreeFlowTravelTime")] internal Int32 _FreeFlowTravelTime { get; set; }
        [JsonProperty("Geometry")] internal Geometry _Geometry { get; set; }
        [JsonProperty("Id")] internal String _Id { get; set; }
        [JsonProperty("Length")] internal Int32 _Length { get; set; }
        [JsonProperty("MeasureTime")] internal DateTime _MeasureTime { get; set; }
        [JsonProperty("ModifiedTime")] internal DateTime _ModifiedTime { get; set; }
        [JsonProperty("Name")] internal String _Name { get; set; }
        [JsonProperty("RouteOwner")] internal Int32 _RouteOwner { get; set; }
        [JsonProperty("Speed")] internal Double _Speed { get; set; }
        [JsonProperty("TrafficStatus")] internal String _TrafficStatus { get; set; }
        [JsonProperty("TravelTime")] internal Int32 _TravelTime { get; set; }

        /// <summary>
        /// Genomsnittlig funktionell vägklass för sträckan. 
        /// En klassificering 0-9 baserad på hur viktig en väg är för det totala vägnätets förbindelsemöjligheter. 
        /// 0 - De viktigaste vägarna
        /// 9 - De minst viktiga vägarna
        /// </summary>
        [JsonIgnore] public Int32 AverageFunctionalRoadClass => _AverageFunctionalRoadClass;
        /// <summary>
        /// Landskod
        /// </summary>
        [JsonIgnore] public String CountryCode => _CountryCode;
        /// <summary>
        /// Länsnummer (https://github.com/BloodfallenTear/Trafikverket.NET/blob/master/docs/Lansnummer.txt).
        /// </summary>
        [JsonIgnore] public Int32[] CountyNo => _CountyNo;
        /// <summary>
        /// Anger att dataposten raderats.
        /// </summary>
        [JsonIgnore] public Boolean Deleted => _Deleted;
        /// <summary>
        /// Anger normal restid i sekunder för sträckan vid skyltad hastighet baserat på historiskt data.
        /// </summary>
        [JsonIgnore] public Int32 ExpectedFreeFlowTravelTime => _ExpectedFreeFlowTravelTime;
        /// <summary>
        /// Anger normal restid i sekunder för sträckan vid skyltad hastighet.
        /// </summary>
        [JsonIgnore] public Int32 FreeFlowTravelTime => _FreeFlowTravelTime;
        /// <summary>
        /// Geometrisk punkt i koordinatsystem. Fältet kan användas för geo-frågor.
        /// </summary>
        [JsonIgnore] public Geometry Geometry => _Geometry;
        /// <summary>
        /// Anger id för sträckan. Fältet är nyckel för objektet.
        /// </summary>
        [JsonIgnore] public String Id => _Id;
        /// <summary>
        /// Anger längden i meter för sträckan.
        /// </summary>
        [JsonIgnore] public Int32 Length => _Length;
        /// <summary>
        /// Tidpunkt då mätningen av restiden gjordes. Det är slutet på tidsperioden som skickas från källsystemet.
        /// </summary>
        [JsonIgnore] public DateTime MeasureTime => _MeasureTime;
        /// <summary>
        /// Tidpunkt då dataposten ändrades
        /// </summary>
        [JsonIgnore] public DateTime ModifiedTime => _ModifiedTime;
        /// <summary>
        /// Anger namnet på sträckan.
        /// </summary>
        [JsonIgnore] public String Name => _Name;
        /// <summary>
        /// Ruttägare (https://github.com/BloodfallenTear/Trafikverket.NET/blob/master/docs/TravelTimeRoute.RouteOwner.txt).
        /// </summary>
        [JsonIgnore] public Int32 RouteOwner => _RouteOwner;
        /// <summary>
        /// Anger hastighet i km/h.
        /// </summary>
        [JsonIgnore] public Double Speed => _Speed;
        /// <summary>
        /// Anger restidsstatus för sträckan (https://github.com/BloodfallenTear/Trafikverket.NET/blob/master/docs/TravelTimeRoute.TrafficStatus.txt).
        /// </summary>
        [JsonIgnore] public String TrafficStatus => _TrafficStatus;
        /// <summary>
        /// Anger aktuell restid i sekunder för sträckan.
        /// </summary>
        [JsonIgnore] public Int32 TravelTime => _TravelTime;

        internal TravelTimeRouteResponse() { }
    }

    public class TravelTimeRouteRequest : BaseTrafikverketRequest
    {
        public override ObjectType ObjectType => ObjectType.TravelTimeRoute;
        public override string SchemaVersion => Trafikverket.SchemaVersions[this.ObjectType];

        public TravelTimeRouteRequest(Filter Filter) : base(Filter) { }
        public TravelTimeRouteRequest(String ID = null, Boolean IncludeDeletedObjects = false,
                                      UInt32 Limit = 0, String OrderBy = null, UInt32 Skip = 0,
                                      Boolean LastModified = false, Int32 ChangeID = 0,
                                      String Include = null, String Exclude = null, String Distinct = null) : base(ID, IncludeDeletedObjects,
                                                                                                                   Limit, OrderBy, Skip, LastModified,
                                                                                                                   ChangeID, Include, Exclude, Distinct) { }
        public TravelTimeRouteRequest(String ID = null, Boolean IncludeDeletedObjects = false,
                                      UInt32 Limit = 0, String OrderBy = null, UInt32 Skip = 0,
                                      Boolean LastModified = false, Int32 ChangeID = 0,
                                      List<String> Include = null, List<String> Exclude = null, String Distinct = null) : base(ID, IncludeDeletedObjects,
                                                                                                                               Limit, OrderBy, Skip, LastModified,
                                                                                                                               ChangeID, Include, Exclude, Distinct) { }
        public TravelTimeRouteRequest(String ID = null, Boolean IncludeDeletedObjects = false,
                                      UInt32 Limit = 0, String OrderBy = null, UInt32 Skip = 0,
                                      Boolean LastModified = false, Int32 ChangeID = 0,
                                      String Include = null, String Exclude = null, String Distinct = null, Filter Filter = null) : base(ID, IncludeDeletedObjects,
                                                                                                                                         Limit, OrderBy, Skip, LastModified,
                                                                                                                                         ChangeID, Include, Exclude, Distinct, Filter) { }
        public TravelTimeRouteRequest(String ID = null, Boolean IncludeDeletedObjects = false,
                                      UInt32 Limit = 0, String OrderBy = null, UInt32 Skip = 0,
                                      Boolean LastModified = false, Int32 ChangeID = 0,
                                      List<String> Include = null, List<String> Exclude = null, String Distinct = null, Filter Filter = null) : base(ID, IncludeDeletedObjects,
                                                                                                                                                     Limit, OrderBy, Skip, LastModified,
                                                                                                                                                     ChangeID, Include, Exclude, Distinct, Filter) { }
    }

    /// <summary>
    /// Restider i större städer eller i högbelastade trafiksystem. Beräkning av restid baseras på data från detektorer som är utplacerade längs bestämda rutter.
    /// </summary>
    /// <exception cref="Exception">Thrown when there's an error returned from Trafikverket.</exception>
    public sealed class TravelTimeRoute : BaseTrafikverket<TravelTimeRouteResponse[]>
    {
        /// <summary>
        /// Restider i större städer eller i högbelastade trafiksystem. Beräkning av restid baseras på data från detektorer som är utplacerade längs bestämda rutter.
        /// </summary>
        /// <param name="APIKey">Användarens unika nyckel.</param>
        /// <exception cref="Exception">Thrown when there's an error returned from Trafikverket.</exception>
        public TravelTimeRoute(String APIKey) : base(APIKey) { }

        internal override ObjectType ObjectType => ObjectType.TravelTimeRoute;
        /// <summary>
        /// SchemaVersion versionen som biblioteken använder.
        /// </summary>
        public override String CurrentSchemaVersion => Trafikverket.SchemaVersions[this.ObjectType];

        public override TravelTimeRouteResponse[] ExecuteRequest() => base.ExecuteRequest("TravelTimeRoute", CurrentSchemaVersion);
        /// <param name="XMLRequest">Custom requests must be written in XML, check "https://api.trafikinfo.trafikverket.se/API/TheRequest" in order to create custom requests.</param>
        public override TravelTimeRouteResponse[] ExecuteRequest(String XMLRequest) => base.ExecuteRequest("TravelTimeRoute", CurrentSchemaVersion, XMLRequest);
        public override TravelTimeRouteResponse[] ExecuteRequest(BaseTrafikverketRequest Request) => base.ExecuteCustomRequest(Request);
    }
}
