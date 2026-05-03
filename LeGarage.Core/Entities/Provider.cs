using LeGarage.Core.Common;
using System.ComponentModel.DataAnnotations;

namespace LeGarage.Core.Entities
{
    public class Provider : BaseEntity
    {
        [Required(ErrorMessage = "Name is required."), MaxLength(100)]
        public required string LegalName { get; set; }
        [Required(ErrorMessage = "Contact is required."), MaxLength(100)]
        public required string ContactPerson { get; set; }
        [Required(ErrorMessage = "Contact is required."), MaxLength(50)]
        public required string Phone { get; set; }
        [MaxLength(100)]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Adress is required."), MaxLength(255)]
        public required string Address { get; set; }
        [Required(ErrorMessage = "Company ID is required."), MaxLength(50)]
        public required string CompanyId { get; set; }
        [MaxLength(50)]
        public string? PaymentTerms;
        public List<TaskExternalServiceUsage> TaskExternalServiceUsages { get; set; } = new List<TaskExternalServiceUsage>();
        public List<StockReplenishment> StockReplenishment { get; set; } = new List<StockReplenishment>();
    }
}
