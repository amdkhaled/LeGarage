using LeGarage.Core.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeGarage.Core.Entities
{
    public class StockReplenishment : BaseEntity
    {
        [ForeignKey("Provider")]
        public int ProviderId { get; set; }
        [ForeignKey("Warehouse")]
        public int WareHouseId { get; set; }
        [ForeignKey("Warehouse")]
        public int SparePartId { get; set; }
        public required string ReceptionReceipt { get; set; }
        public int ReceivedQuantity { get; set; }
        public DateTime ReceptionDate { get; set; }
        public decimal UnitPriceAtPurchase { get; set; }
        public decimal Discount { get; set; }
        public decimal Vat { get; set; }
        public decimal Margin { get; set; }
        public Provider? Provider { get; set; }
        public Warehouse? Warehouse { get; set; }
        public SparePart? SparePart { get; set; }
    }
}
