# Trafikverket.NET
A C# .NET Standard library for Trafikverket.

## Documentation
All of the XML documentation found in this API library comes from [Trafikverket](https://api.trafikinfo.trafikverket.se/API/Model).

## Support
This project currently only officially supports .NET Standard 2.0.

## Dependencies
This project uses one third-party dependency, which is Newtonsoft.Json [Newtonsoft.Json (12.0.2)](https://www.newtonsoft.com/) by user [JamesNK](https://github.com/JamesNK). NuGet Link: [Newtonsoft.Json (12.0.2)](https://www.nuget.org/packages/Newtonsoft.Json/12.0.2/). [Insight](https://github.com/BloodfallenTear/Trafikverket.NET/network/dependencies).

## To-Do List (For more detailed progress head to [Projects](https://github.com/BloodfallenTear/Trafikverket.NET/projects/1)):
- [x] TrainMessage - Tågtrafikmeddelande, exempelvis information kring banarbete, tågfel, anläggningsfel och dylikt.
- [x] TrainStation - Trafikplatser, både med och utan resandeutbyte.
- [ ] TrainAnnouncement - Tidtabellsinformation, d.v.s information om tåg på trafikplatser (stationer, hållplatser) varje post motsvarar ett visst tåg vid respektive trafikplats.
- [ ] Camera - Kameror för automatisk väglag och trafikflöde.
- [ ] FerryAnnouncement - Ankomster och avgångar.
- [ ] FerryRoute - Information om färjeleder.
- [ ] Icon - Ikoner, exempelvis för använding i grafiska användargränssnitt och kartor.
- [ ] Parking 
- [ ] RoadCondition - Väglag.
- [ ] RoadConditionOverview - Väglagsöversikter.
- [ ] Situation - Situationer innehållandes händelser och störningar som trafikmeddelanden, vägarbeten, olyckor, restiktioner m.m.
- [ ] WeatherStation - Väderstationer med mätdata.
- [ ] TrafficSafetyCamera

## Code of Conduct
This repository's Code of Conduct can be found here: [CODE_OF_CONDUCT.md](CODE_OF_CONDUCT.md)

## License
This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details. © BloodfallenTear 2019
