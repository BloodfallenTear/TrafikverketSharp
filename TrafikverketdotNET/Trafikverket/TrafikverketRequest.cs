using System;

namespace TrafikverketdotNET
{
    public class TrafikverketRequest 
    {
        internal Query[] _Queries { get; set; }
        public Query[] Queries => _Queries;

        public TrafikverketRequest(Query Query) { this._Queries = new Query[] { Query }; }
        public TrafikverketRequest(params Query[] Queries) { this._Queries = Queries; }

        public String CreateXMLString()
        {
            var xmlString = $"<REQUEST><LOGIN authenticationkey=\"AUTHKEY\"/>";
            foreach (var query in Queries)
                xmlString += $"{query.CreateXMLString()}";
            return $"{xmlString}</REQUEST>";
        }

        public TrafikverketRequest AddQuery(Query Query)
        {
            var data = new Query[_Queries.Length + 1];
            for (UInt16 i = 0; i < _Queries.Length; i++)
                data[i] = _Queries[i];
            data[_Queries.Length] = Query;
            _Queries = data;
            return this;
        }
    }
}
