using LeGarage.Core.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeGarage.Core.Entities
{
    public class ProvidedService : BaseEntity
    {
        [ForeignKey("ProvidedServiceCategory")]
        public int ProvidedServiceCategoryId { get; set; }
        public required string Name { get; set; }
        public required string PricingModel { get; set; }
        public decimal Rate { get; set; }
        public decimal EstimatedHours { get; set; }
        public decimal MinCharge { get; set; }
        public string? Description { get; set; }
        public List<Task> Tasks { get; set; } = new List<Task>();
        public ProvidedServiceCategory? ProvidedServiceCategory { get; set; }
    }
}
