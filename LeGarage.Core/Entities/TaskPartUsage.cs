using LeGarage.Core.Common;
using System.ComponentModel.DataAnnotations;
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
        [Range(1, int.MaxValue, ErrorMessage = "Quantity Used must be a positive integer.")]
        public int QuantityUsed { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Unit Price must be a positive integer.")]
        public int UnitPrice { get; set; }
        [Range(1, float.MaxValue, ErrorMessage = "Total Part Cost must be a positive decimal.")]
        public Decimal TotalPartCost { get; set; }
        [MaxLength(50)]
        public string? DeliveryNote { get; set; }
        public Warehouse? Warehouse { get; set; }
        public SparePart? SparePart { get; set; }
        public Job? Job { get; set; }

    }
}
