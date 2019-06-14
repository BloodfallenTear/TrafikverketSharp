using System;
using System.Collections.Generic;
using System.Text;

namespace TrafikverketdotNET
{
    public class FilterGroup
    {
        private FilterOperatorGroup _FilterGroupOperator { get; set; }
        private FilterOperator[] _FilterOperators { get; set; }
        private FilterGroup[] _FilterGroups { get; set; }

        public FilterOperatorGroup FilterGroupOperator => _FilterGroupOperator;
        public FilterOperator[] FilterOperators => _FilterOperators;
        public FilterGroup[] FilterGroups => _FilterGroups;

        public FilterGroup(FilterOperatorGroup FilterGroupOperator)
        {
            this._FilterGroupOperator = FilterGroupOperator;
            _FilterOperators = default(FilterOperator[]);
            _FilterGroups = default(FilterGroup[]);
        }

        public FilterGroup AddOperator(FilterOperator FilterOperator)
        {
            var data = new FilterOperator[_FilterOperators.Length + 1];
            for (UInt16 i = 0; i < _FilterOperators.Length; i++)
                data[i] = _FilterOperators[i];
            data[_FilterOperators.Length] = FilterOperator;
            _FilterOperators = data;
            return this;
        }

        public FilterGroup AddGroup(FilterGroup FilterGroup)
        {
            var data = new FilterGroup[_FilterGroups.Length + 1];
            for (UInt16 i = 0; i < _FilterGroups.Length; i++)
                data[i] = _FilterGroups[i];
            data[_FilterGroups.Length] = FilterGroup;
            _FilterGroups = data;
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
