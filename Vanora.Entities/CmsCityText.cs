using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Vanora.Entities
{
    public class CmsCityText : VvTextEntity
    {
        [ForeignKey("ParentId")]
        public CmsCity CmsCity { get; set; }
        
        [JsonPropertyName("name")]
        [MaxLength(500)]
        public string Name { get; set; }
    }
}