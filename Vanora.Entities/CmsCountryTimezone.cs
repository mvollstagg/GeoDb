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

        public string ZoneName { get; set; }
        public int GmtOffset { get; set; }
        public string GmtOffsetName { get; set; }
        public string Abbreviation { get; set; }
        public string TimezoneName { get; set; }
    }
}