using LeGarage.Core.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeGarage.Core.Entities
{
    public class WorkOrder : BaseEntity
    {
        [ForeignKey("WorkShop")]
        public int WorkShopId { get; set; }
        [ForeignKey("Vehicle")]
        public int VehicleId { get; set; }
        public required string WorkOrderRecord { get; set; }
        public int Mileage { get; set; }
        public required string Status { get; set; }
        public DateTime ScheduledStart { get; set; }
        public DateTime ActualStart { get; set; }
        public DateTime ActualEnd { get; set; }
        public Decimal LaborCost { get; set; }
        public Decimal PartsCost { get; set; }
        public Decimal ExternalServiceCost { get; set; }
        public Decimal TotalCost { get; set; }
        public WorkShop? WorkShop { get; set; }
        public Vehicle? Vehicle { get; set; }
        public List<Task> Tasks { get; set; } = new List<Task>();

    }
}
