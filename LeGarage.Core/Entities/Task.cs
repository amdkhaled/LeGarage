using LeGarage.Core.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeGarage.Core.Entities
{
    public class Task : BaseEntity
    {
        [ForeignKey("WorkOrder")]
        public int WorkOrderId { get; set; }
        [ForeignKey("Bridge")]
        public int BridgeId { get; set; }
        [ForeignKey("ProvidedService")]
        public int ProvidedServiceId { get; set; }
        [MaxLength(250)]
        public string? Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime Endtime { get; set; }
        [Range(1, float.MaxValue, ErrorMessage = "Labor Cost must be a positive decimal.")]
        public Decimal LaborCost { get; set; }
        [Range(1, float.MaxValue, ErrorMessage = "Part Cost must be a positive decimal.")]
        public Decimal PartsCost { get; set; }
        [Range(1, float.MaxValue, ErrorMessage = "Externel Service Cost must be a positive decimal.")]
        public Decimal ExternalServiceCost { get; set; }
        [Range(1, float.MaxValue, ErrorMessage = "Task Total Cost must be a positive decimal.")]
        public Decimal TaskTotalCost { get; set; }
        public WorkOrder? WorkOrder { get; set; }
        public Bridge? Bridge { get; set; }
        public ProvidedService? ProvidedService { get; set; }
        public List<PauseRecord> PauseRecords { get; set; } = new List<PauseRecord>();
        public List<TaskExternalServiceUsage> TaskExternalServiceUsage { get; set; } = new List<TaskExternalServiceUsage>();
        public List<TaskPartUsage> TaskPartUsages { get; set; } = new List<TaskPartUsage>();

    }
}
