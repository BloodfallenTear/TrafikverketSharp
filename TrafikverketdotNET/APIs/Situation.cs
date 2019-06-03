using System;
using TrafikverketdotNET.Subs.SituationResponse;
using Newtonsoft.Json;

namespace TrafikverketdotNET
{
    public sealed class SituationResponse
    {
        [JsonProperty("CountryCode")] internal String _CountryCode { get; set; }
        [JsonProperty("Deleted")] internal Boolean _Deleted { get; set; }
        [JsonProperty("Deviation")] internal Deviation[] _Deviation { get; set; }
        [JsonProperty("Id")] internal String _Id { get; set; }
        [JsonProperty("ModifiedTime")] internal DateTime _ModifiedTime { get; set; }
        [JsonProperty("PublicationTime")] internal DateTime _PublicationTime { get; set; }
        [JsonProperty("VersionTime")] internal DateTime _VersionTime { get; set; }

        /// <summary>
        /// Landsbeteckning (https://github.com/BloodfallenTear/Trafikverket.NET/blob/master/docs/Trafikverket.CountryCode.txt).
        /// </summary>
        [JsonIgnore] public String CountryCode => _CountryCode;
        /// <summary>
        /// Anger att dataposten raderats.
        /// </summary>
        [JsonIgnore] public Boolean Deleted => _Deleted;
        [JsonIgnore] public Deviation[] Deviation => _Deviation;
        /// <summary>
        /// Datapostens id. Fältet är nyckel för objektet.
        /// </summary>
        [JsonIgnore] public String Id => _Id;
        /// <summary>
        /// Tidpunkt då dataposten ändrades.
        /// </summary>
        [JsonIgnore] public DateTime ModifiedTime => _ModifiedTime;
        /// <summary>
        /// Tidpunkt då dataposten publicerades.
        /// </summary>
        [JsonIgnore] public DateTime PublicationTime => _PublicationTime;
        /// <summary>
        /// Aktuell versionstid för situationen.
        /// </summary>
        [JsonIgnore] public DateTime VersionTime => _VersionTime;

        internal SituationResponse() { }
    }

    public class SituationRequest : BaseTrafikverketRequest { public SituationRequest(Query Query) : base(Query) { } }

    public sealed class Situation : BaseTrafikverket<SituationResponse[]>
    {
        /// <summary>
        /// Situationer innehållandes händelser och störningar som trafikmeddelanden, vägarbeten, olyckor, restiktioner m.m.
        /// </summary>
        /// <param name="APIKey">Användarens unika nyckel.</param>
        public Situation(String APIKey) : base(APIKey) { }

        /// <summary>
        /// SchemaVersion versionen som biblioteken använder.
        /// </summary>
        public override String CurrentSchemaVersion => "1.2";

        public override SituationResponse[] ExecuteRequest() => base.ExecuteRequest("Situation", CurrentSchemaVersion);
        /// <param name="XMLRequest">Custom requests must be written in XML, check "https://api.trafikinfo.trafikverket.se/API/TheRequest" in order to create custom requests.</param>
        public override SituationResponse[] ExecuteRequest(String XMLRequest) => base.ExecuteRequest("Situation", CurrentSchemaVersion, XMLRequest);
        public override SituationResponse[] ExecuteRequest(BaseTrafikverketRequest Request) => base.ExecuteCustomRequest(Request);
    }
}
