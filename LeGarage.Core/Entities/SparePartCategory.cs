using LeGarage.Core.Common;
using System.ComponentModel.DataAnnotations;

namespace LeGarage.Core.Entities
{
    public class SparePartCategory : BaseEntity
    {
        [Required(ErrorMessage = "Name is required."), MaxLength(100)]
        public required string Name { get; set; }
        [MaxLength(255)]
        public string? Description { get; set; }
        public List<SparePart> SpareParts { get; set; } = new List<SparePart>();
    }
}
