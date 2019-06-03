using System;

namespace TrafikverketdotNET
{
    public enum ObjectType 
    {
        /// <summary>
        /// Tidtabellsinformation, d.v.s information om tåg på trafikplatser (stationer, hållplatser) varje post motsvarar ett visst tåg vid respektive trafikplats.
        /// </summary>
        TrainAnnouncement,
        /// <summary>
        /// Tågtrafikmeddelande, exempelvis information kring banarbete, tågfel, anläggningsfel och dylikt.
        /// </summary>
        TrainMessage,
        /// <summary>
        /// Trafikplatser, både med och utan resandeutbyte.
        /// </summary>
        TrainStation,
        /// <summary>
        /// Kameror för automatisk väglag och trafikflöde.
        /// </summary>
        Camera,
        /// <summary>
        /// Ankomster och avgångar.
        /// </summary>
        FerryAnnouncement,
        /// <summary>
        /// Information om färjeleder.
        /// </summary>
        FerryRoute,
        /// <summary>
        /// Ikoner, exempelvis för använding i grafiska användargränssnitt och kartor.
        /// </summary>
        Icon,
        /// <summary>
        /// Information om rastplatser och parkeringar.
        /// </summary>
        Parking,
        /// <summary>
        /// Information om väglag.
        /// </summary>
        RoadCondition,
        /// <summary>
        /// Väglagsöversikter.
        /// </summary>
        RoadConditionOverview,
        /// <summary>
        /// Situationer innehållandes händelser och störningar som trafikmeddelanden, vägarbeten, olyckor, restiktioner m.m.
        /// </summary>
        Situation,
        /// <summary>
        /// Uppmätta eller härledda värden relaterat till trafik eller enskilda fordonets rörelser på en viss sektion eller vid en specifik punkt på vägnätet.
        /// </summary>
        TrafficFlow,
        /// <summary>
        /// Trafiksäkerhetskameror.
        /// </summary>
        TrafficSafetyCamera,
        /// <summary>
        /// Restider i större städer eller i högbelastade trafiksystem. Beräkning av restid baseras på data från detektorer som är utplacerade längs bestämda rutter.
        /// </summary>
        TravelTimeRoute,
        /// <summary>
        /// Väderstationer med mätdata.
        /// </summary>
        WeatherStation,
        /// <summary>
        /// Mätdata per 100 meter. 
        /// Ett medelvärde har räknats fram för 100 meter baserat på de ingående 20-metersvärdena (se mer info i MeasurementData20). 
        /// Observera att det inte finns 100-metersdata för alla våra 20-metersvariabler. 
        /// Källsystem är PMS-systemen.
        /// </summary>
        MeasurementData100,
        /// <summary>
        /// Mätdata per 20 meter. 
        /// Data från vägytemätningar med laserscanning alternativt som beräknats fram baserat på dem. 
        /// Mätningarna utförs årligen eller vartannat år beroende på trafikmängd. 
        /// Senast gällande mätdata finns att hämta dvs ej historik. 
        /// Källsystem är PMS-systemen.
        /// </summary>
        MeasurementData20,
        /// <summary>
        /// Beläggningsdata från PMS-systemen kombinerat med relevant vägdata från NVDB. 
        /// Vi kan ej garantera att det är helt aktuellt data från NVDB. 
        /// Datum för när data hämtades framgår av posten TimeStamp. 
        /// För att se källa för respektive data, gå till fliken Om variabler i systemet PMSV3.
        /// </summary>
        PavementData,
        /// <summary>
        /// Vägdata från NVDB som är relevant tillsammans med PMS-systemens beläggnings och mätdata. 
        /// Vi kan ej garantera att det är dagsaktuell data från NVDB. 
        /// Datum för när data hämtades framgår av posten TimeStamp. 
        /// För att se källa för respektive data, gå till fliken Om variabler i systemet PMSV3.
        /// </summary>
        RoadData,
        /// <summary>
        /// Vägens geometri relaterat till det data vi tillhandahåller från PMS-systemen med data om beläggningar och mätdata. 
        /// Vi kan ej garantera att geometrin är dagsaktuell från NVDB. 
        /// Datum för när data hämtades framgår av posten TimeStamp.
        /// </summary>
        RoadGeometry,
    }

    public enum FilterOperatorType
    {
        EQ,
        EXISTS,
        GT,
        GTE,
        LT,
        LTE,
        NE,
        LIKE,
        NOTLIKE,
        IN,
        NOTIN,
        WITHIN,
        INTERSECTS,
        NEAR
    }

    public enum FilterOperatorGroup
    {
        OR,
        AND,
        ELEMENTMATCH,
        NOT
    }

    public enum Shape
    {
        None,
        Box,
        Polygon,
        Center
    }
}
