using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

/* 
 * <REQUEST>
      <LOGIN authenticationkey="xxx" />
      <QUERY objecttype="xxx" schemaversion="xxx">
          <FILTER>
              <EQ name="" value="" />
              <EXISTS name="" value="" />
              <GT name="" value="" />
              <GTE name="" value="" />
              <LT name="" value="" />
              <LTE name="" value="" />
              <NE name="" value="" />
              <LIKE name="" value="" />
              <NOTLIKE name="" value="" />
              <IN name="" value="" />
              <NOTIN name="" value="" />
              <WITHIN shape="" name="" value="" />
              <INTERSECTS shape="" name="" value="" />
              <NEAR name="" value="" mindistance="" maxdistance="" />
              
              <OR>
                  
              </OR>
              <AND>
                  
              </AND>
              <ELEMENTMATCH>
                  
              </ELEMENTMATCH>
              <NOT>
                  
              </NOT>
          </FILTER>
      </QUERY>
   </REQUEST>
*/

namespace TrafikverketdotNET
{
    public class TrafikverketException : Exception
    {
        public TrafikverketException(String message) : base(message) { }
        public TrafikverketException(String message, Exception innerException) : base(message, innerException) { }
    }

    public abstract class BaseTrafikverketResponse
    {
        [JsonProperty("INFO")] internal Subs.Info _Info { get; set; }
        public Subs.Info Info => _Info;
    }

    public abstract class BaseTrafikverketRequest
    {
        internal Query _Query { get; set; }
        public Query Query => _Query;

        internal String _ID { get; set; }
        internal Boolean _IncludeDeletedObjects { get; set; }
        internal UInt32 _Limit { get; set; }
        internal String _OrderBy { get; set; }
        internal UInt32 _Skip { get; set; }
        internal Boolean _LastModified { get; set; }
        internal Int32 _ChangeID { get; set; }

        public String ID => _ID;
        public Boolean IncludeDeletedObjects => _IncludeDeletedObjects;
        public UInt32 Limit => _Limit;
        public String OrderBy => _OrderBy;
        public UInt32 Skip => _Skip;
        public Boolean LastModified => _LastModified;
        public Int32 ChangeID => _ChangeID;

        internal Filter _Filter { get; set; }

        public Filter Filter => _Filter;

        internal String[] _Include { get; set; }
        internal String[] _Exclude { get; set; }
        internal String _Distinct { get; set; }

        public String[] Include => _Include;
        public String[] Exclude => _Exclude;
        public String Distinct => _Distinct;

        public abstract ObjectType ObjectType { get; }
        public abstract String SchemaVersion { get; }

        protected BaseTrafikverketRequest(Filter Filter) { this._Filter = Filter; this._Query = GetQuery(this.ObjectType, this.SchemaVersion); }
        protected BaseTrafikverketRequest(String ID = null, Boolean IncludeDeletedObjects = false,
                                          UInt32 Limit = 0, String OrderBy = null, UInt32 Skip = 0,
                                          Boolean LastModified = false, Int32 ChangeID = 0,
                                          String[] Include = null, String[] Exclude = null, String Distinct = null, Filter Filter = null)
        {
            this._ID = ID;
            this._IncludeDeletedObjects = IncludeDeletedObjects;
            this._Limit = Limit;
            this._OrderBy = OrderBy;
            this._Skip = Skip;
            this._LastModified = LastModified;
            this._ChangeID = ChangeID;
            this._Include = Include;
            this._Exclude = Exclude;
            this._Distinct = Distinct;
            this._Filter = Filter;

            this._Query = GetQuery(this.ObjectType, this.SchemaVersion);
        }

        protected Query GetQuery(ObjectType ObjectType, String SchemaVersion)
        {
            var query = new Query(ObjectType, SchemaVersion, Filter ?? null);
            if (ID != null)
                query.SetID(ID);
            if (IncludeDeletedObjects)
                query.SetIncludeDeletedObjects(IncludeDeletedObjects);
            if (Limit != 0)
                query.SetLimit(Limit);
            if (OrderBy != null)
                query.SetOrderBy(OrderBy);
            if (Skip != 0)
                query.SetSkip(Skip);
            if (LastModified)
                query.SetLastModified(LastModified);
            if (ChangeID != 0)
                query.SetChangeID(ChangeID);
            if (Include != null)
                query.SetInclude(Include);
            if (Exclude != null)
                query.SetExclude(Exclude);
            if (Distinct != null)
                query.SetDistinct(Distinct);

            return query;
        }

        protected void SetID(String ID) { this._ID = ID; }
        protected void SetIncludeDeletedObjects(Boolean IncludeDeletedObjects) { this._IncludeDeletedObjects = IncludeDeletedObjects; }
        protected void SetLimit(UInt32 Limit) { this._Limit = Limit; }
        protected void SetOrderBy(String OrderBy) { this._OrderBy = OrderBy; }
        protected void SetSkip(UInt32 Skip) { this._Skip = Skip; }
        protected void SetLastModified(Boolean LastModified) { this._LastModified = LastModified; }
        protected void SetChangeID(Int32 ChangeID) { this._ChangeID = ChangeID; }

        protected void SetInclude(params String[] Include) { this._Include = Include; }
        protected void SetExclude(params String[] Exclude) { this._Exclude = Exclude; }
        protected void SetDistinct(String Distinct) { this._Distinct = Distinct; }

        public String CreateXMLString() => $"<REQUEST><LOGIN authenticationkey=\"AUTHKEY\"/>{Query.CreateXMLString()}</REQUEST>";
    }

    public abstract class BaseTrafikverket<T, U> : TrafikverketUtils where T : BaseTrafikverketResponse where U : class
    {
        protected BaseTrafikverket(String APIKey) : base(APIKey) { }

        internal abstract ObjectType ObjectType { get; }
        public abstract String CurrentSchemaVersion { get; }

        public abstract T[] ExecuteRequest();
        public abstract T[] ExecuteRequest(String XMLRequest);
        public abstract T[] ExecuteRequest(U Request);

        /// <exception cref="TrafikverketException">Thrown when there's an error returned from Trafikverket.</exception>
        protected virtual T[] ExecuteRequest(String ObjectType, String SchemaVersion)
        {
            var resp = POSTRequest($"<REQUEST>" +
                                    $"<LOGIN authenticationkey=\"{APIKey}\"/>" +
                                    $"<QUERY objecttype=\"{ObjectType}\" schemaversion=\"{SchemaVersion}\"/>" +
                                   $"</REQUEST>");
            return JsonConvert.DeserializeObject<T[]>(JObject.Parse(resp)[$"{ObjectType}"].ToString());
        }

        /// <exception cref="TrafikverketException">Thrown when there's an error returned from Trafikverket.</exception>
        protected virtual T[] ExecuteRequest(String ObjectType, String SchemaVersion, String RequestQuery)
        {
            var resp = POSTRequest(RequestQuery);
            return JsonConvert.DeserializeObject<T[]>(JObject.Parse(resp)[$"{ObjectType}"].ToString());
        }

        /// <exception cref="TrafikverketException">Thrown when there's an error returned from Trafikverket.</exception>
        protected virtual T[] ExecuteCustomRequest(BaseTrafikverketRequest Request)
        {
            var resp = POSTRequest(Request.CreateXMLString(), true);
            return JsonConvert.DeserializeObject<T[]>(JObject.Parse(resp)[$"{Request.Query.ObjectType}"].ToString());
        }
    }
}
