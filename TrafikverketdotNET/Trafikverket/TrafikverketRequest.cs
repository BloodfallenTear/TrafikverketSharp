using System;
using System.Collections.Generic;

namespace TrafikverketdotNET
{
    public class TrafikverketRequest 
    {
        private List<Query> _Queries { get; set; }
        public List<Query> Queries => _Queries;

        public TrafikverketRequest(Query Query) { this._Queries = new List<Query>() { Query }; }
        public TrafikverketRequest(List<Query> Queries) { this._Queries = Queries; }

        public String CreateXMLString()
        {
            var xmlString = $"<REQUEST><LOGIN authenticationkey=\"AUTHKEY\"/>";
            foreach (var query in Queries)
                xmlString += $"{query.CreateXMLString()}";
            return $"{xmlString}</REQUEST>";
        }

        public Query AddQuery(Query Query)
        {
            _Queries.Add(Query);
            return Query;
        }
    }
}
