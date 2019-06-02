# Trafikverket.NET v0.23.3
A C# .NET Standard library for Trafikverket. This is **not** an official Trafikverket library.

## Documentation
All of the XML documentation found in this API library comes from [Trafikverket](https://api.trafikinfo.trafikverket.se/API/Model).

## Changelog 
For every release, you can find the changelog to see what has changed from the previous release to that one under the said release. If a release contains nothing but the 'Included APIs' tab, that means nothing that should concern the user has been changed and a few APIs have been added. If you still are curious for all the things which have been changed from version x to version y, you can check out the commit history since I try to document everything I do there.

## Support
This project currently only officially supports .NET Standard 2.0.

## NuGet
For simplicity, you can now download the library via [NuGet](https://www.nuget.org/packages/Trafikverket.NET/)!
>`Install-Package Trafikverket.NET`

## Dependencies
This project uses one third-party dependency, which is [Newtonsoft.Json (12.0.2)](https://www.newtonsoft.com/) by user [JamesNK](https://github.com/JamesNK). NuGet Link: [Newtonsoft.Json (12.0.2)](https://www.nuget.org/packages/Newtonsoft.Json/12.0.2/). [Insight](https://github.com/BloodfallenTear/Trafikverket.NET/network/dependencies).

## Current Focus
Currently working on creating custom requests making as well as making it easy for users to use.

## API Implementation List (For more detailed progress head to [Projects](https://github.com/BloodfallenTear/Trafikverket.NET/projects/1)):
- [x] TrainAnnouncement - Tidtabellsinformation, d.v.s information om tåg på trafikplatser (stationer, hållplatser) varje post motsvarar ett visst tåg vid respektive trafikplats.
- [x] TrainMessage - Tågtrafikmeddelande, exempelvis information kring banarbete, tågfel, anläggningsfel och dylikt.
- [x] TrainStation - Trafikplatser, både med och utan resandeutbyte.
- [x] Camera - Kameror för automatisk väglag och trafikflöde.
- [x] FerryAnnouncement - Ankomster och avgångar.
- [x] FerryRoute - Information om färjeleder.
- [x] Icon - Ikoner, exempelvis för använding i grafiska användargränssnitt och kartor.
- [x] Parking - Information om rastplatser och parkeringar.
- [x] RoadCondition - Information om väglag.
- [x] RoadConditionOverview - Väglagsöversikter.
- [x] Situation - Situationer innehållandes händelser och störningar som trafikmeddelanden, vägarbeten, olyckor, restiktioner m.m.
- [x] TrafficFlow - Uppmätta eller härledda värden relaterat till trafik eller enskilda fordonets rörelser på en viss sektion eller vid en specifik punkt på vägnätet.
- [x] TrafficSafetyCamera - Trafiksäkerhetskameror.
- [x] TravelTimeRoute - Restider i större städer eller i högbelastade trafiksystem. Beräkning av restid baseras på data från detektorer som är utplacerade längs bestämda rutter.
- [x] WeatherStation - Väderstationer med mätdata.
- [x] MeasurementData100 - Mätdata per 100 meter. Ett medelvärde har räknats fram för 100 meter baserat på de ingående 20-metersvärdena (se mer info i MeasurementData20). Observera att det inte finns 100-metersdata för alla våra 20-metersvariabler. Källsystem är PMS-systemen.
- [x] MeasurementData20 - Mätdata per 20 meter. Data från vägytemätningar med laserscanning alternativt som beräknats fram baserat på dem. Mätningarna utförs årligen eller vartannat år beroende på trafikmängd. Senast gällande mätdata finns att hämta dvs ej historik. Källsystem är PMS-systemen.
- [x] PavementData - Beläggningsdata från PMS-systemen kombinerat med relevant vägdata från NVDB. Vi kan ej garantera att det är helt aktuellt data från NVDB. Datum för när data hämtades framgår av posten TimeStamp. För att se källa för respektive data, gå till fliken Om variabler i systemet PMSV3.
- [x] RoadData - Vägdata från NVDB som är relevant tillsammans med PMS-systemens beläggnings och mätdata. Vi kan ej garantera att det är dagsaktuell data från NVDB. Datum för när data hämtades framgår av posten TimeStamp. För att se källa för respektive data, gå till fliken Om variabler i systemet PMSV3.
- [x] RoadGeometry - Vägens geometri relaterat till det data vi tillhandahåller från PMS-systemen med data om beläggningar och mätdata. Vi kan ej garantera att geometrin är dagsaktuell från NVDB. Datum för när data hämtades framgår av posten TimeStamp. 

## Code of Conduct
This repository's Code of Conduct can be found here: [CODE_OF_CONDUCT.md](https://github.com/BloodfallenTear/Trafikverket.NET/blob/master/CODE_OF_CONDUCT.md)

## License
This project is licensed under the MIT License - see the [LICENSE.md](https://github.com/BloodfallenTear/Trafikverket.NET/blob/master/LICENSE.md) file for details. © BloodfallenTear 2019
