using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vanora.Entities
{
    public class CmsCounty : VvEntityBase
    {
        public long CmsCityId { get; set; }
        [ForeignKey("CmsCityId")]
        public CmsCity CmsCity { get; set; }

        public bool Active { get; set; }        
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public bool Deleted { get; set; }
        public List<CmsCountyText> Texts { get; set; }
    }
}