using LeGarage.Core.Common;
using System.ComponentModel.DataAnnotations;
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
        [MaxLength(50)]
        public string? InvoiceNumber;
        [Range(1, float.MaxValue, ErrorMessage = "Unit Price must be a positive decimal.")]
        public decimal? UnitPrice { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be a positive integer.")]
        public int? Quantity { get; set; }
        [Range(1, float.MaxValue, ErrorMessage = "Cost must be a positive decimal.")]
        public decimal Cost { get; set; }
        public Job? Job { get; set; }
        public ExternalService? ExternalService { get; set; }
        public Provider? Provider { get; set; }

    }
}
