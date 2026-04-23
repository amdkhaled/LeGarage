using LeGarage.Core.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeGarage.Core.Entities
{
    public class SparePart : BaseEntity
    {
        [ForeignKey("SparePartCategory")]
        public int SparePartCategoryId { get; set; }
        public required string SparePartCode { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public decimal UnitPrice { get; set; }
        public int AvailableQuantity { get; set; }
        public int MinimumStock { get; set; }
        public SparePartCategory? SparePartCategory { get; set; }
        public List<StockReplenishment> StockReplenishments { get; set; } = new List<StockReplenishment>();
        public List<WarehouseStock> WarehouseStocks { get; set; } = new List<WarehouseStock>();
        public List<TaskPartUsage> TaskPartUsages { get; set; } = new List<TaskPartUsage>();

    }
}
