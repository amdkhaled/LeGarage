using LeGarage.Core.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeGarage.Core.Entities
{
    public class WarehouseStock : BaseEntity
    {
        [ForeignKey("SparePart")]
        public int SparePartId { get; set; }
        [ForeignKey("Warehouse")]
        public int WarehouseId { get; set; }
        public int MinimumQuantity { get; set; }
        public int CurrentQuantity { get; set; }
        public SparePart? SparePart { get; set; }
        public Warehouse? Warehouse { get; set; }
    }
}
