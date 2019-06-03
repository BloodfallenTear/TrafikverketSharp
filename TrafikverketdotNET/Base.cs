using System;

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
    public abstract class BaseTrafikverketResponse { }

    public class RequestQueryInvalidException : Exception { public RequestQueryInvalidException(String message) : base(message) { } }

    public abstract class BaseTrafikverketRequest
    {
        protected Query _Query { get; set; }
        public Query Query => _Query;

        protected BaseTrafikverketRequest(Query Query) { this._Query = Query; }

        public String CreateXMLString() => $"<REQUEST><LOGIN authenticationkey=\"AUTHKEY\"/>{Query.CreateXMLString()}</REQUEST>";
    }

    public abstract class BaseTrafikverket<T> : TrafikverketUtils where T : class
    {
        protected BaseTrafikverket(String APIKey) : base(APIKey) { }

        public abstract String CurrentSchemaVersion { get; }

        public abstract T ExecuteRequest();
        public abstract T ExecuteRequest(String XMLRequest);
        public abstract T ExecuteRequest(BaseTrafikverketRequest Request);

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

        protected virtual T ExecuteCustomRequest(BaseTrafikverketRequest Request)
        {
            var resp = POSTRequest(Request.CreateXMLString(), true);
            return JsonConvert.DeserializeObject<T>(JObject.Parse(resp)[$"{Request.Query.ObjectType}"].ToString());
        }
    }
}
