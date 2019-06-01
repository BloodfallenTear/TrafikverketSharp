using System;

namespace TrafikverketdotNET
{
    public class FilterOperator
    {
        private FilterOperatorType _FilterOperatorType { get; set; }
        private String _Name { get; set; }
        private String _Value { get; set; }
        private Shape _Shape { get; set; }
        private String _Radius { get; set; }
        private String _MinDistance { get; set; }
        private String _MaxDistance { get; set; }

        public FilterOperatorType FilterOperatorType => _FilterOperatorType;
        public String Name => _Name;
        public String Value => _Value;
        public Shape Shape => _Shape;
        public String Radius => _Radius;
        public String MinDistance => _MinDistance;
        public String MaxDistance => _MaxDistance;

        public FilterOperator(FilterOperatorType FilterOperatorType, String Name, String Value)
        {
            this._FilterOperatorType = FilterOperatorType;
            this._Name = Name;
            this._Value = Value;
        }

        public FilterOperator(FilterOperatorType FilterOperatorType, String Name, String Value, Shape Shape)
        {
            this._FilterOperatorType = FilterOperatorType;
            this._Name = Name;
            this._Value = Value;
            this._Shape = Shape;
        }

        public FilterOperator(FilterOperatorType FilterOperatorType, String Name, String Value, Shape Shape, String Radius)
        {
            this._FilterOperatorType = FilterOperatorType;
            this._Name = Name;
            this._Value = Value;
            this._Shape = Shape;
            this._Radius = Radius;
        }

        public FilterOperator(FilterOperatorType FilterOperatorType, String Name, String Value, String MinDistance, String MaxDistance)
        {
            this._FilterOperatorType = FilterOperatorType;
            this._Name = Name;
            this._Value = Value;
            this._MinDistance = MinDistance;
            this._MaxDistance = MaxDistance;
        }

        public String CreateXMLString()
        {
            if(Name?.Length > 0 && Value?.Length > 0)
            {
                var xmlString = $"<{FilterOperatorType} name=\"{Name}\" value=\"{Value}\" ";
                if (Shape != Shape.None)
                    xmlString += $"shape=\"{Shape}\" ";
                if (Radius?.Length > 0)
                    xmlString += $"radius=\"{Radius}\" ";
                if (MinDistance?.Length > 0)
                    xmlString += $"mindistance=\"{MinDistance}\" ";
                if (MaxDistance?.Length > 0)
                    xmlString += $"maxdistance=\"{MaxDistance}\" ";
                xmlString += "/>";

                return xmlString;
            }
            return null;
        }

        public void SetOperatorType(FilterOperatorType FilterOperatorType) { this._FilterOperatorType = FilterOperatorType; }
        public void SetName(String Name) { this._Name = Name; }
        public void SetValue(String Value) { this._Value = Value; }
        public void SetShape(Shape Shape) { this._Shape = Shape; }
        public void SetRadius(String Radius) { this._Radius = Radius; }
        public void SetMinDistance(String MinDistance) { this._MinDistance = MinDistance; }
        public void SetMaxDistance(String MaxDistance) { this._MaxDistance = MaxDistance; }
    }
}
