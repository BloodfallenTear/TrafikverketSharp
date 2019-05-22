using System;
using Newtonsoft.Json;

namespace TrafikverketdotNET.Subs.ParkingResponse
{
    public sealed class Operator
    {
        [JsonProperty("Contact")] internal String _Contact { get; set; }
        [JsonProperty("ContactEmail")] internal String _ContactEmail { get; set; }
        [JsonProperty("ContactTelephoneNumber")] internal String _ContactTelephoneNumber { get; set; }
        [JsonProperty("Name")] internal String _Name { get; set; }

        /// <summary>
        /// Namn på operatörens kontakt.
        /// </summary>
        [JsonIgnore] public String Contact => _Contact;
        /// <summary>
        /// Operatörens kontaktmail.
        /// </summary>
        [JsonIgnore] public String ContactEmail => _ContactEmail;
        /// <summary>
        /// Operatörens kontakttelefon.
        /// </summary>
        [JsonIgnore] public String ContactTelephoneNumber => _ContactTelephoneNumber;
        /// <summary>
        /// Operatörens namn
        /// </summary>
        [JsonIgnore] public String Name => _Name;

        internal Operator() { }
    }
}
