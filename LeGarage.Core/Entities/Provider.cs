using LeGarage.Core.Common;

namespace LeGarage.Core.Entities
{
    public class Provider : BaseEntity
    {
        public required string LegalName { get; set; }
        public required string ContactPerson { get; set; }
        public required string Phone { get; set; }
        public string? Email { get; set; }
        public required string Address { get; set; }
        public required string CompanyId { get; set; }
        public string? PaymentTerms;
        public List<TaskExternalServiceUsage> TaskExternalServiceUsages { get; set; } = new List<TaskExternalServiceUsage>();
        public List<StockReplenishment> StockReplenishment { get; set; } = new List<StockReplenishment>();
    }
}
