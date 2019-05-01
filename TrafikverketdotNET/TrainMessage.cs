using System;
using System.Net.Http;
using System.Threading.Tasks;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TrafikverketdotNET
{
    public sealed class TrainMessageResponse
    {
        [JsonProperty("AffectedLocation")] internal String[] _AffectedLocation { get; set; }
        [JsonProperty("CountyNo")] internal Int32[] _CountyNo { get; set; }
        [JsonProperty("Deleted")] internal Boolean _Deleted { get; set; }
        [JsonProperty("EndDateTime")] internal DateTime _EndDateTime { get; set; }
        [JsonProperty("EventId")] internal String _EventId { get; set; }
        [JsonProperty("ExternalDescription")] internal String _ExternalDescription { get; set; }
        [JsonProperty("Header")] internal String _Header { get; set; }
        [JsonProperty("LastUpdateDateTime")] internal DateTime _LastUpdateDateTime { get; set; }
        [JsonProperty("ModifiedTime")] internal DateTime _ModifiedTime { get; set; }
        [JsonProperty("ReasonCodeText")] internal String _ReasonCodeText { get; set; }
        [JsonProperty("StartDateTime")] internal DateTime _StartDateTime { get; set; }
        [JsonProperty("Geometry")] internal Geometry _Geometry { get; set; }
        [JsonProperty("TrafficImpact")] internal TrafficImpact[] _TrafficImpact { get; set; }

        /// <summary>
        /// Påverkade trafikplatser (stationssignatur).
        /// </summary>
        [JsonIgnore] public String[] AffectedLocation => _AffectedLocation;
        /// <summary>
        /// Länsnummer (https://github.com/BloodfallenTear/Trafikverket.NET/blob/master/Lansnummer.txt).
        /// </summary>
        [JsonIgnore] public Int32[] CountyNo => _CountyNo;
        /// <summary>
        /// Anger att dataposten raderats.
        /// </summary>
        [JsonIgnore] public Boolean Deleted => _Deleted;
        /// <summary>
        /// Händelsens sluttid.
        /// </summary>
        [JsonIgnore] public DateTime EndDateTime => _EndDateTime;
        /// <summary>
        /// Unikt id för händelsen.
        /// </summary>
        [JsonIgnore] public String EventId => _EventId;
        /// <summary>
        /// Informationstext.
        /// </summary>
        [JsonIgnore] public String ExternalDescription => _ExternalDescription;
        /// <summary>
        /// Redaktörssatt rubrik för händelsen, kan i vissa fall vara samma som ReasonCodeText.
        /// </summary>
        [JsonIgnore] public String Header => _Header;
        /// <summary>
        /// Tidpunkt då händelsen uppdaterades.
        /// </summary>
        [JsonIgnore] public DateTime LastUpdateDateTime => _LastUpdateDateTime;
        /// <summary>
        /// Tidpunkt då dataposten ändrades.
        /// </summary>
        [JsonIgnore] public DateTime ModifiedTime => _ModifiedTime;
        /// <summary>
        /// Händelsens eventuella orsak.
        /// </summary>
        [JsonIgnore] public String ReasonCodeText => _ReasonCodeText;
        /// <summary>
        /// Händelsens starttid.
        /// </summary>
        [JsonIgnore] public DateTime StartDateTime => _StartDateTime;
        [JsonIgnore] public Geometry Geometry => _Geometry;
        [JsonIgnore] public TrafficImpact[] TrafficImpact => _TrafficImpact;

        internal TrainMessageResponse() { }
    }

    public sealed class TrainMessage : BaseTrafikverket
    {
        public TrainMessage(string APIKey) : base(APIKey) { }

        public async Task<TrainMessageResponse[]> ExecuteRequest()
        {
            var resp = await base.POSTRequest(new StringContent($"<REQUEST><LOGIN authenticationkey=\"{base.APIKey}\"/><QUERY objecttype=\"TrainMessage\"/></REQUEST>"));
            return JsonConvert.DeserializeObject<TrainMessageResponse[]>(JObject.Parse(resp)["TrainMessage"].ToString());
        }
    }
}
