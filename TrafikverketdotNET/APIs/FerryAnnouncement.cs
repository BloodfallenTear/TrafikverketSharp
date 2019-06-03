using System;
using TrafikverketdotNET.Subs.FerryAnnouncementResponse;
using Newtonsoft.Json;

namespace TrafikverketdotNET
{ 
    public sealed class FerryAnnouncementResponse
    {
        [JsonProperty("Deleted")] internal Boolean _Deleted { get; set; }
        [JsonProperty("DepartureTime")] internal DateTime _DepartureTime { get; set; }
        [JsonProperty("DeviationId")] internal String _DeviationId { get; set; }
        [JsonProperty("FromHarbor")] internal FromHarbor _FromHarbor { get; set; }
        [JsonProperty("Id")] internal Int64 _Id { get; set; }
        [JsonProperty("Info")] internal String[] _Info { get; set; }
        [JsonProperty("ModifiedTime")] internal DateTime _ModifiedTime { get; set; }
        [JsonProperty("Route")] internal Route _Route { get; set; }
        [JsonProperty("ToHarbor")] internal ToHarbor _ToHarbor { get; set; }

        /// <summary>
        /// Anger att dataposten raderats.
        /// </summary>
        [JsonIgnore] public Boolean Deleted => _Deleted;
        /// <summary>
        /// Avgångstid.
        /// </summary>
        [JsonIgnore] public DateTime DepartureTime => _DepartureTime;
        /// <summary>
        /// Referens till Deviation.Id i objektet Situation.
        /// </summary>
        [JsonIgnore] public String DeviationId => _DeviationId;
        [JsonIgnore] public FromHarbor FromHarbor => _FromHarbor;
        /// <summary>
        /// Avgångens id. Fältet är nyckel för objektet.
        /// </summary>
        [JsonIgnore] public Int64 Id => _Id;
        /// <summary>
        /// Information om avgången.
        /// </summary>
        [JsonIgnore] public String[] Info => _Info;
        /// <summary>
        /// Tidpunkt då dataposten ändrades
        /// </summary>
        [JsonIgnore] public DateTime ModifiedTime => _ModifiedTime;
        [JsonIgnore] public Route Route => _Route;
        [JsonIgnore] public ToHarbor ToHarbor => _ToHarbor;

        internal FerryAnnouncementResponse() { }
    }

    public class FerryAnnouncementRequest : BaseTrafikverketRequest { public FerryAnnouncementRequest(Query Query) : base(Query) { } }

    public sealed class FerryAnnouncement : BaseTrafikverket<FerryAnnouncementResponse[]>
    {
        /// <summary>
        /// Ankomster och avgångar.
        /// </summary>
        /// <param name="APIKey">Användarens unika nyckel.</param>
        public FerryAnnouncement(String APIKey) : base(APIKey) { }

        /// <summary>
        /// SchemaVersion versionen som biblioteken använder.
        /// </summary>
        public override String CurrentSchemaVersion => "1.2";

        public override FerryAnnouncementResponse[] ExecuteRequest() => base.ExecuteRequest("FerryAnnouncement", CurrentSchemaVersion);
        /// <param name="XMLRequest">Custom requests must be written in XML, check "https://api.trafikinfo.trafikverket.se/API/TheRequest" in order to create custom requests.</param>
        public override FerryAnnouncementResponse[] ExecuteRequest(String XMLRequest) => base.ExecuteRequest("FerryAnnouncement", CurrentSchemaVersion, XMLRequest);
        public override FerryAnnouncementResponse[] ExecuteRequest(BaseTrafikverketRequest Request) => base.ExecuteCustomRequest(Request);
    }
}
