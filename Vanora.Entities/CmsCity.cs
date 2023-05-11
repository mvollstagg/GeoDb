using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Vanora.Entities
{
    public class CmsCity : VvEntityBase
    {
        public long CmsCountryId { get; set; }
        [ForeignKey("CmsCountryId")]
        public CmsCountry CmsCountry { get; set; }

        public bool Active { get; set; }
        public string StateCode { get; set; }
        public string? Latitude { get; set; }
        public string? Longitude { get; set; }
        public string? Type { get; set; }
        public bool Deleted { get; set; }
        public List<CmsCityText> Texts { get; set; }
        public List<CmsCounty> Counties { get; set; }
    }
}