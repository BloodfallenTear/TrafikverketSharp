using System;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TrafikverketdotNET
{
    public abstract class TrafikverketUtils
    {
        protected const String URL = "https://api.trafikinfo.trafikverket.se/v2/data.json";
        protected readonly String APIKey;

        protected TrafikverketUtils(String APIKey) { this.APIKey = APIKey; }

        /// <param name="RequestQuery">The HTTP request content sent to the server.</param>
        /// <param name="CustomRequest">True if this is a custom made request.</param>
        /// <param name="TrafikverketRequest">True if this is a 'TrafikverketRequest' (a general request with multiple queries).</param>
        /// <exception cref="TrafikverketException">Thrown when Trafikverket returns an error.</exception>
        protected String POSTRequest(String RequestQuery, Boolean CustomRequest = false, Boolean TrafikverketRequest = false)
        {
            try
            {
                if (CustomRequest)
                    RequestQuery = RequestQuery.Replace("<LOGIN authenticationkey=\"AUTHKEY\"/>", $"<LOGIN authenticationkey=\"{APIKey}\"/>"); //Normally, I would've just replaced 'AUTHKEY', but this is a measure in case the user writes AUTHKEY somewhere else in their request, even though it makes no sense for them to do so.

                var content = new StringContent(RequestQuery, Encoding.UTF8, "application/xml");
                using (var http = new HttpClient())
                {
                    var resp = http.PostAsync(URL, content).Result;
                    if (!resp.IsSuccessStatusCode)
                    {
                        var statusCode = resp.StatusCode;
                        var err = JsonConvert.DeserializeObject<RequestError>(JObject.Parse(resp.Content.ReadAsStringAsync().Result)["RESPONSE"]["RESULT"][0]["ERROR"].ToString());

                        throw new TrafikverketException($"Error Source: \"{err.Source}\", Error Message: \"{err.Message}\". Status Code: {statusCode} ({(Int32)statusCode})");
                    }

                    var respString = resp.Content.ReadAsStringAsync().Result;
                    var data = JObject.Parse(respString);

                    if (TrafikverketRequest)
                        return data["RESPONSE"].ToString();
                    else
                        return data["RESPONSE"]["RESULT"][0].ToString();
                }
            }
            catch (HttpRequestException err) { throw new TrafikverketException(err.Message, err.InnerException); }
        }

        internal class RequestError
        {
            [JsonProperty("SOURCE")] internal String _Source { get; set; }
            [JsonProperty("MESSAGE")] internal String _Message { get; set; }

            [JsonIgnore] public String Source => _Source;
            [JsonIgnore] public String Message => _Message;
        }
    }
}
