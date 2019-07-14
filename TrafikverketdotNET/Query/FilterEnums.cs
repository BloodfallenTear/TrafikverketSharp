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
        /// <summary>
        /// "Equals", lika med
        /// </summary>
        EQ,
        /// <summary>
        /// "Exists", värde existerar (value="true|false").
        /// </summary>
        EXISTS,
        /// <summary>
        /// "Greater Than", större än.
        /// </summary>
        GT,
        /// <summary>
        /// "Greater Than or Equal", större än eller lika med.
        /// </summary>
        GTE,
        /// <summary>
        /// "Less Than", mindre än.
        /// </summary>
        LT,
        /// <summary>
        /// "Less Than or Equals", mindre än eller lika med.
        /// </summary>
        LTE,
        /// <summary>
        /// Not Equal, inte lika med.
        /// </summary>
        NE,
        /// <summary>
        /// ”Like”, testar om värdet matchar ett reguljärt uttryck. 
        /// </summary>
        LIKE,
        /// <summary>
        /// "Not Like", testar om värdet inte matchar ett reguljärt uttryck.
        /// </summary>
        NOTLIKE,
        /// <summary>
        /// "In", testar om värdet finns med i en lista av värden.
        /// </summary>
        IN,
        /// <summary>
        /// "Not In", testar om värdet inte finns med i en lista av värden.
        /// </summary>
        NOTIN,
        /// <summary>
        /// "Within", testar om värdet finns inom en geometri, läs mer under avsnitt Geo-sökningar.
        /// </summary>
        WITHIN,
        /// <summary>
        /// "Intersects", testar om en geometri skär en annan, läs mer under avsnitt Geo-sökningar.
        /// </summary>
        INTERSECTS,
        /// <summary>
        /// "Near" testar om värdet finns i närheten av en punkt, läs mer under avsnitt Geo-sökningar.
        /// </summary>
        NEAR
    }

    public enum FilterOperatorGroup
    {
        /// <summary>
        /// "Or" (testar att minst en av operatorerna är sann).
        /// </summary>
        OR,
        /// <summary>
        /// "And" (testar att alla operatorer är sanna)
        /// </summary>
        AND,
        /// <summary>
        /// "Element match" (testar att samtliga operatorer är sanna för ett och samma element i en array).
        /// </summary>
        ELEMENTMATCH,
        /// <summary>
        /// "Not" (Anger att dess ingående operatorer är falska, anges flera operatorer utan att omslutas av en And/Or/ElementMatch operator så används And).
        /// </summary>
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
