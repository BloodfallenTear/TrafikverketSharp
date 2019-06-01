using System;
using System.Net.Http;
using System.Text;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

/* 
 * <REQUEST>
      <LOGIN authenticationkey="xxx" />
      <QUERY objecttype="xxx" schemaversion="xxx">
          <FILTER>
              <EQ name="" value="" />
              <EXISTS name="" value="" />
              <GT name="" value="" />
              <GTE name="" value="" />
              <LT name="" value="" />
              <LTE name="" value="" />
              <NE name="" value="" />
              <LIKE name="" value="" />
              <NOTLIKE name="" value="" />
              <IN name="" value="" />
              <NOTIN name="" value="" />
              <WITHIN shape="" name="" value="" />
              <INTERSECTS shape="" name="" value="" />
              <NEAR name="" value="" mindistance="" maxdistance="" />
              
              <OR>
                  
              </OR>
              <AND>
                  
              </AND>
              <ELEMENTMATCH>
                  
              </ELEMENTMATCH>
              <NOT>
                  
              </NOT>
          </FILTER>
      </QUERY>
   </REQUEST>
*/

namespace TrafikverketdotNET
{
    public abstract class TrafikverketRequest
    {

    }

    public class TrainStationRequest : TrafikverketRequest
    {
        private Login _Login { get; set; }
        private List<Query> _Queries { get; set; }

        public Login Login => _Login;
        public List<Query> Queries => _Queries;

        public TrainStationRequest(Login Login) { this._Login = Login; this._Queries = new List<Query>(); }
        public TrainStationRequest(Login Login, List<Query> Queries) { this._Login = Login; this._Queries = Queries; }

        public String CreateXMLString()
        {
            var xmlString = $"<REQUEST><LOGIN authenticationkey=\"xxx\"/>";
            foreach (var query in Queries)
                xmlString += $"{query.CreateXMLString()}";
            return $"{xmlString}</REQUEST>";
        }

        public Query AddQuery(Query Query)
        {
            _Queries.Add(Query);
            return Query;
        }
    }

    public class Login
    {
        String AuthenticationKey;
    }

    public class Query
    {
        public ObjectType ObjectType;
        public String SchemaVersion;
        public String ID;
        public Boolean IncludeDeletedObjects;
        public UInt32 Limit;
        public String OrderBy;
        public UInt32 Skip;
        public Boolean LastModified;
        public Int32 ChangeID;

        public Filter Filter;

        public List<String> Include;
        public List<String> Exclude;
        public String Distinct;

        public Query(ObjectType ObjectType, String SchemaVersion) { this.ObjectType = ObjectType; this.SchemaVersion = SchemaVersion; Filter = new Filter(); }
        public Query(ObjectType ObjectType, String SchemaVersion, Filter Filter) { this.ObjectType = ObjectType; this.SchemaVersion = SchemaVersion; this.Filter = Filter; }

        public String CreateXMLString()
        {
            var xmlString = $"<QUERY objecttype=\"{ObjectType}\" schemaversion=\"{SchemaVersion}\"";

            if (ID?.Length > 0)
                xmlString += $" id=\"{ID}\"";
            if(IncludeDeletedObjects)
                xmlString += $" includedeletedobjects=\"{IncludeDeletedObjects}\"";
            if (Limit != 0)
                xmlString += $" limit=\"{Limit}\"";
            if (OrderBy?.Length > 0)
                xmlString += $" orderby=\"{OrderBy}\"";
            if (Skip != 0)
                xmlString += $" skip=\"{Skip}\"";
            if (LastModified)
                xmlString += $" lastmodified=\"{LastModified}\"";
            if (ChangeID != 0)
                xmlString += $" changeid=\"{ChangeID}\"";

            return $"{xmlString}>{Filter.CreateXMLString()}</QUERY>";
        }

        public void SetFilter(Filter Filter) { this.Filter = Filter; }
    }

    public class Filter
    {
        private List<FilterOperator> _FilterOperators { get; set; }
        private List<FilterGroup> _FilterGroups { get; set; }

        public List<FilterOperator> FilterOperators => _FilterOperators;
        public List<FilterGroup> FilterGroups => _FilterGroups;

        public Filter() { _FilterOperators = new List<FilterOperator>(); _FilterGroups = new List<FilterGroup>(); }

        public Filter AddOperator(FilterOperator FilterOperator)
        {
            _FilterOperators.Add(FilterOperator);
            return this;
        }

        public Filter AddGroup(FilterGroup FilterGroup)
        {
            _FilterGroups.Add(FilterGroup);
            return this;
        }

        public String CreateXMLString()
        {
            String xmlString = null;

            foreach (var group in FilterGroups)
                xmlString += $"{group.CreateXMLString()}";

            foreach (var oper in FilterOperators)
                xmlString += $"{oper.CreateXMLString()}";

            if (xmlString.Length > 0)
                return $"<FILTER>{xmlString}</FILTER>";
            return null;
        }

