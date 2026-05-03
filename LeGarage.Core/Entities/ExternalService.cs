using LeGarage.Core.Common;
using System.ComponentModel.DataAnnotations;

namespace LeGarage.Core.Entities
{
    public class ExternalService : BaseEntity
    {
        [Required(ErrorMessage = "Name is required."), MaxLength(100)]
        public required string Name { get; set; }
        [MaxLength(200)]
        public string? Description { get; set; }
        [MaxLength(50)]
        public string? Category { get; set; }
        [Required(ErrorMessage = "Unit is required."), MaxLength(20)]
        public required string Unit { get; set; }
        [Range(1, float.MaxValue, ErrorMessage = "Cost must be a positive decimal.")]
        public decimal Cost { get; set; }
        public List<TaskExternalServiceUsage> TaskExternalServiceUsages { get; set; } = new List<TaskExternalServiceUsage>();
    }
}
