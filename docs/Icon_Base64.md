https://api.trafikinfo.trafikverket.se/API/Model

Förhandsgranskning av ikon där bilden representeras som en Base64-enkodad sträng.
En webbläsare kan direkt visa en Base64-enkodad bild utan att behöva göra ett anrop till servern. Detta görs i HTML genom att img-elementets src-attribut inleds med data:image/png;base64, följt av själva datat. Exempel:
```xaml
<img src="data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAAUAAAAFCAYAAACNbyblAAAAHElEQVQI12P4//8/w38GIAXDIBKE0DHxgljNBAAO9TXL0Y4OHwAAAABJRU5ErkJggg==" alt="Red dot" />
```
Läs mer om Base64 - http://sv.wikipedia.org/wiki/Base64
