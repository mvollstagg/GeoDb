using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vanora.Entities
{
    public class CmsCountyText : VvTextEntity
    {
        [ForeignKey("ParentId")]
        public CmsCounty CmsCounty { get; set; }
        
        [MaxLength(500)]
        public string Name { get; set; }
    }
}