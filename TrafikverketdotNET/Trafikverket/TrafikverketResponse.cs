using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TrafikverketdotNET
{
    public class TrafikverketResponse
    {
        #region Internal
        [JsonProperty("TrainAnnouncement")] internal TrainAnnouncementResponse[] _TrainAnnouncementResponse { get; set; }
        [JsonProperty("TrainMessage")] internal TrainMessageResponse[] _TrainMessageResponse { get; set; }
        [JsonProperty("TrainStation")] internal TrainStationResponse[] _TrainStationResponse { get; set; }

        [JsonProperty("Camera")] internal CameraResponse[] _CameraResponse { get; set; }
        [JsonProperty("FerryAnnouncement")] internal FerryAnnouncementResponse[] _FerryAnnouncementResponse { get; set; }
        [JsonProperty("FerryRoute")] internal FerryRouteResponse[] _FerryRouteResponse { get; set; }
        [JsonProperty("Icon")] internal IconResponse[] _IconResponse { get; set; }
        [JsonProperty("Parking")] internal ParkingResponse[] _ParkingResponse { get; set; }
        [JsonProperty("RoadCondition")] internal RoadConditionResponse[] _RoadConditionResponse { get; set; }
        [JsonProperty("RoadConditionOverview")] internal RoadConditionOverviewResponse[] _RoadConditionOverviewResponse { get; set; }
        [JsonProperty("Situation")] internal SituationResponse[] _SituationResponse { get; set; }
        [JsonProperty("TrafficFlow")] internal TrafficFlowResponse[] _TrafficFlowResponse { get; set; }
        [JsonProperty("TrafficSafetyCamera")] internal TrafficSafetyCameraResponse[] _TrafficSafetyCameraResponse { get; set; }
        [JsonProperty("TravelTimeRoute")] internal TravelTimeRouteResponse[] _TravelTimeRouteResponse { get; set; }
        [JsonProperty("WeatherStation")] internal WeatherStationResponse[] _WeatherStationResponse { get; set; }

        [JsonProperty("MeasurementData100")] internal MeasurementData100Response[] _MeasurementData100Response { get; set; }
        [JsonProperty("MeasurementData20")] internal MeasurementData20Response[] _MeasurementData20Response { get; set; }
        [JsonProperty("PavementData")] internal PavementDataResponse[] _PavementDataResponse { get; set; }
        [JsonProperty("RoadData")] internal RoadDataResponse[] _RoadDataResponse { get; set; }
        [JsonProperty("RoadGeometryResponses")] internal RoadGeometryResponse[] _RoadGeometryResponse { get; set; }
        #endregion

        #region Public
        [JsonIgnore] public TrainAnnouncementResponse[] TrainAnnouncementResponse => _TrainAnnouncementResponse;
        [JsonIgnore] public TrainMessageResponse[] TrainMessageResponse => _TrainMessageResponse;
        [JsonIgnore] public TrainStationResponse[] TrainStationResponse => _TrainStationResponse;

        [JsonIgnore] public CameraResponse[] CameraResponse => _CameraResponse;
        [JsonIgnore] public FerryAnnouncementResponse[] FerryAnnouncementResponse => _FerryAnnouncementResponse;
        [JsonIgnore] public FerryRouteResponse[] FerryRouteResponse => _FerryRouteResponse;
        [JsonIgnore] public IconResponse[] IconResponse => _IconResponse;
        [JsonIgnore] public ParkingResponse[] ParkingResponse => _ParkingResponse;
        [JsonIgnore] public RoadConditionResponse[] RoadConditionResponse => _RoadConditionResponse;
        [JsonIgnore] public RoadConditionOverviewResponse[] RoadConditionOverviewResponse => _RoadConditionOverviewResponse;
        [JsonIgnore] public SituationResponse[] SituationResponse => _SituationResponse;
        [JsonIgnore] public TrafficFlowResponse[] TrafficFlowResponse => _TrafficFlowResponse;
        [JsonIgnore] public TrafficSafetyCameraResponse[] TrafficSafetyCameraResponse => _TrafficSafetyCameraResponse;
        [JsonIgnore] public TravelTimeRouteResponse[] TravelTimeRouteResponse => _TravelTimeRouteResponse;
        [JsonIgnore] public WeatherStationResponse[] WeatherStationResponse => _WeatherStationResponse;

        [JsonIgnore] public MeasurementData100Response[] MeasurementData100Response => _MeasurementData100Response;
        [JsonIgnore] public MeasurementData20Response[] MeasurementData20Response => _MeasurementData20Response;
        [JsonIgnore] public PavementDataResponse[] PavementDataResponse => _PavementDataResponse;
        [JsonIgnore] public RoadDataResponse[] RoadDataResponse => _RoadDataResponse;
        [JsonIgnore] public RoadGeometryResponse[] RoadGeometryResponse => _RoadGeometryResponse;
        #endregion

        public void AddResponse(ObjectType RequestObjectType, JToken token)
        {
            if(RequestObjectType == ObjectType.TrainAnnouncement)
            {
                if (!(this._TrainAnnouncementResponse?.Length > 0))
                    this._TrainAnnouncementResponse = new TrainAnnouncementResponse[] { JsonConvert.DeserializeObject<TrainAnnouncementResponse>(token.ToString()) };
                else
                {
                    var array = new TrainAnnouncementResponse[this._TrainAnnouncementResponse.Length + 1];
                    for (System.Int32 i = 0; i < this._TrainAnnouncementResponse.Length; i++)
                        array[i] = this._TrainAnnouncementResponse[i];
                    array[this._TrainAnnouncementResponse.Length] = JsonConvert.DeserializeObject<TrainAnnouncementResponse>(token.ToString());
                    this._TrainAnnouncementResponse = array;
                }
                return;
            }
            if(RequestObjectType == ObjectType.TrainMessage)
            {
                if (!(this._TrainMessageResponse?.Length > 0))
                    this._TrainMessageResponse = new TrainMessageResponse[] { JsonConvert.DeserializeObject<TrainMessageResponse>(token.ToString()) };
                else
                {
                    var array = new TrainMessageResponse[this._TrainMessageResponse.Length + 1];
                    for (System.Int32 i = 0; i < this._TrainMessageResponse.Length; i++)
                        array[i] = this._TrainMessageResponse[i];
                    array[this._TrainMessageResponse.Length] = JsonConvert.DeserializeObject<TrainMessageResponse>(token.ToString());
                    this._TrainMessageResponse = array;
                }
                return;
            }
            if(RequestObjectType == ObjectType.TrainStation)
            {
                if (!(this._TrainStationResponse?.Length > 0))
                    this._TrainStationResponse = new TrainStationResponse[] { JsonConvert.DeserializeObject<TrainStationResponse>(token.ToString()) };
                else
                {
                    var array = new TrainStationResponse[this._TrainStationResponse.Length + 1];
                    for(System.Int32 i = 0; i < this._TrainStationResponse.Length; i++)
                        array[i] = this._TrainStationResponse[i];
                    array[this._TrainStationResponse.Length] = JsonConvert.DeserializeObject<TrainStationResponse>(token.ToString());
                    this._TrainStationResponse = array;
                }
                return;
            }
            if (RequestObjectType == ObjectType.Camera)
            {
                if (!(this._CameraResponse?.Length > 0))
                    this._CameraResponse = new CameraResponse[] { JsonConvert.DeserializeObject<CameraResponse>(token.ToString()) };
                else
                {
                    var array = new CameraResponse[this._CameraResponse.Length + 1];
                    for(System.Int32 i = 0; i < this._CameraResponse.Length; i++)
                        array[i] = this._CameraResponse[i];
                    array[this._CameraResponse.Length] = JsonConvert.DeserializeObject<CameraResponse>(token.ToString());
                    this._CameraResponse = array;
                }
                return;
            }
            if (RequestObjectType == ObjectType.FerryAnnouncement)
            {
                if (!(this._FerryAnnouncementResponse?.Length > 0))
                    this._FerryAnnouncementResponse = new FerryAnnouncementResponse[] { JsonConvert.DeserializeObject<FerryAnnouncementResponse>(token.ToString()) };
                else
                {
                    var array = new FerryAnnouncementResponse[this._FerryAnnouncementResponse.Length + 1];
                    for(System.Int32 i = 0; i < this._FerryAnnouncementResponse.Length; i++)
                        array[i] = this._FerryAnnouncementResponse[i];
                    array[this._FerryAnnouncementResponse.Length] = JsonConvert.DeserializeObject<FerryAnnouncementResponse>(token.ToString());
                    this._FerryAnnouncementResponse = array;
                }
                return;
            }
            if (RequestObjectType == ObjectType.FerryRoute)
            {
                if (!(this._FerryRouteResponse?.Length > 0))
                    this._FerryRouteResponse = new FerryRouteResponse[] { JsonConvert.DeserializeObject<FerryRouteResponse>(token.ToString()) };
                else
                {
                    var array = new FerryRouteResponse[this._FerryRouteResponse.Length + 1];
                    for(System.Int32 i = 0; i < this._FerryRouteResponse.Length; i++)
                        array[i] = this._FerryRouteResponse[i];
                    array[this._FerryRouteResponse.Length] = JsonConvert.DeserializeObject<FerryRouteResponse>(token.ToString());
                    this._FerryRouteResponse = array;
                }
                return;
            }
            if (RequestObjectType == ObjectType.Icon)
            {
                if (!(this._IconResponse?.Length > 0))
                    this._IconResponse = new IconResponse[] { JsonConvert.DeserializeObject<IconResponse>(token.ToString()) };
                else
                {
                    var array = new IconResponse[this._IconResponse.Length + 1];
                    for(System.Int32 i = 0; i < this._IconResponse.Length; i++)
                        array[i] = this._IconResponse[i];
                    array[this._IconResponse.Length] = JsonConvert.DeserializeObject<IconResponse>(token.ToString());
                    this._IconResponse = array;
                }
                return;
            }
            if (RequestObjectType == ObjectType.Parking)
            {
                if (!(this._ParkingResponse?.Length > 0))
                    this._ParkingResponse = new ParkingResponse[] { JsonConvert.DeserializeObject<ParkingResponse>(token.ToString()) };
                else
                {
                    var array = new ParkingResponse[this._ParkingResponse.Length + 1];
                    for (System.Int32 i = 0; i < this._ParkingResponse.Length; i++)
                        array[i] = this._ParkingResponse[i];
                    array[this._ParkingResponse.Length] = JsonConvert.DeserializeObject<ParkingResponse>(token.ToString());
                    this._ParkingResponse = array;
                }
                return;
            }
            if (RequestObjectType == ObjectType.RoadCondition)
            {
                if (!(this._RoadConditionResponse?.Length > 0))
                    this._RoadConditionResponse = new RoadConditionResponse[] { JsonConvert.DeserializeObject<RoadConditionResponse>(token.ToString()) };
                else
                {
                    var array = new RoadConditionResponse[this._RoadConditionResponse.Length + 1];
                    for (System.Int32 i = 0; i < this._RoadConditionResponse.Length; i++)
                        array[i] = this._RoadConditionResponse[i];
                    array[this._RoadConditionResponse.Length] = JsonConvert.DeserializeObject<RoadConditionResponse>(token.ToString());
                    this._RoadConditionResponse = array;
                }
                return;
            }
            if (RequestObjectType == ObjectType.RoadConditionOverview)
            {
                if (!(this._RoadConditionOverviewResponse?.Length > 0))
                    this._RoadConditionOverviewResponse = new RoadConditionOverviewResponse[] { JsonConvert.DeserializeObject<RoadConditionOverviewResponse>(token.ToString()) };
                else
                {
                    var array = new RoadConditionOverviewResponse[this._RoadConditionOverviewResponse.Length + 1];
                    for (System.Int32 i = 0; i < this._RoadConditionOverviewResponse.Length; i++)
                        array[i] = this._RoadConditionOverviewResponse[i];
                    array[this._RoadConditionOverviewResponse.Length] = JsonConvert.DeserializeObject<RoadConditionOverviewResponse>(token.ToString());
                    this._RoadConditionOverviewResponse = array;
                }
                return;
            }
            if (RequestObjectType == ObjectType.Situation)
            {
                if (!(this._SituationResponse?.Length > 0))
                    this._SituationResponse = new SituationResponse[] { JsonConvert.DeserializeObject<SituationResponse>(token.ToString()) };
                else
                {
                    var array = new SituationResponse[this._SituationResponse.Length + 1];
                    for (System.Int32 i = 0; i < this._SituationResponse.Length; i++)
                        array[i] = this._SituationResponse[i];
                    array[this._SituationResponse.Length] = JsonConvert.DeserializeObject<SituationResponse>(token.ToString());
                    this._SituationResponse = array;
                }
                return;
            }
            if (RequestObjectType == ObjectType.TrafficFlow)
            {
                if (!(this._TrafficFlowResponse?.Length > 0))
                    this._TrafficFlowResponse = new TrafficFlowResponse[] { JsonConvert.DeserializeObject<TrafficFlowResponse>(token.ToString()) };
                else
                {
                    var array = new TrafficFlowResponse[this._TrafficFlowResponse.Length + 1];
                    for (System.Int32 i = 0; i < this._TrafficFlowResponse.Length; i++)
                        array[i] = this._TrafficFlowResponse[i];
                    array[this._TrafficFlowResponse.Length] = JsonConvert.DeserializeObject<TrafficFlowResponse>(token.ToString());
                    this._TrafficFlowResponse = array;
                }
                return;
            }
            if (RequestObjectType == ObjectType.TrafficSafetyCamera)
            {
                if (!(this._TrafficSafetyCameraResponse?.Length > 0))
                    this._TrafficSafetyCameraResponse = new TrafficSafetyCameraResponse[] { JsonConvert.DeserializeObject<TrafficSafetyCameraResponse>(token.ToString()) };
                else
                {
                    var array = new TrafficSafetyCameraResponse[this._TrafficSafetyCameraResponse.Length + 1];
                    for (System.Int32 i = 0; i < this._TrafficSafetyCameraResponse.Length; i++)
                        array[i] = this._TrafficSafetyCameraResponse[i];
                    array[this._TrafficSafetyCameraResponse.Length] = JsonConvert.DeserializeObject<TrafficSafetyCameraResponse>(token.ToString());
                    this._TrafficSafetyCameraResponse = array;
                }
                return;
            }
            if (RequestObjectType == ObjectType.TravelTimeRoute)
            {
                if (!(this._TravelTimeRouteResponse?.Length > 0))
                    this._TravelTimeRouteResponse = new TravelTimeRouteResponse[] { JsonConvert.DeserializeObject<TravelTimeRouteResponse>(token.ToString()) };
                else
                {
                    var array = new TravelTimeRouteResponse[this._TravelTimeRouteResponse.Length + 1];
                    for (System.Int32 i = 0; i < this._TravelTimeRouteResponse.Length; i++)
                        array[i] = this._TravelTimeRouteResponse[i];
                    array[this._TravelTimeRouteResponse.Length] = JsonConvert.DeserializeObject<TravelTimeRouteResponse>(token.ToString());
                    this._TravelTimeRouteResponse = array;
                }
                return;
            }
            if (RequestObjectType == ObjectType.WeatherStation)
            {
                if (!(this._WeatherStationResponse?.Length > 0))
                    this._WeatherStationResponse = new WeatherStationResponse[] { JsonConvert.DeserializeObject<WeatherStationResponse>(token.ToString()) };
                else
                {
                    var array = new WeatherStationResponse[this._WeatherStationResponse.Length + 1];
                    for (System.Int32 i = 0; i < this._WeatherStationResponse.Length; i++)
                        array[i] = this._WeatherStationResponse[i];
                    array[this._WeatherStationResponse.Length] = JsonConvert.DeserializeObject<WeatherStationResponse>(token.ToString());
                    this._WeatherStationResponse = array;
                }
                return;
            }
            if (RequestObjectType == ObjectType.MeasurementData100)
            {
                if (!(this._MeasurementData100Response?.Length > 0))
                    this._MeasurementData100Response = new MeasurementData100Response[] { JsonConvert.DeserializeObject<MeasurementData100Response>(token.ToString()) };
                else
                {
                    var array = new MeasurementData100Response[this._MeasurementData100Response.Length + 1];
                    for (System.Int32 i = 0; i < this._MeasurementData100Response.Length; i++)
                        array[i] = this._MeasurementData100Response[i];
                    array[this._MeasurementData100Response.Length] = JsonConvert.DeserializeObject<MeasurementData100Response>(token.ToString());
                    this._MeasurementData100Response = array;
                }
                return;
            }
            if (RequestObjectType == ObjectType.MeasurementData20)
            {
                if (!(this._MeasurementData20Response?.Length > 0))
                    this._MeasurementData20Response = new MeasurementData20Response[] { JsonConvert.DeserializeObject<MeasurementData20Response>(token.ToString()) };
                else
                {
                    var array = new MeasurementData20Response[this._MeasurementData20Response.Length + 1];
                    for (System.Int32 i = 0; i < this._MeasurementData20Response.Length; i++)
                        array[i] = this._MeasurementData20Response[i];
                    array[this._MeasurementData20Response.Length] = JsonConvert.DeserializeObject<MeasurementData20Response>(token.ToString());
                    this._MeasurementData20Response = array;
                }
                return;
            }
            if (RequestObjectType == ObjectType.PavementData)
            {
                if (!(this._PavementDataResponse?.Length > 0))
                    this._PavementDataResponse = new PavementDataResponse[] { JsonConvert.DeserializeObject<PavementDataResponse>(token.ToString()) };
                else
                {
                    var array = new PavementDataResponse[this._PavementDataResponse.Length + 1];
                    for (System.Int32 i = 0; i < this._PavementDataResponse.Length; i++)
                        array[i] = this._PavementDataResponse[i];
                    array[this._PavementDataResponse.Length] = JsonConvert.DeserializeObject<PavementDataResponse>(token.ToString());
                    this._PavementDataResponse = array;
                }
                return;
            }
            if (RequestObjectType == ObjectType.RoadData)
            {
                if (!(this._RoadDataResponse?.Length > 0))
                    this._RoadDataResponse = new RoadDataResponse[] { JsonConvert.DeserializeObject<RoadDataResponse>(token.ToString()) };
                else
                {
                    var array = new RoadDataResponse[this._RoadDataResponse.Length + 1];
                    for (System.Int32 i = 0; i < this._RoadDataResponse.Length; i++)
                        array[i] = this._RoadDataResponse[i];
                    array[this._RoadDataResponse.Length] = JsonConvert.DeserializeObject<RoadDataResponse>(token.ToString());
                    this._RoadDataResponse = array;
                }
                return;
            }
            if (RequestObjectType == ObjectType.RoadGeometry)
            {
                if (!(this._RoadGeometryResponse?.Length > 0))
                    this._RoadGeometryResponse = new RoadGeometryResponse[] { JsonConvert.DeserializeObject<RoadGeometryResponse>(token.ToString()) };
                else
                {
                    var array = new RoadGeometryResponse[this._RoadGeometryResponse.Length + 1];
                    for (System.Int32 i = 0; i < this._RoadGeometryResponse.Length; i++)
                        array[i] = this._RoadGeometryResponse[i];
                    array[this._RoadGeometryResponse.Length] = JsonConvert.DeserializeObject<RoadGeometryResponse>(token.ToString());
                    this._RoadGeometryResponse = array;
                }
                return;
            }
        }

        internal TrafikverketResponse() { }
    }
}
