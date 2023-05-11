using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Vanora.Entities;

namespace Vanora.Cms.Api.Data
{
    public class CmsTimezone : VvEntityBase
    {
        public string ZoneName { get; set; }
        public int GmtOffset { get; set; }
        public string GmtOffsetName { get; set; }
        public string Abbreviation { get; set; }
        public string TimezoneName { get; set; }
    }
}