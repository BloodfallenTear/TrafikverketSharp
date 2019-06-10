using System;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TrafikverketdotNET
{
    public sealed class Trafikverket : TrafikverketUtils, IDisposable
    {
        /// <param name="APIKey">Användarens unika nyckel.</param>
        public Trafikverket(String APIKey) : base(APIKey) { }

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

        public static Dictionary<ObjectType, String> SchemaVersions => new Dictionary<ObjectType, String>()
        {
            { ObjectType.TrainAnnouncement, "1.5" },
            { ObjectType.TrainMessage, "1.4" },
            { ObjectType.TrainStation, "1" },
            { ObjectType.Camera, "1" },
            { ObjectType.FerryAnnouncement, "1.2" },
            { ObjectType.FerryRoute, "1.2" },
            { ObjectType.Icon, "1" },
            { ObjectType.Parking, "1" },
            { ObjectType.RoadCondition, "1.2" },
            { ObjectType.RoadConditionOverview, "1" },
            { ObjectType.Situation, "1.2" },
            { ObjectType.TrafficSafetyCamera, "1" },
            { ObjectType.TravelTimeRoute, "1´.4" },
            { ObjectType.WeatherStation, "1" },
            { ObjectType.MeasurementData100, "1" },
            { ObjectType.MeasurementData20, "1" },
            { ObjectType.PavementData, "1" },
            { ObjectType.RoadData, "1" },
            { ObjectType.RoadGeometry, "1" }
        };

        public TrafikverketResponse ExecuteRequest(TrafikverketRequest Request)
        {
            var trafikverketResp = new TrafikverketResponse();
            var resp = base.POSTRequest(Request.CreateXMLString(), true, true);
            var array = JArray.Parse(resp);

            for (int i = 0; i < array.Count; i++)
            {
                switch (Request.Queries[i].ObjectType)
                {
                    case ObjectType.TrainAnnouncement:
                        trafikverketResp._TrainAnnouncementResponse = JsonConvert.DeserializeObject<TrainAnnouncementResponse[]>(array[i][$"{Request.Queries[i].ObjectType}"].ToString());
                        break;
                    case ObjectType.TrainMessage:
                        trafikverketResp._TrainMessageResponse = JsonConvert.DeserializeObject<TrainMessageResponse[]>(array[i][$"{Request.Queries[i].ObjectType}"].ToString());
                        break;
                    case ObjectType.TrainStation:
                        trafikverketResp._TrainStationResponse = JsonConvert.DeserializeObject<TrainStationResponse[]>(array[i][$"{Request.Queries[i].ObjectType}"].ToString());
                        break;
                    case ObjectType.Camera:
                        trafikverketResp._CameraResponse = JsonConvert.DeserializeObject<CameraResponse[]>(array[i][$"{Request.Queries[i].ObjectType}"].ToString());
                        break;
                    case ObjectType.FerryAnnouncement:
                        trafikverketResp._FerryAnnouncementResponse = JsonConvert.DeserializeObject<FerryAnnouncementResponse[]>(array[i][$"{Request.Queries[i].ObjectType}"].ToString());
                        break;
                    case ObjectType.FerryRoute:
                        trafikverketResp._FerryRouteResponse = JsonConvert.DeserializeObject<FerryRouteResponse[]>(array[i][$"{Request.Queries[i].ObjectType}"].ToString());
                        break;
                    case ObjectType.Icon:
                        trafikverketResp._IconResponse = JsonConvert.DeserializeObject<IconResponse[]>(array[i][$"{Request.Queries[i].ObjectType}"].ToString());
                        break;
                    case ObjectType.Parking:
                        trafikverketResp._ParkingResponse = JsonConvert.DeserializeObject<ParkingResponse[]>(array[i][$"{Request.Queries[i].ObjectType}"].ToString());
                        break;
                    case ObjectType.RoadCondition:
                        trafikverketResp._RoadConditionResponse = JsonConvert.DeserializeObject<RoadConditionResponse[]>(array[i][$"{Request.Queries[i].ObjectType}"].ToString());
                        break;
                    case ObjectType.RoadConditionOverview:
                        trafikverketResp._RoadConditionOverviewResponse = JsonConvert.DeserializeObject<RoadConditionOverviewResponse[]>(array[i][$"{Request.Queries[i].ObjectType}"].ToString());
                        break;
                    case ObjectType.Situation:
                        trafikverketResp._SituationResponse = JsonConvert.DeserializeObject<SituationResponse[]>(array[i][$"{Request.Queries[i].ObjectType}"].ToString());
                        break;
                    case ObjectType.TrafficFlow:
                        trafikverketResp._TrafficFlowResponse = JsonConvert.DeserializeObject<TrafficFlowResponse[]>(array[i][$"{Request.Queries[i].ObjectType}"].ToString());
                        break;
                    case ObjectType.TrafficSafetyCamera:
                        trafikverketResp._TrafficSafetyCameraResponse = JsonConvert.DeserializeObject<TrafficSafetyCameraResponse[]>(array[i][$"{Request.Queries[i].ObjectType}"].ToString());
                        break;
                    case ObjectType.TravelTimeRoute:
                        trafikverketResp._TravelTimeRouteResponse = JsonConvert.DeserializeObject<TravelTimeRouteResponse[]>(array[i][$"{Request.Queries[i].ObjectType}"].ToString());
                        break;
                    case ObjectType.WeatherStation:
                        trafikverketResp._WeatherStationResponse = JsonConvert.DeserializeObject<WeatherStationResponse[]>(array[i][$"{Request.Queries[i].ObjectType}"].ToString());
                        break;
                    case ObjectType.MeasurementData100:
                        trafikverketResp._MeasurementData100Response = JsonConvert.DeserializeObject<MeasurementData100Response[]>(array[i][$"{Request.Queries[i].ObjectType}"].ToString());
                        break;
                    case ObjectType.MeasurementData20:
                        trafikverketResp._MeasurementData20Response = JsonConvert.DeserializeObject<MeasurementData20Response[]>(array[i][$"{Request.Queries[i].ObjectType}"].ToString());
                        break;
                    case ObjectType.PavementData:
                        trafikverketResp._PavementDataResponse = JsonConvert.DeserializeObject<PavementDataResponse[]>(array[i][$"{Request.Queries[i].ObjectType}"].ToString());
                        break;
                    case ObjectType.RoadData:
                        trafikverketResp._RoadDataResponse = JsonConvert.DeserializeObject<RoadDataResponse[]>(array[i][$"{Request.Queries[i].ObjectType}"].ToString());
                        break;
                    case ObjectType.RoadGeometry:
                        trafikverketResp._RoadGeometryResponse = JsonConvert.DeserializeObject<RoadGeometryResponse[]>(array[i][$"{Request.Queries[i].ObjectType}"].ToString());
                        break;
                }
            }

            return trafikverketResp;
        }

        public void Dispose() { }
    }
}
