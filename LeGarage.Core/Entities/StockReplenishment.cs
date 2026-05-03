using LeGarage.Core.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeGarage.Core.Entities
{
    public class StockReplenishment : BaseEntity
    {
        [ForeignKey("Provider")]
        public int ProviderId { get; set; }
        [ForeignKey("Warehouse")]
        public int WareHouseId { get; set; }
        [ForeignKey("SparePart")]
        public int SparePartId { get; set; }
        [Required(ErrorMessage = "Reception Receip is required."), MaxLength(50)]
        public required string ReceptionReceipt { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Received Quantity must be a positive integer.")]
        public int ReceivedQuantity { get; set; }
        public DateTime ReceptionDate { get; set; }
        [Range(1, float.MaxValue, ErrorMessage = "Unit Price Purchase must be a positive decimal.")]
        public decimal UnitPriceAtPurchase { get; set; }
        [Range(1, float.MaxValue, ErrorMessage = "Discount must be a positive decimal.")]
        public decimal Discount { get; set; }
        [Range(1, float.MaxValue, ErrorMessage = "Vat must be a positive decimal.")]
        public decimal Vat { get; set; }
        [Range(1, float.MaxValue, ErrorMessage = "Margin must be a positive decimal.")]
        public decimal Margin { get; set; }
        public Provider? Provider { get; set; }
        public Warehouse? Warehouse { get; set; }
        public SparePart? SparePart { get; set; }
    }
}
