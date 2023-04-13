using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vanora.Entities
{
    public class CmsCountryText : VvTextEntity
    {
        [ForeignKey("ParentId")]
        public CmsCountry CmsCountry { get; set; }
        
        [MaxLength(500)]
        public string Name { get; set; }
    }
}