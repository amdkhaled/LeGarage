using LeGarage.Core.Common;
using System.ComponentModel.DataAnnotations;

namespace LeGarage.Core.Entities
{
    public class ProvidedServiceCategory : BaseEntity
    {
        [Required(ErrorMessage = "Name is required."), MaxLength(50)]
        public required string Name { get; set; }
        [Required(ErrorMessage = "Code is required."), MaxLength(20)]
        public required string Code { get; set; }
        [MaxLength(255)]
        public string? Description { get; set; }
        public List<ProvidedService> ProvidedServices { get; set; } = new List<ProvidedService>();
    }
}
