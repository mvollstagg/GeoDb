using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Vanora.Entities
{
    public class CmsCountry : VvEntityBase
    {
        public bool Active { get; set; }
        public int DisplayOrder { get; set; }
        [MaxLength(3)]
        public string Iso3 { get; set; }
        [MaxLength(2)]
        public string Iso2 { get; set; }
        public string NumericCode { get; set; }
        [MaxLength(5)]
        public string PhoneCode { get; set; }
        public string Capital { get; set; }
        public string Currency { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencySymbol { get; set; }
        public string TopLevelDomain { get; set; }
        public string Native { get; set; }
        public string Region { get; set; }
        public string Subregion { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Emoji { get; set; }
        public bool Deleted { get; set; }
        public List<CmsCountryTimezone> Timezones { get; set; }
        public List<CmsCountryText> Texts { get; set; }
        public List<CmsCity> Cities { get; set; }
    }
}