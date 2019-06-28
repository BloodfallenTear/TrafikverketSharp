using Newtonsoft.Json;

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

        internal TrafikverketResponse() { }
    }
}
