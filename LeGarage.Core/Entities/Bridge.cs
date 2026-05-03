using LeGarage.Core.Common;
using System.ComponentModel.DataAnnotations;

namespace LeGarage.Core.Entities
{
    public class Bridge : BaseEntity
    {
        [Required(ErrorMessage = "Code is required."), MaxLength(20)]
        public required string Code { get; set; }
        [Required(ErrorMessage = "Name is required."), MaxLength(100)]
        public required string Name { get; set; }
        [Required(ErrorMessage = "CapacityKg is required."), Range(1, int.MaxValue, ErrorMessage = "CapacityKg must be a positive integer.")]
        public required int CapacityKg { get; set; }
        public bool IsAvailable { get; set; } = true;
        public List<Task> Tasks { get; set; } = new List<Task>();
    }
}
