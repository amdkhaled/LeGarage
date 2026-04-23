using LeGarage.Core.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeGarage.Core.Entities
{
    public class TaskPartUsage : BaseEntity
    {
        [ForeignKey("Warehouse")]
        public int WarehouseId { get; set; }
        [ForeignKey("SparePart")]
        public int SparePartId { get; set; }
        [ForeignKey("Task")]
        public int TaskId { get; set; }
        public int QuantityUsed { get; set; }
        public int UnitPrice { get; set; }
        public Decimal TotalPartCost { get; set; }
        public string? DeliveryNote { get; set; }
        public Warehouse? Warehouse { get; set; }
        public SparePart? SparePart { get; set; }
        public Task? Task { get; set; }

    }
}
