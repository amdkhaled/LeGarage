using LeGarage.Core.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeGarage.Core.Entities
{
    public class ProvidedService : BaseEntity
    {
        [ForeignKey("ProvidedServiceCategory")]
        public int ProvidedServiceCategoryId { get; set; }
        [Required(ErrorMessage = "Name is required."), MaxLength(50)]
        public required string Name { get; set; }
        [Required(ErrorMessage = "Pricing Model is required."), MaxLength(50)]
        public required string PricingModel { get; set; }
        [Range(1, float.MaxValue, ErrorMessage = "Rate must be a positive decimal.")]
        public decimal Rate { get; set; }
        [MaxLength(50)]
        public decimal EstimatedHours { get; set; }
        [Range(1, float.MaxValue, ErrorMessage = "Min Charge must be a positive decimal.")]
        public decimal MinCharge { get; set; }
        [MaxLength(100)]
        public string? Description { get; set; }
        public List<Job> Jobs { get; set; } = new List<Job>();
        public ProvidedServiceCategory? ProvidedServiceCategory { get; set; }
    }
}
