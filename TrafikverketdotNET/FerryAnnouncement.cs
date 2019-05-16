using System;
using Newtonsoft.Json;

namespace TrafikverketdotNET
{ 
    public sealed class FerryAnnouncementResponse
    {
        [JsonProperty("Deleted")] internal Boolean _Deleted { get; set; }
        [JsonProperty("DepartureTime")] internal DateTime _DepartureTime { get; set; }
        [JsonProperty("DeviationId")] internal String _DeviationId { get; set; }
        [JsonProperty("FromHarbor")] internal FromHarborResp _FromHarbor { get; set; }
        [JsonProperty("Id")] internal Int64 _Id { get; set; }
        [JsonProperty("Info")] internal String[] _Info { get; set; }
        [JsonProperty("ModifiedTime")] internal DateTime _ModifiedTime { get; set; }
        [JsonProperty("Route")] internal RouteResp _Route { get; set; }
        [JsonProperty("ToHarbor")] internal ToHarborResp _ToHarbor { get; set; }

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
        [JsonIgnore] public FromHarborResp FromHarbor => _FromHarbor;
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
        [JsonIgnore] public RouteResp Route => _Route;
        [JsonIgnore] public ToHarborResp ToHarbor => _ToHarbor;

        public sealed class FromHarborResp
        {
            [JsonProperty("Id")] internal Int32 _Id { get; set; }
            [JsonProperty("Name")] internal String _Name { get; set; }

            /// <summary>
            /// Avgår från (id).
            /// </summary>
            [JsonIgnore] public Int32 Id => _Id;
            /// <summary>
            /// Avgår från (namn).
            /// </summary>
            [JsonIgnore] public String Name => _Name;

            internal FromHarborResp() { }
        }

        public sealed class RouteResp
        {
            [JsonProperty("Description")] internal String _Description { get; set; }
            [JsonProperty("Id")] internal Int32 _Id { get; set; }
            [JsonProperty("Name")] internal String _Name { get; set; }
            [JsonProperty("Shortname")] internal String _Shortname { get; set; }
            [JsonProperty("Type")] internal TrafikverketdotNET.Type _Type { get; set; }

            /// <summary>
            /// Beskrivande text om rutten.
            /// </summary>
            [JsonIgnore] public String Description => _Description;
            /// <summary>
            /// Ruttens id.
            /// </summary>
            [JsonIgnore] public Int32 Id => _Id;
            /// <summary>
            /// Ruttens namn
            /// </summary>
            [JsonIgnore] public String Name => _Name;
            /// <summary>
            /// Ruttens korntamn.
            /// </summary>
            [JsonIgnore] public String Shortname => _Shortname;
            /// <summary>
            /// Id för ledtypen.
            /// </summary>
            [JsonIgnore] public TrafikverketdotNET.Type Type => _Type;

            internal RouteResp() { }
        }

        public sealed class ToHarborResp
        {
            [JsonProperty("Id")] internal Int32 _Id { get; set; }
            [JsonProperty("Name")] internal String _Name { get; set; }

            /// <summary>
            /// Ankommer till (id).
            /// </summary>
            [JsonIgnore] public Int32 Id => _Id;
            /// <summary>
            /// Ankommer till (namn).
            /// </summary>
            [JsonIgnore] public String Name => _Name;

            internal ToHarborResp() { }
        }

        internal FerryAnnouncementResponse() { }
    }

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

        public override FerryAnnouncementResponse[] ExecuteRequest() => ExecuteRequest("FerryAnnouncement", CurrentSchemaVersion);

        /// <param name="XMLRequest">Custom requests must be written in XML, check "https://api.trafikinfo.trafikverket.se/API/TheRequest" in order to create custom requests.</param>
        public override FerryAnnouncementResponse[] ExecuteRequest(String XMLRequest) => ExecuteRequest("FerryAnnouncement", CurrentSchemaVersion, XMLRequest);
    }
}
