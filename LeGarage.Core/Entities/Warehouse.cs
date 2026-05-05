using LeGarage.Core.Common;
using System.ComponentModel.DataAnnotations;

namespace LeGarage.Core.Entities
{
    public class Warehouse : BaseEntity
    {

        [Required(ErrorMessage = "Name is required."), MaxLength(50)]
        public required string Name { get; set; }
        [Required(ErrorMessage = "Location is required."), MaxLength(50)]
        public required string Location { get; set; }
        [Range(1, float.MaxValue, ErrorMessage = "Capacity must be a positive decimal.")]
        public decimal Capacity { get; set; }
        [Required(ErrorMessage = "Capacity Unit is required."), MaxLength(50)]
        public required string CapacityUnit { get; set; }
        public List<StockReplenishment> StockReplenishments { get; set; } = new List<StockReplenishment>();
        public List<SparePart> SpareParts { get; set; } = new List<SparePart>();
        public List<WarehouseStock> warehouseStocks { get; set; } = new List<WarehouseStock>();
    }
}
