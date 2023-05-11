using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Vanora.Entities
{
    public class CmsCountryTimezone : VvEntityBase
    {
        public long CmsCountryId { get; set; }
        [ForeignKey("CmsCountryId")]
        public CmsCountry CmsCountry { get; set; }
        public long CmsTimezoneId { get; set; }
        [ForeignKey("CmsTimezoneId")]
        public CmsTimezone CmsTimezone { get; set; }
    }