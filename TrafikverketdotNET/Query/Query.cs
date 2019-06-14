using System;

namespace TrafikverketdotNET
{
    public class Query
    {
        private ObjectType _ObjectType { get; set; }
        private String _SchemaVersion { get; set; }
        private String _ID { get; set; }
        private Boolean _IncludeDeletedObjects { get; set; }
        private UInt32 _Limit { get; set; }
        private String _OrderBy { get; set; }
        private UInt32 _Skip { get; set; }
        private Boolean _LastModified { get; set; }
        private Int32 _ChangeID { get; set; }

        public ObjectType ObjectType => _ObjectType;
        public String SchemaVersion => _SchemaVersion;
        public String ID => _ID;
        public Boolean IncludeDeletedObjects => _IncludeDeletedObjects;
        public UInt32 Limit => _Limit;
        public String OrderBy => _OrderBy;
        public UInt32 Skip => _Skip;
        public Boolean LastModified => _LastModified;
        public Int32 ChangeID => _ChangeID;

        private Filter _Filter { get; set; }

        public Filter Filter => _Filter;

        private String[] _Include { get; set; }
        private String[] _Exclude { get; set; }
        private String _Distinct { get; set; }

        public String[] Include => _Include;
        public String[] Exclude => _Exclude;
        public String Distinct => _Distinct;

        public Query(ObjectType ObjectType, String SchemaVersion)
        {
            this._ObjectType = ObjectType;
            this._SchemaVersion = SchemaVersion;
            this._Filter = new Filter();
            this._Include = default(String[]);
            this._Exclude = default(String[]);

        }
        public Query(ObjectType ObjectType, String SchemaVersion, Filter Filter)
        {
            this._ObjectType = ObjectType;
            this._SchemaVersion = SchemaVersion;
            this._Filter = Filter;
            this._Include = default(String[]);
            this._Exclude = default(String[]);
        }

        public String CreateXMLString()
        {
            var xmlString = $"<QUERY objecttype=\"{ObjectType}\" schemaversion=\"{SchemaVersion}\"";

            if (ID?.Length > 0)
                xmlString += $" id=\"{ID}\"";
            if (IncludeDeletedObjects)
                xmlString += $" includedeletedobjects=\"{IncludeDeletedObjects}\"";
            if (Limit != 0)
                xmlString += $" limit=\"{Limit}\"";
            if (OrderBy?.Length > 0)
                xmlString += $" orderby=\"{OrderBy}\"";
            if (Skip != 0)
                xmlString += $" skip=\"{Skip}\"";
            if (LastModified)
                xmlString += $" lastmodified=\"{LastModified}\"";
            if (ChangeID != 0)
                xmlString += $" changeid=\"{ChangeID}\"";

            if(Filter?.FilterOperators?.Count > 0 || Filter?.FilterGroups?.Count > 0)
                return $"{xmlString}>{Filter.CreateXMLString()}</QUERY>";
            else
                return $"{xmlString}></QUERY>";
        }

        public void SetID(String ID) { this._ID = ID; }
        public void SetIncludeDeletedObjects(Boolean IncludeDeletedObjects) { this._IncludeDeletedObjects = IncludeDeletedObjects; }
        public void SetLimit(UInt32 Limit) { this._Limit = Limit; }
        public void SetOrderBy(String OrderBy) { this._OrderBy = OrderBy; }
        public void SetSkip(UInt32 Skip) { this._Skip = Skip; }
        public void SetLastModified(Boolean LastModified) { this._LastModified = LastModified; }
        public void SetChangeID(Int32 ChangeID) { this._ChangeID = ChangeID; }

        public void SetInclude(params String[] Include) { this._Include = Include; }
        public void SetExclude(params String[] Exclude) { this._Exclude = Exclude; }
        public void SetDistinct(String Distinct) { this._Distinct = Distinct; }

        public void SetFilter(Filter Filter) { this._Filter = Filter; }
    }
}
