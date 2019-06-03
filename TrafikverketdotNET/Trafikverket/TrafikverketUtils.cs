using System;
using System.Net.Http;
using System.Text;
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
                        throw new Exception($"Status Code: {resp.StatusCode}");

                    var respString = resp.Content.ReadAsStringAsync().Result;
                    var data = JObject.Parse(respString);

                    if (TrafikverketRequest)
                        return data["RESPONSE"]["RESULT"].ToString();
                    else
                        return data["RESPONSE"]["RESULT"][0].ToString();
                }
            }
            catch (HttpRequestException err) { throw new Exception(err.Message, err.InnerException); }
        }
    }
}
