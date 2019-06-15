using System;

namespace TrafikverketdotNET
{
    public class Filter
    {
        internal FilterOperator[] _FilterOperators { get; set; }
        internal FilterGroup[] _FilterGroups { get; set; }

        public FilterOperator[] FilterOperators => _FilterOperators;
        public FilterGroup[] FilterGroups => _FilterGroups;

        public Filter() { _FilterOperators = default(FilterOperator[]); _FilterGroups = default(FilterGroup[]); }

        public Filter AddOperator(FilterOperator FilterOperator)
        {
            if (_FilterOperators == null)
            {
                this._FilterOperators = new FilterOperator[] { FilterOperator };
                return this;
            }
            var data = new FilterOperator[_FilterOperators.Length + 1];
            for (UInt32 i = 0; i < _FilterOperators.Length; i++)
                data[i] = _FilterOperators[i];
            data[_FilterOperators.Length] = FilterOperator;
            _FilterOperators = data;
            return this;
        }

        public Filter AddGroup(FilterGroup FilterGroup)
        {
            if(_FilterGroups?.Length == 0)
            {
                _FilterGroups = new FilterGroup[] { FilterGroup };
                return this;
            }
            var data = new FilterGroup[_FilterGroups.Length + 1];
            for (UInt32 i = 0; i < _FilterGroups.Length; i++)
                data[i] = _FilterGroups[i];
            data[_FilterGroups.Length] = FilterGroup;
            _FilterGroups = data;
            return this;
        }

        public String CreateXMLString()
        {
            String xmlString = null;

            if (_FilterGroups != null)
                foreach (var group in FilterGroups)
                    xmlString += $"{group.CreateXMLString()}";

            if (_FilterOperators != null)
                foreach (var oper in FilterOperators)
                xmlString += $"{oper.CreateXMLString()}";

            if (xmlString.Length > 0)
                return $"<FILTER>{xmlString}</FILTER>";
            return null;
        }

        public void SetFilterOperators(FilterOperator[] FilterOperators) { this._FilterOperators = FilterOperators; }
        public void SetFilterGroups(FilterGroup[] FilterGroups) { this._FilterGroups = FilterGroups; }
    }
}
