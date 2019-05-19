using System;
using System.Net.Http;
using System.Text;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TrafikverketdotNET
{
    public abstract class TrafikverketRequest
    {

    }

    public class TrainStationRequest : TrafikverketRequest
    {

    }

    public abstract class BaseTrafikverket<T> where T : class
    {
        protected const String URL = "https://api.trafikinfo.trafikverket.se/v2/data.json";
        protected readonly String APIKey;

        /// <param name="APIKey">Användarens unika nyckel.</param>
        protected BaseTrafikverket(String APIKey) { this.APIKey = APIKey; }

        public abstract String CurrentSchemaVersion { get; }

        public abstract T ExecuteRequest();
        public abstract T ExecuteRequest(String XMLRequest);
        //public abstract T ExecuteRequest(TrafikverketRequest Request);

        protected virtual T ExecuteRequest(String ObjectType, String SchemaVersion)
        {
            var resp = POSTRequest($"<REQUEST>" +
                                    $"<LOGIN authenticationkey=\"{APIKey}\"/>" +
                                    $"<QUERY objecttype=\"{ObjectType}\" schemaversion=\"{SchemaVersion}\"/>" +
                                   $"</REQUEST>");
            return JsonConvert.DeserializeObject<T>(JObject.Parse(resp)[$"{ObjectType}"].ToString());
        }

        protected virtual T ExecuteRequest(String ObjectType, String SchemaVersion, String RequestQuery)
        {
            var resp = POSTRequest(RequestQuery);
            return JsonConvert.DeserializeObject<T>(JObject.Parse(resp)[$"{ObjectType}"].ToString());
        }

        /// <param name="RequestQuery">The HTTP request content sent to the server.</param>
        protected String POSTRequest(String RequestQuery)
        {
            try
            {
                var content = new StringContent(RequestQuery, Encoding.UTF8, "application/xml");
                using (var http = new HttpClient())
                {
                    var resp = http.PostAsync(URL, content).Result;
                    if (!resp.IsSuccessStatusCode)
                        throw new Exception($"Status Code: {resp.StatusCode}");

                    var respString = resp.Content.ReadAsStringAsync().Result;

                    var data = JObject.Parse(respString);
                    return data["RESPONSE"]["RESULT"][0].ToString();
                }
            }
            catch (HttpRequestException err) { throw new Exception(err.Message, err.InnerException); }
        }
    }
        
    public sealed class Trafikverket
    {
        private readonly String APIKey;

        /// <param name="APIKey">Användarens unika nyckel.</param>
        public Trafikverket(String APIKey) { this.APIKey = APIKey; }

        public String XMLRequestTemplate => "<REQUEST><LOGIN authenticationkey=\"\"/><QUERY objecttype=\"\"><FILTER></FILTER></QUERY></REQUEST>";

        /// <summary>
        /// Tidtabellsinformation, d.v.s information om tåg på trafikplatser (stationer, hållplatser) varje post motsvarar ett visst tåg vid respektive trafikplats.
        /// </summary>
        public TrainAnnouncement TrainAnnouncement => new TrainAnnouncement(APIKey);
        /// <summary>
        /// Tågtrafikmeddelande, exempelvis information kring banarbete, tågfel, anläggningsfel och dylikt.
        /// </summary>
        public TrainMessage TrainMessage => new TrainMessage(APIKey);
        /// <summary>
        /// Trafikplatser, både med och utan resandeutbyte.
        /// </summary>
        public TrainStation TrainStation => new TrainStation(APIKey);
        
        /// <summary>
        /// Kameror för automatisk väglag och trafikflöde.
        /// </summary>
        public Camera Camera => new Camera(APIKey);
        /// <summary>
        /// Ankomster och avgångar.
        /// </summary>
        public FerryAnnouncement FerryAnnouncement => new FerryAnnouncement(APIKey);
        /// <summary>
        /// Information om färjeleder.
        /// </summary>
        public FerryRoute FerryRoute => new FerryRoute(APIKey);
        /// <summary>
        /// Ikoner, exempelvis för använding i grafiska användargränssnitt och kartor.
        /// </summary>
        public Icon Icon => new Icon(APIKey);
        /// <summary>
        /// Information om rastplatser och parkeringar.
        /// </summary>
        public Parking Parking => new Parking(APIKey);
        /// <summary>
        /// Information om väglag.
        /// </summary>
        public RoadCondition RoadCondition => new RoadCondition(APIKey);
    }

    public sealed class Type
    {
        [JsonProperty("Id")] internal Int32 _Id { get; set; }
        [JsonProperty("Name")] internal String _Name { get; set; }

        /// <summary>
        /// Id för ledtypen.
        /// </summary>
        [JsonIgnore] public Int32 Id => _Id;
        /// <summary>
        /// Namn för ledtypen (ex. Vändande).
        /// </summary>
        [JsonIgnore] public String Name => _Name;

        internal Type() { }
    }

    public sealed class Geometry
    {
        [JsonProperty("SWEREF99TM")] internal String _SWEREF99TM { get; set; }
        [JsonProperty("WGS84")] internal String _WGS84 { get; set; }

        /// <summary>
        /// Geometrisk punkt i koordinatsystem SWEREF99TM.
        /// </summary>
        [JsonIgnore] public String SWEREF99TM => _SWEREF99TM;
        /// <summary>
        /// Geometrisk punkt i koordinatsystem WGS84
        /// </summary>
        [JsonIgnore] public String WGS84 => _WGS84;

        internal Geometry() { }
    }
}
