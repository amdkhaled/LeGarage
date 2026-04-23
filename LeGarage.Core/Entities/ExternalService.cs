using LeGarage.Core.Common;

namespace LeGarage.Core.Entities
{
    public class ExternalService : BaseEntity
    {
        public required string Name { get; set; }
        public string? Description { get; set; }
        public string? Category { get; set; }
        public required string Unit { get; set; }
        public decimal Cost { get; set; }
        public List<TaskExternalServiceUsage> TaskExternalServiceUsages { get; set; } = new List<TaskExternalServiceUsage>();
    }
}
