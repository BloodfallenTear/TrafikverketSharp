namespace TrafikverketdotNET
{
    public class TrafikverketResponse
    {
        #region Internal
        internal TrainAnnouncementResponse[] _TrainAnnouncementResponse { get; set; }
        internal TrainMessageResponse[] _TrainMessageResponse { get; set; }
        internal TrainStationResponse[] _TrainStationResponse { get; set; }

        internal CameraResponse[] _CameraResponse { get; set; }
        internal FerryAnnouncementResponse[] _FerryAnnouncementResponse { get; set; }
        internal FerryRouteResponse[] _FerryRouteResponse { get; set; }
        internal IconResponse[] _IconResponse { get; set; }
        internal ParkingResponse[] _ParkingResponse { get; set; }
        internal RoadConditionResponse[] _RoadConditionResponse { get; set; }
        internal RoadConditionOverviewResponse[] _RoadConditionOverviewResponse { get; set; }
        internal SituationResponse[] _SituationResponse { get; set; }
        internal TrafficFlowResponse[] _TrafficFlowResponse { get; set; }
        internal TrafficSafetyCameraResponse[] _TrafficSafetyCameraResponse { get; set; }
        internal TravelTimeRouteResponse[] _TravelTimeRouteResponse { get; set; }
        internal WeatherStationResponse[] _WeatherStationResponse { get; set; }

        internal MeasurementData100Response[] _MeasurementData100Response { get; set; }
        internal MeasurementData20Response[] _MeasurementData20Response { get; set; }
        internal PavementDataResponse[] _PavementDataResponse { get; set; }
        internal RoadDataResponse[] _RoadDataResponse { get; set; }
        internal RoadGeometryResponse[] _RoadGeometryResponse { get; set; }

        internal System.Collections.Generic.Dictionary<ObjectType, Subs.Info> _Info { get; set; }
        #endregion

        #region Public
        public TrainAnnouncementResponse[] TrainAnnouncementResponse => _TrainAnnouncementResponse;
        public TrainMessageResponse[] TrainMessageResponse => _TrainMessageResponse;
        public TrainStationResponse[] TrainStationResponse => _TrainStationResponse;

        public CameraResponse[] CameraResponse => _CameraResponse;
        public FerryAnnouncementResponse[] FerryAnnouncementResponse => _FerryAnnouncementResponse;
        public FerryRouteResponse[] FerryRouteResponse => _FerryRouteResponse;
        public IconResponse[] IconResponse => _IconResponse;
        public ParkingResponse[] ParkingResponse => _ParkingResponse;
        public RoadConditionResponse[] RoadConditionResponse => _RoadConditionResponse;
        public RoadConditionOverviewResponse[] RoadConditionOverviewResponse => _RoadConditionOverviewResponse;
        public SituationResponse[] SituationResponse => _SituationResponse;
        public TrafficFlowResponse[] TrafficFlowResponse => _TrafficFlowResponse;
        public TrafficSafetyCameraResponse[] TrafficSafetyCameraResponse => _TrafficSafetyCameraResponse;
        public TravelTimeRouteResponse[] TravelTimeRouteResponse => _TravelTimeRouteResponse;
        public WeatherStationResponse[] WeatherStationResponse => _WeatherStationResponse;

        public MeasurementData100Response[] MeasurementData100Response => _MeasurementData100Response;
        public MeasurementData20Response[] MeasurementData20Response => _MeasurementData20Response;
        public PavementDataResponse[] PavementDataResponse => _PavementDataResponse;
        public RoadDataResponse[] RoadDataResponse => _RoadDataResponse;
        public RoadGeometryResponse[] RoadGeometryResponse => _RoadGeometryResponse;

        public System.Collections.Generic.Dictionary<ObjectType, Subs.Info> Info => _Info;
        #endregion

        internal TrafikverketResponse() { }
    }
}
