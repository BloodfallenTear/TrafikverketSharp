﻿using System;
using System.Net.Http;
using System.Threading.Tasks;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TrafikverketdotNET
{
    //SWEREF 99 TM
    //WGS 84

    public interface IBaseTrafikverket<T>
    {
        Task<T> ExecuteRequest();
    }

    public abstract class BaseTrafikverket
    {
        protected const String URL = "https://api.trafikinfo.trafikverket.se/v1.3/data.json";
        protected readonly String APIKey;

        /// <param name="APIKey">Användarens unika nyckel.</param>
        protected BaseTrafikverket(String APIKey) { this.APIKey = APIKey; }

        //public virtual async Task<T> ExecuteRequest<T>(String ObjectType)
        //{
        //    var resp = await POSTRequest(new StringContent($"<REQUEST><LOGIN authenticationkey=\"{APIKey}\"/><QUERY objecttype=\"{ObjectType}\"/></REQUEST>"));
        //    return JsonConvert.DeserializeObject<T>(JObject.Parse(resp)[$"{ObjectType}"].ToString());
        //}

        /// <param name="Content">The HTTP request content sent to the server.</param>
        protected async Task<String> POSTRequest(HttpContent Content)
        {
            using (var http = new HttpClient())
            {
                var resp = await http.PostAsync(URL, Content);
                var respString = await resp.Content.ReadAsStringAsync();

                var data = JObject.Parse(respString);
                return data["RESPONSE"]["RESULT"][0].ToString();
            }
        }
    }
        
    public sealed class Trafikverket : BaseTrafikverket
    {
        /// <param name="APIKey">Användarens unika nyckel.</param>
        public Trafikverket(String APIKey) : base(APIKey) { }

        public TrainMessage TrainMessage => new TrainMessage(base.APIKey);
        public TrainStation TrainStation => new TrainStation(base.APIKey);
        public TrainAnnouncement TrainAnnouncement => new TrainAnnouncement(base.APIKey);
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
