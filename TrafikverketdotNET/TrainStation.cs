using System;
using System.Net.Http;
using System.Threading.Tasks;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TrafikverketdotNET
{
    public sealed class TrainStationResponse
    {
        [JsonProperty("Advertised")] internal Boolean _Advertised { get; set; }
        [JsonProperty("AdvertisedLocationName")] internal String _AdvertisedLocationName { get; set; }
        [JsonProperty("AdvertisedShortLocationName")] internal String _AdvertisedShortLocationName { get; set; }
        [JsonProperty("CountryCode")] internal String _CountryCode { get; set; }
        [JsonProperty("CountyNo")] internal Int32[] _CountyNo { get; set; }
        [JsonProperty("Deleted")] internal Boolean _Deleted { get; set; }
        [JsonProperty("LocationInformationText")] internal String _LocationInformationText { get; set; }
        [JsonProperty("LocationSignature")] internal String _LocationSignature { get; set; }
        [JsonProperty("ModifiedTime")] internal DateTime _ModifiedTime { get; set; }
        [JsonProperty("PlatformLine")] internal String[] _PlatformLine { get; set; }
        [JsonProperty("Prognosticated")] internal Boolean _Prognosticated { get; set; }
        [JsonProperty("Geometry")] internal Geometry _Geometry { get; set; }

        /// <summary>
        /// Anger om stationen annonseras i tidtabell.
        /// </summary>
        [JsonIgnore] public Boolean Advertised => _Advertised;
        /// <summary>
        /// Stationens namn.
        /// </summary>
        [JsonIgnore] public String AdvertisedLocationName => _AdvertisedLocationName;
        /// <summary>
        /// Stationens namn i kort version.
        /// </summary>
        [JsonIgnore] public String AdvertisedShortLocationName => _AdvertisedShortLocationName;
        /// <summary>
        /// Beteckning för i vilket land stationen finns (https://github.com/BloodfallenTear/Trafikverket.NET/blob/master/CountryCode.txt).
        /// </summary>
        [JsonIgnore] public String CountryCode => _CountryCode;
        /// <summary>
        /// Länsnummer (https://github.com/BloodfallenTear/Trafikverket.NET/blob/master/Lansnummer.txt).
        /// </summary>
        [JsonIgnore] public Int32[] CountyNo => _CountyNo;
        /// <summary>
        /// Anger att dataposten raderats.
        /// </summary>
        [JsonIgnore] public Boolean Deleted => _Deleted;
        /// <summary>
        /// Upplysningsinformation för stationen, ex. "SL-tåg omfattas ej.", "Ring 033-172444 för trafikinformation".
        /// </summary>
        [JsonIgnore] public String LocationInformationText => _LocationInformationText;
        /// <summary>
        /// Stationens unika signatur, ex. "Cst". Fältet är nyckel för objektet.
        /// </summary>
        [JsonIgnore] public String LocationSignature => _LocationSignature;
        /// <summary>
        /// Tidpunkt då dataposten ändrades.
        /// </summary>
        [JsonIgnore] public DateTime ModifiedTime => _ModifiedTime;
        /// <summary>
        /// Plattformens spår.
        /// </summary>
        [JsonIgnore] public String[] PlatformLine => _PlatformLine;
        /// <summary>
        /// Anger om stationen prognostiseras i tidtabell.
        /// </summary>
        [JsonIgnore] public Boolean Prognosticated => _Prognosticated;
        /// <summary>
        /// Geometrisk punkt i koordinatsystem. Fältet kan användas för geo-frågor.
        /// </summary>
        [JsonIgnore] public Geometry Geometry => _Geometry;

        internal TrainStationResponse() { }
    }

    /// <summary>
    /// Trafikplatser, både med och utan resandeutbyte.
    /// </summary>
    public sealed class TrainStation : BaseTrafikverket<TrainStationResponse[]>
    {
        /// <summary>
        /// Trafikplatser, både med och utan resandeutbyte.
        /// </summary>
        /// <param name="APIKey">Användarens unika nyckel.</param>
        public TrainStation(String APIKey) : base(APIKey) { }

        public TrainStationResponse[] ExecuteRequest()
        {
            var resp = base.POSTRequest($"<REQUEST><LOGIN authenticationkey=\"{base.APIKey}\"/><QUERY objecttype=\"TrainStation\" schemaversion=\"1\"/></REQUEST>");
            return JsonConvert.DeserializeObject<TrainStationResponse[]>(JObject.Parse(resp)["TrainStation"].ToString());
        }
    }
}
