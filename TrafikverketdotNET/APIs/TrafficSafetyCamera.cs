using System;
using System.Collections.Generic;
using TrafikverketdotNET.Subs;
using Newtonsoft.Json;

namespace TrafikverketdotNET
{
    public sealed class TrafficSafetyCameraResponse : BaseTrafikverketResponse
    {
        [JsonProperty("Bearing")] internal Int32 _Bearing { get; set; }
        [JsonProperty("CountyNo")] internal Int32[] _CountyNo { get; set; }
        [JsonProperty("Deleted")] internal Boolean _Deleted { get; set; }
        [JsonProperty("Geometry")] internal Geometry _Geometry { get; set; }
        [JsonProperty("IconId")] internal String _IconId { get; set; }
        [JsonProperty("Id")] internal String _Id { get; set; }
        [JsonProperty("ModifiedTime")] internal DateTime _ModifiedTime { get; set; }
        [JsonProperty("Name")] internal String _Name { get; set; }
        [JsonProperty("RoadNumber")] internal String _RoadNumber { get; set; }

        /// <summary>
        /// Vilket håll kameran är riktad mot. Medsols grader från norr.
        /// </summary>
        [JsonIgnore] public Int32 Bearing => _Bearing;
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
        /// Anger ikonid för kameratypen.
        /// </summary>
        [JsonIgnore] public String IconId => _IconId;
        /// <summary>
        /// Unikt id för kameran. Fältet är nyckel för objektet.
        /// </summary>
        [JsonIgnore] public String Id => _Id;
        /// <summary>
        /// Tidpunkt då dataposten ändrades.
        /// </summary>
        [JsonIgnore] public DateTime ModifiedTime => _ModifiedTime;
        /// <summary>
        /// Namn på kameran.
        /// </summary>
        [JsonIgnore] public String Name => _Name;
        /// <summary>
        /// Vägnummer som mätplatsen står vid
        /// </summary>
        [JsonIgnore] public String RoadNumber => _RoadNumber;

        internal TrafficSafetyCameraResponse() { }
    }

    public class TrafficSafetyCameraRequest : BaseTrafikverketRequest
    {
        public override ObjectType ObjectType => ObjectType.TrafficSafetyCamera;
        public override string SchemaVersion => Trafikverket.SchemaVersions[this.ObjectType];

        public TrafficSafetyCameraRequest(Filter Filter) : base(Filter) { }
        public TrafficSafetyCameraRequest(String ID = null, Boolean IncludeDeletedObjects = false,
                                          UInt32 Limit = 0, String OrderBy = null, UInt32 Skip = 0,
                                          Boolean LastModified = false, Int32 ChangeID = 0,
                                          String Include = null, String Exclude = null, String Distinct = null) : base(ID, IncludeDeletedObjects,
                                                                                                                       Limit, OrderBy, Skip, LastModified,
                                                                                                                       ChangeID, Include, Exclude, Distinct) { }
        public TrafficSafetyCameraRequest(String ID = null, Boolean IncludeDeletedObjects = false,
                                          UInt32 Limit = 0, String OrderBy = null, UInt32 Skip = 0,
                                          Boolean LastModified = false, Int32 ChangeID = 0,
                                          List<String> Include = null, List<String> Exclude = null, String Distinct = null) : base(ID, IncludeDeletedObjects,
                                                                                                                                   Limit, OrderBy, Skip, LastModified,
                                                                                                                                   ChangeID, Include, Exclude, Distinct) { }
        public TrafficSafetyCameraRequest(String ID = null, Boolean IncludeDeletedObjects = false,
                                          UInt32 Limit = 0, String OrderBy = null, UInt32 Skip = 0,
                                          Boolean LastModified = false, Int32 ChangeID = 0,
                                          String Include = null, String Exclude = null, String Distinct = null, Filter Filter = null) : base(ID, IncludeDeletedObjects,
                                                                                                                                             Limit, OrderBy, Skip, LastModified,
                                                                                                                                             ChangeID, Include, Exclude, Distinct, Filter) { }
        public TrafficSafetyCameraRequest(String ID = null, Boolean IncludeDeletedObjects = false,
                                          UInt32 Limit = 0, String OrderBy = null, UInt32 Skip = 0,
                                          Boolean LastModified = false, Int32 ChangeID = 0,
                                          List<String> Include = null, List<String> Exclude = null, String Distinct = null, Filter Filter = null) : base(ID, IncludeDeletedObjects,
                                                                                                                                                         Limit, OrderBy, Skip, LastModified,
                                                                                                                                                         ChangeID, Include, Exclude, Distinct, Filter) { }

    }

    /// <summary>
    /// Trafiksäkerhetskameror.
    /// </summary>
    /// <exception cref="Exception">Thrown when there's an error returned from Trafikverket.</exception>
    public sealed class TrafficSafetyCamera : BaseTrafikverket<TrafficSafetyCameraResponse[]>
    {
        /// <summary>
        /// Trafiksäkerhetskameror.
        /// </summary>
        /// <param name="APIKey">Användarens unika nyckel.</param>
        /// <exception cref="Exception">Thrown when there's an error returned from Trafikverket.</exception>
        public TrafficSafetyCamera(String APIKey) : base(APIKey) { }

        internal override ObjectType ObjectType => ObjectType.TrafficSafetyCamera;
        /// <summary>
        /// SchemaVersion versionen som biblioteken använder.
        /// </summary>
        public override String CurrentSchemaVersion => Trafikverket.SchemaVersions[this.ObjectType];

        public override TrafficSafetyCameraResponse[] ExecuteRequest() => base.ExecuteRequest("TrafficSafetyCamera", CurrentSchemaVersion);
        /// <param name="XMLRequest">Custom requests must be written in XML, check "https://api.trafikinfo.trafikverket.se/API/TheRequest" in order to create custom requests.</param>
        public override TrafficSafetyCameraResponse[] ExecuteRequest(String XMLRequest) => base.ExecuteRequest("TrafficSafetyCamera", CurrentSchemaVersion, XMLRequest);
        public override TrafficSafetyCameraResponse[] ExecuteRequest(BaseTrafikverketRequest Request) => base.ExecuteCustomRequest(Request);
    }
}
