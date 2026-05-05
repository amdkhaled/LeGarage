using LeGarage.Core.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeGarage.Core.Entities
{
    public class WarehouseStock : BaseEntity
    {
        [ForeignKey("SparePart")]
        public int SparePartId { get; set; }
        [ForeignKey("Warehouse")]
        public int WarehouseId { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Minimum Quantity must be a positive integer.")]
        public int MinimumQuantity { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Current Quantity must be a positive integer.")]
        public int CurrentQuantity { get; set; }
        public SparePart? SparePart { get; set; }
        public Warehouse? Warehouse { get; set; }
    }
}
