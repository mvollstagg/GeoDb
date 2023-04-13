using System.ComponentModel.DataAnnotations;

namespace Vanora.Entities
{
    public class VvTextEntity : VvEntityBase
    {
        public long ParentId { get; set; }
        public long CmsLanguageId { get; set; }
    }
}