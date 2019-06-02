using System;
using System.Collections.Generic;
using System.Text;

namespace TrafikverketdotNET
{
    public class FilterGroup
    {
        private FilterOperatorGroup _FilterGroupOperator { get; set; }
        private List<FilterOperator> _FilterOperators { get; set; }
        private List<FilterGroup> _FilterGroups { get; set; }

        public FilterOperatorGroup FilterGroupOperator => _FilterGroupOperator;
        public List<FilterOperator> FilterOperators => _FilterOperators;
        public List<FilterGroup> FilterGroups => _FilterGroups;

        public FilterGroup(FilterOperatorGroup FilterGroupOperator)
        {
            this._FilterGroupOperator = FilterGroupOperator;
            _FilterOperators = new List<FilterOperator>();
            _FilterGroups = new List<FilterGroup>();
        }

        public FilterGroup AddOperator(FilterOperator FilterOperator)
        {
            _FilterOperators.Add(FilterOperator);
            return this;
        }

        public FilterGroup AddGroup(FilterGroup FilterGroup)
        {
            _FilterGroups.Add(FilterGroup);
            return this;
        }

        public String CreateXMLString()
        {
            var xmlString = $"<{FilterGroupOperator}>";

            foreach (var group in FilterGroups)
                xmlString += $"{group.CreateXMLString()}";

            foreach (var oper in FilterOperators)
                xmlString += $"{oper.CreateXMLString()}";

            return $"{xmlString}</{FilterGroupOperator}>";
        }

        public void ChangeOperator(FilterOperatorGroup FilterGroupOperator) { this._FilterGroupOperator = FilterGroupOperator; }
    }
}
