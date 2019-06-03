using System;
using System.Collections.Generic;

namespace TrafikverketdotNET
{
    public class Filter
    {
            private List<FilterOperator> _FilterOperators { get; set; }
            private List<FilterGroup> _FilterGroups { get; set; }

            public List<FilterOperator> FilterOperators => _FilterOperators;
            public List<FilterGroup> FilterGroups => _FilterGroups;

            public Filter() { _FilterOperators = new List<FilterOperator>(); _FilterGroups = new List<FilterGroup>(); }

            public Filter AddOperator(FilterOperator FilterOperator)
            {
                _FilterOperators.Add(FilterOperator);
                return this;
            }

            public Filter AddGroup(FilterGroup FilterGroup)
            {
                _FilterGroups.Add(FilterGroup);
                return this;
            }

            public String CreateXMLString()
            {
                String xmlString = null;

                foreach (var group in FilterGroups)
                    xmlString += $"{group.CreateXMLString()}";

                foreach (var oper in FilterOperators)
                    xmlString += $"{oper.CreateXMLString()}";

                if (xmlString.Length > 0)
                    return $"<FILTER>{xmlString}</FILTER>";
                return null;
            }

            public void SetFilterOperators(List<FilterOperator> FilterOperators) { this._FilterOperators = FilterOperators; }
            public void SetFilterGroups(List<FilterGroup> FilterGroups) { this._FilterGroups = FilterGroups; }
    }
}
