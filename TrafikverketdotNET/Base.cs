using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace TrafikverketdotNET
{
    //SWEREF 99 TM
    //WGS 84

    public abstract class BaseTrafikverket
    {
        public const String URL = "https://api.trafikinfo.trafikverket.se/v1.3/data.json";

        protected async Task<String> GETResponse()
        {
            var stringContent = new StringContent("<REQUEST>" +
                                                    "<LOGIN authenticationkey=\"8877ef94bb724ebdb119eedbc17840c4\" />" +
                                                    "<QUERY objecttype=\"WeatherStation\">" +
                                                        "<FILTER>" +
                                                            "<EQ name=\"Name\" value=\"Högakustenbron Topp\" />" +
                                                        "</FILTER>" +
                                                        "<INCLUDE>Measurement.Air.Temp</INCLUDE>" +
                                                        "<INCLUDE>Measurement.MeasureTime</INCLUDE>" +
                                                    "</QUERY>" +
                                                  "</REQUEST> ");

            using (var http = new HttpClient())
            {
                HttpResponseMessage resp = null;

                try { resp = await http.PostAsync(URL, stringContent); }
                catch (Exception e) { Console.WriteLine(e.Message); }
                Console.WriteLine(await resp.Content.ReadAsStringAsync());
            }

            return null;
        }
    }

    public class X : BaseTrafikverket
    {
        public async Task Y()
        {
            await base.GETResponse();
        }
    }
}