        public void SetFilterOperators(List<FilterOperator> FilterOperators) { this._FilterOperators = FilterOperators; }
        public void SetFilterGroups(List<FilterGroup> FilterGroups) { this._FilterGroups = FilterGroups; }
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

        //protected virtual T ExecuteRequest(String ObjectType, String SchemaVersion, TrafikverketRequest Request)
        //{

        //    return null;
        //}

        protected T ExecuteRequest(String ObjectType, String SchemaVersion, TrafikverketRequest Request)
        {

            return null;
        }

        /// <param name="RequestQuery">The HTTP request content sent to the server.</param>
        protected String POSTRequest(String RequestQuery, Boolean CustomRequest = false)
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

                    if (CustomRequest)
                        return data["RESPONSE"]["RESULT"].ToString();
                    else
                        return data["RESPONSE"]["RESULT"][0].ToString();
                }
            }
            catch (HttpRequestException err) { throw new Exception(err.Message, err.InnerException); }
        }
    }
        
    public sealed class Trafikverket : IDisposable
    {
        private readonly String APIKey;

        /// <param name="APIKey">Användarens unika nyckel.</param>
        public Trafikverket(String APIKey) { this.APIKey = APIKey; }

        ~Trafikverket() { Dispose(); }

        public String XMLRequestTemplate => $"<REQUEST><LOGIN authenticationkey=\"{APIKey}\"/><QUERY objecttype=\"{{ObjectType}}\"><FILTER></FILTER></QUERY></REQUEST>";
        public String XMLRequestTemplateLegacy => "<REQUEST><LOGIN authenticationkey=\"\"/><QUERY objecttype=\"\"><FILTER></FILTER></QUERY></REQUEST>";

        #region Järnväg - Trafikinformation
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
        #endregion

        #region Väg - Trafikinformation
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
        /// <summary>
        /// Information om väglagsöversikt.
        /// </summary>
        public RoadConditionOverview RoadConditionOverview => new RoadConditionOverview(APIKey);
        /// <summary>
        /// Situationer innehållandes händelser och störningar som trafikmeddelanden, vägarbeten, olyckor, restiktioner m.m.
        /// </summary>
        public Situation Situation => new Situation(APIKey);
        /// <summary>
        /// Uppmätta eller härledda värden relaterat till trafik eller enskilda fordonets rörelser på en viss sektion eller vid en specifik punkt på vägnätet.
        /// </summary>
        public TrafficFlow TrafficFlow => new TrafficFlow(APIKey);
        /// <summary>
        /// Trafiksäkerhetskameror.
        /// </summary>
        public TrafficSafetyCamera TrafficSafetyCamera => new TrafficSafetyCamera(APIKey);
        /// <summary>
        /// Restider i större städer eller i högbelastade trafiksystem. 
        /// Beräkning av restid baseras på data från detektorer som är utplacerade längs bestämda rutter.
        /// </summary>
        public TravelTimeRoute TravelTimeRoute => new TravelTimeRoute(APIKey);
        /// <summary>
        /// Väderstationer med mätdata.
        /// </summary>
        public WeatherStation WeatherStation => new WeatherStation(APIKey);
        #endregion

        #region Väg - Beläggningsinformation
        /// <summary>
        /// Mätdata per 100 meter. 
        /// Ett medelvärde har räknats fram för 100 meter baserat på de ingående 20-metersvärdena (se mer info i MeasurementData20). 
        /// Observera att det inte finns 100-metersdata för alla våra 20-metersvariabler. 
        /// Källsystem är PMS-systemen.
        /// </summary>
        public MeasurementData100 MeasurementData100 => new MeasurementData100(APIKey);
        /// <summary>
        /// Mätdata per 20 meter. Data från vägytemätningar med laserscanning alternativt som beräknats fram baserat på dem. 
        /// Mätningarna utförs årligen eller vartannat år beroende på trafikmängd. 
        /// Senast gällande mätdata finns att hämta dvs ej historik. Källsystem är PMS-systemen.
        /// </summary>
        public MeasurementData20 MeasurementData20 => new MeasurementData20(APIKey);
        /// <summary>
        /// Beläggningsdata från PMS-systemen kombinerat med relevant vägdata från NVDB. 
        /// Vi kan ej garantera att det är helt aktuellt data från NVDB. Datum för när data hämtades framgår av posten TimeStamp. 
        /// För att se källa för respektive data, gå till fliken Om variabler i systemet PMSV3.
        /// </summary>
        public PavementData PavementData => new PavementData(APIKey);
        /// <summary>
        /// Vägens geometri relaterat till det data vi tillhandahåller från PMS-systemen med data om beläggningar och mätdata.
        /// Vi kan ej garantera att geometrin är dagsaktuell från NVDB. Datum för när data hämtades framgår av posten TimeStamp. 
        /// </summary>
        public RoadGeometry RoadGeometry => new RoadGeometry(APIKey); 
        #endregion

        public void Dispose() { GC.SuppressFinalize(this); }
    }
}
