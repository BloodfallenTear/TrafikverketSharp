using System;
using Newtonsoft.Json;

namespace TrafikverketdotNET.Subs.ParkingResponse
{
    public sealed class TariffsAndPayment
    {
        [JsonProperty("FreeOfCharge")] internal Boolean _FreeOfCharge { get; set; }
        [JsonProperty("Tariff")] internal String _Tariff { get; set; }

        /// <summary>
        /// Anger om parkeringen är gratis att använda.
        /// </summary>
        [JsonIgnore] public Boolean FreeOfCharge => _FreeOfCharge;
        /// <summary>
        /// Anger parkeringens avgift.
        /// </summary>
        [JsonIgnore] public String Tariff => _Tariff;

        internal TariffsAndPayment() { }
    }
}
