using System;

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
            this._FilterGroups = null;
            this._FilterOperators = null;
        }

        public FilterGroup AddOperator(FilterOperator FilterOperator)
        {
            if (_FilterOperators == null)
            {
                this._FilterOperators = new FilterOperator[] { FilterOperator };
                return this;
            }
            var data = new FilterOperator[_FilterOperators.Length + 1];
            for (UInt16 i = 0; i < _FilterOperators.Length; i++)
                data[i] = _FilterOperators[i];
            data[_FilterOperators.Length] = FilterOperator;
            _FilterOperators = data;
            return this;
        }

        public FilterGroup AddGroup(FilterGroup FilterGroup)
        {
            if (_FilterGroups == null)
            {
                this._FilterGroups = new FilterGroup[] { FilterGroup };
                return this;
            }
            var data = new FilterGroup[_FilterGroups.Length + 1];
            for (UInt16 i = 0; i < _FilterGroups.Length; i++)
                data[i] = _FilterGroups[i];
            data[_FilterGroups.Length] = FilterGroup;
            _FilterGroups = data;
            return FilterGroup;
        }

        public String CreateXMLString()
        {
            var xmlString = $"<{FilterGroupOperator}>";

            if (FilterGroups != null)
                foreach (var group in FilterGroups)
                    xmlString += $"{group.CreateXMLString()}";

            if (FilterOperators != null)
                foreach (var oper in FilterOperators)
                    xmlString += $"{oper.CreateXMLString()}";

            return $"{xmlString}</{FilterGroupOperator}>";
        }

        public void ChangeOperator(FilterOperatorGroup FilterGroupOperator) { this._FilterGroupOperator = FilterGroupOperator; }
    }
}
