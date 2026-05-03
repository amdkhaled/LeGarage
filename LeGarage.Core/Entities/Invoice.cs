using LeGarage.Core.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeGarage.Core.Entities
{
    public class Invoice : BaseEntity
    {
        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime DueDate { get; set; }
        [Required(ErrorMessage = "Status is required."), MaxLength(20)]
        public required string Status { get; set; }
        [Range(1, float.MaxValue, ErrorMessage = "SubtotalLabor must be a positive decimal.")]
        public decimal SubtotalLabor { get; set; }
        [Range(1, float.MaxValue, ErrorMessage = "SubTotal Parts must be a positive decimal.")]
        public decimal SubtotalParts { get; set; }
        [Range(1, float.MaxValue, ErrorMessage = "Min Charge must be a positive decimal.")]
        public decimal SubtotalExternalServices { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public List<WorkOrder> WorkOrders { get; set; } = new List<WorkOrder>();
        public Client? Client { get; set; }

    }
}
