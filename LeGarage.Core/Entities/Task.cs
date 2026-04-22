using LeGarage.Core.Common;
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
        public string? Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime Endtime { get; set; }
        public Decimal LaborCost { get; set; }
        public Decimal PartsCost { get; set; }
        public Decimal ExternalServiceCost { get; set; }
        public Decimal TaskTotalCost { get; set; }
        public WorkOrder? WorkOrder { get; set; }
        public Bridge? Bridge { get; set; }
        public List<PauseRecord> PauseRecords { get; set; } = new List<PauseRecord>();
        public ProvidedService? ProvidedService { get; set; }

    }
}
