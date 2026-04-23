using LeGarage.Core.Common;

namespace LeGarage.Core.Entities
{
    public class Warehouse : BaseEntity
    {
        public required string Name { get; set; }
        public required string Location { get; set; }
        public decimal Capacity { get; set; }
        public required string CapacityUnit { get; set; }
        public List<StockReplenishment> StockReplenishments { get; set; } = new List<StockReplenishment>();
        public List<SparePart> SpareParts { get; set; } = new List<SparePart>();
        public List<WarehouseStock> warehouseStocks { get; set; } = new List<WarehouseStock>();
    }
}
