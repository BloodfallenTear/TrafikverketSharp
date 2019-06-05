using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace TrafikverketdotNET
{
    public sealed class IconResponse : BaseTrafikverketResponse
    {
        [JsonProperty("Base64")] internal String _Base64 { get; set; }
        [JsonProperty("Deleted")] internal Boolean _Deleted { get; set; }
        [JsonProperty("Description")] internal String _Description { get; set; }
        [JsonProperty("Id")] internal String _Id { get; set; }
        [JsonProperty("ModifiedTime")] internal DateTime _ModifiedTime { get; set; }
        [JsonProperty("Url")] internal String _Url { get; set; }

        /// <summary>
        /// Förhandsgranskning av ikon där bilden representeras som en Base64-enkodad sträng. 
        /// En webbläsare kan direkt visa en Base64-enkodad bild utan att behöva göra ett anrop till servern.
        /// https://github.com/BloodfallenTear/Trafikverket.NET/blob/master/docs/Icon.Base64.md
        /// </summary>
        [JsonIgnore] public String Base64 => _Base64;
        /// <summary>
        /// Anger att dataposten raderats.
        /// </summary>
        [JsonIgnore] public Boolean Deleted => _Deleted;
        /// <summary>
        /// Kort beskrivning av ikonen.
        /// </summary>
        [JsonIgnore] public String Description => _Description;
        /// <summary>
        /// Ikonens id, refereras från andra objekttyper i fältet IconId. Fältet är nyckel för objektet.
        /// </summary>
        [JsonIgnore] public String Id => _Id;
        /// <summary>
        /// Tidpunkt då dataposten ändrades.
        /// </summary>
        [JsonIgnore] public DateTime ModifiedTime => _ModifiedTime;
        /// <summary>
        /// Url till ikonbilden. Notera att det finns tre olika ikonbilder vilka specifieras med Url-parametern 'type'. Om ingen typ specificeras returneras png32x32.
        /// https://github.com/BloodfallenTear/Trafikverket.NET/blob/master/docs/Icon.Url.md
        /// </summary>
        [JsonIgnore] public String Url => _Url;

        internal IconResponse() { }
    }

    public class IconRequest : BaseTrafikverketRequest
    {
        public override ObjectType ObjectType => ObjectType.Icon;
        public override string SchemaVersion => Trafikverket.GetSchemaVersion[this.ObjectType];

        public IconRequest(Filter Filter) : base(Filter) { }
        public IconRequest(String ID = null, Boolean IncludeDeletedObjects = false,
                           UInt32 Limit = 0, String OrderBy = null, UInt32 Skip = 0,
                           Boolean LastModified = false, Int32 ChangeID = 0,
                           String Include = null, String Exclude = null, String Distinct = null) : base(ID, IncludeDeletedObjects,
                                                                                                        Limit, OrderBy, Skip, LastModified,
                                                                                                        ChangeID, Include, Exclude, Distinct) { }
        public IconRequest(String ID = null, Boolean IncludeDeletedObjects = false,
                           UInt32 Limit = 0, String OrderBy = null, UInt32 Skip = 0,
                           Boolean LastModified = false, Int32 ChangeID = 0,
                           List<String> Include = null, List<String> Exclude = null, String Distinct = null) : base(ID, IncludeDeletedObjects,
                                                                                                                    Limit, OrderBy, Skip, LastModified,
                                                                                                                    ChangeID, Include, Exclude, Distinct) { }
        public IconRequest(String ID = null, Boolean IncludeDeletedObjects = false,
                           UInt32 Limit = 0, String OrderBy = null, UInt32 Skip = 0,
                           Boolean LastModified = false, Int32 ChangeID = 0,
                           String Include = null, String Exclude = null, String Distinct = null, Filter Filter = null) : base(ID, IncludeDeletedObjects,
                                                                                                                              Limit, OrderBy, Skip, LastModified,
                                                                                                                              ChangeID, Include, Exclude, Distinct, Filter) { }
        public IconRequest(String ID = null, Boolean IncludeDeletedObjects = false,
                           UInt32 Limit = 0, String OrderBy = null, UInt32 Skip = 0,
                           Boolean LastModified = false, Int32 ChangeID = 0,
                           List<String> Include = null, List<String> Exclude = null, String Distinct = null, Filter Filter = null) : base(ID, IncludeDeletedObjects,
                                                                                                                                          Limit, OrderBy, Skip, LastModified,
                                                                                                                                          ChangeID, Include, Exclude, Distinct, Filter) { }

    }

    public sealed class Icon : BaseTrafikverket<IconResponse[]>
    {
        /// <summary>
        /// Ikoner, exempelvis för använding i grafiska användargränssnitt och kartor.
        /// </summary>
        /// <param name="APIKey">Användarens unika nyckel.</param>
        public Icon(String APIKey) : base(APIKey) { }

        internal override ObjectType ObjectType => ObjectType.Icon;
        /// <summary>
        /// SchemaVersion versionen som biblioteken använder.
        /// </summary>
        public override String CurrentSchemaVersion => Trafikverket.GetSchemaVersion[this.ObjectType];

        public override IconResponse[] ExecuteRequest() => ExecuteRequest("Icon", CurrentSchemaVersion);
        /// <param name="XMLRequest">Custom requests must be written in XML, check "https://api.trafikinfo.trafikverket.se/API/TheRequest" in order to create custom requests.</param>
        public override IconResponse[] ExecuteRequest(String XMLRequest) => ExecuteRequest("Icon", CurrentSchemaVersion, XMLRequest);
        public override IconResponse[] ExecuteRequest(BaseTrafikverketRequest Request) => base.ExecuteCustomRequest(Request);
    }
}
