using LeGarage.Core.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeGarage.Core.Entities
{
    public class Invoice : BaseEntity
    {
        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime DueDate { get; set; }
        public required string Status { get; set; }
        public decimal SubtotalLabor { get; set; }
        public decimal SubtotalParts { get; set; }
        public decimal SubtotalExternalServices { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public List<WorkOrder> WorkOrders { get; set; } = new List<WorkOrder>();
        public Client? Client { get; set; }

    }
}
