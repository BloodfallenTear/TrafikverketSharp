using System;
using System.Net.Http;
using System.Threading.Tasks;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TrafikverketdotNET
{
    public sealed class CameraResponse
    {
        [JsonProperty("Active")] internal Boolean _Active { get; set; }
        [JsonProperty("CameraGroup")] internal String _CameraGroup { get; set; }
        [JsonProperty("ContentType")] internal String _ContentType { get; set; }
        [JsonProperty("CountyNo")] internal Int32[] _CountyNo { get; set; }
        [JsonProperty("Deleted")] internal Boolean _Deleted { get; set; }
        [JsonProperty("Description")] internal String _Description { get; set; }
        [JsonProperty("Direction")] internal Int32 _Direction { get; set; }
        [JsonProperty("HasFullSizePhoto")] internal Boolean _HasFullSizePhoto { get; set; }
        [JsonProperty("HasSketchImage")] internal Boolean _HasSketchImage { get; set; }
        [JsonProperty("IconId")] internal String _IconId { get; set; }
        [JsonProperty("Id")] internal String _Id { get; set; }
        [JsonProperty("Location")] internal String _Location { get; set; }
        [JsonProperty("ModifiedTime")] internal DateTime _ModifiedTime { get; set; }
        [JsonProperty("Name")] internal String _Name { get; set; }
        [JsonProperty("PhotoTime")] internal DateTime _PhotoTime { get; set; }
        [JsonProperty("PhotoUrl")] internal String _PhotoUrl { get; set; }
        [JsonProperty("Status")] internal String _Status { get; set; }
        [JsonProperty("Type")] internal String _Type { get; set; }
        [JsonProperty("Geometry")] internal Geometry _Geometry { get; set; }

        /// <summary>
        /// Anger om kameran är aktiv eller ej.
        /// </summary>
        [JsonIgnore] public Boolean Active => _Active;
        /// <summary>
        /// Id för kameragrupp som kameran tillhör.
        /// </summary>
        [JsonIgnore] public String CameraGroup => _CameraGroup;
        /// <summary>
        /// Filändelse.
        /// </summary>
        [JsonIgnore] public String ContentType => _ContentType;
        /// <summary>
        /// Länsnummer (https://github.com/BloodfallenTear/Trafikverket.NET/blob/master/Lansnummer.txt).
        /// </summary>
        [JsonIgnore] public Int32[] CountyNo => _CountyNo;
        /// <summary>
        /// Anger att dataposten raderats.
        /// </summary>
        [JsonIgnore] public Boolean Deleted => _Deleted;
        /// <summary>
        /// Beskrivning.
        /// </summary>
        [JsonIgnore] public String Description => _Description;
        /// <summary>
        /// Anger i grader vilket håll kameran är riktad åt
        /// </summary>
        [JsonIgnore] public Int32 Direction => _Direction;
        /// <summary>
        /// Anger om det finns ett högupplöst foto. Finns det en högupplöst version av bilden fås den genom att ange queryparametern type=fullsize efter PhotoUrl
        /// </summary>
        [JsonIgnore] public Boolean HasFullSizePhoto => _HasFullSizePhoto;
        /// <summary>
        /// Anger om det finns skiss över kamerans position och riktning. Finns det en skiss fås den genom att ange queryparametern type=sketch efter PhotoUrl
        /// </summary>
        [JsonIgnore] public Boolean HasSketchImage => _HasSketchImage;
        /// <summary>
        /// Anger ikonid för kameratypen.
        /// </summary>
        [JsonIgnore] public String IconId => _IconId;
        /// <summary>
        /// Unikt id för kameran. Fältet är nyckel för objektet.
        /// </summary>
        [JsonIgnore] public String Id => _Id;
        /// <summary>
        /// Fritext som anger var kameran är placerad.
        /// </summary>
        [JsonIgnore] public String Location => _Location;
        /// <summary>
        /// Tidpunkt då dataposten ändrades.
        /// </summary>
        [JsonIgnore] public DateTime ModifiedTime => _ModifiedTime;
        /// <summary>
        /// Namn på kameran.
        /// </summary>
        [JsonIgnore] public String Name => _Name;
        /// <summary>
        /// Tidpunkt då bilden är tagen.
        /// </summary>
        [JsonIgnore] public DateTime PhotoTime => _PhotoTime;
        /// <summary>
        /// Url till bild 385px*290px (Ytterligare funktionalitet: https://github.com/BloodfallenTear/Trafikverket.NET/blob/master/PhotoUrl.txt).
        /// </summary>
        [JsonIgnore] public String PhotoUrl => _PhotoUrl;
        /// <summary>
        /// Anger en statustext för kameran.
        /// </summary>
        [JsonIgnore] public String Status => _Status;
        /// <summary>
        /// Typ av kamera, "Väglagskamera" eller "Trafikkamera".
        /// </summary>
        [JsonIgnore] public String Type => _Type;
        /// <summary>
        /// Geometrisk punkt i koordinatsystem. Fältet kan användas för geo-frågor.
        /// </summary>
        [JsonIgnore] public Geometry Geometry => _Geometry;

        internal CameraResponse() { }
    }

    /// <summary>
    /// Kameror för automatisk väglag och trafikflöde.
    /// </summary>
    public sealed class Camera : BaseTrafikverket<CameraResponse[]>
    {
        /// <summary>
        /// Kameror för automatisk väglag och trafikflöde.
        /// </summary>
        /// <param name="APIKey">Användarens unika nyckel.</param>
        public Camera(String APIKey) : base(APIKey) { }

        public override CameraResponse[] ExecuteRequest() => ExecuteRequest("Camera", "1");

        /// <param name="XMLRequest">Custom requests must be written in XML, check "https://api.trafikinfo.trafikverket.se/API/TheRequest" in order to create custom requests.</param>
        public override CameraResponse[] ExecuteRequest(String XMLRequest) => ExecuteRequest("Camera", "1", XMLRequest);
    }
}
