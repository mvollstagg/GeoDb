using System.ComponentModel.DataAnnotations;

namespace Vanora.Entities
{
    public class VvEntityBase
    {
        [Key]
        [UIHint("HiddenInput")]
        public virtual long Id { get; set; }
    }
}