using LeGarage.Core.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeGarage.Core.Entities
{
    public class TaskExternalServiceUsage : BaseEntity
    {
        [ForeignKey("Task")]
        public int TaskId { get; set; }
        [ForeignKey("ExternalService")]
        public int ExternelServiceId { get; set; }
        [ForeignKey("Provider")]
        public int ProviderId { get; set; }
        public string? InvoiceNumber;
        public decimal? UnitPrice { get; set; }
        public int? Quantity { get; set; }
        public decimal Cost { get; set; }
        public Task? Task { get; set; }
        public ExternalService? ExternalService { get; set; }
        public Provider? Provider { get; set; }

    }
}
