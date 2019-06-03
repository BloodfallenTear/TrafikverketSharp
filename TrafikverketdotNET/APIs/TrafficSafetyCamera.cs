using System;
using TrafikverketdotNET.Subs;
using Newtonsoft.Json;

namespace TrafikverketdotNET
{
    public sealed class TrafficSafetyCameraResponse
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

    public class TrafficSafetyCameraRequest : BaseTrafikverketRequest { public TrafficSafetyCameraRequest(Query Query) : base(Query) { } }

    public sealed class TrafficSafetyCamera : BaseTrafikverket<TrafficSafetyCameraResponse[]>
    {
        /// <summary>
        /// Trafiksäkerhetskameror.
        /// </summary>
        /// <param name="APIKey">Användarens unika nyckel.</param>
        public TrafficSafetyCamera(String APIKey) : base(APIKey) { }

        /// <summary>
        /// SchemaVersion versionen som biblioteken använder.
        /// </summary>
        public override String CurrentSchemaVersion => "1";

        public override TrafficSafetyCameraResponse[] ExecuteRequest() => base.ExecuteRequest("TrafficSafetyCamera", CurrentSchemaVersion);
        /// <param name="XMLRequest">Custom requests must be written in XML, check "https://api.trafikinfo.trafikverket.se/API/TheRequest" in order to create custom requests.</param>
        public override TrafficSafetyCameraResponse[] ExecuteRequest(String XMLRequest) => base.ExecuteRequest("TrafficSafetyCamera", CurrentSchemaVersion, XMLRequest);
        public override TrafficSafetyCameraResponse[] ExecuteRequest(BaseTrafikverketRequest Request) => base.ExecuteCustomRequest(Request);
    }
}
