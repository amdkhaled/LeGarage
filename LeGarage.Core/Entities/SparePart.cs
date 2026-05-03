using LeGarage.Core.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeGarage.Core.Entities
{
    public class SparePart : BaseEntity
    {
        [ForeignKey("SparePartCategory")]
        public int SparePartCategoryId { get; set; }
        [Required(ErrorMessage = "SparePart Code is required."), MaxLength(50)]
        public required string SparePartCode { get; set; }
        [Required(ErrorMessage = "Name is required."), MaxLength(50)]
        public required string Name { get; set; }
        [MaxLength(255)]
        public string? Description { get; set; }
        [Range(1, float.MaxValue, ErrorMessage = "Unit Price must be a positive decimal.")]
        public decimal UnitPrice { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Available Quantity must be a positive integer.")]
        public int AvailableQuantity { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Minimum Stock must be a positive decimal.")]
        public int MinimumStock { get; set; }
        public SparePartCategory? SparePartCategory { get; set; }
        public List<StockReplenishment> StockReplenishments { get; set; } = new List<StockReplenishment>();
        public List<WarehouseStock> WarehouseStocks { get; set; } = new List<WarehouseStock>();
        public List<TaskPartUsage> TaskPartUsages { get; set; } = new List<TaskPartUsage>();

    }
}
