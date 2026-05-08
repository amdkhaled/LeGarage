using LeGarage.Core.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeGarage.Core.Entities
{
    public class WorkOrder : BaseEntity
    {
        [ForeignKey("WorkShop")]
        public int WorkShopId { get; set; }
        [ForeignKey("Vehicle")]
        public int VehicleId { get; set; }
        [ForeignKey("Invoice")]
        public int? InvoiceId { get; set; }
        [Required(ErrorMessage = "Work Order Record is required."), MaxLength(50)]
        public required string WorkOrderRecord { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Mileage Purchase must be a positive integer.")]
        public int Mileage { get; set; }
        [Required(ErrorMessage = "Status is required."), MaxLength(50)]
        public required string Status { get; set; }
        public DateTime ScheduledStart { get; set; }
        public DateTime ActualStart { get; set; }
        public DateTime ActualEnd { get; set; }
        [Range(1, float.MaxValue, ErrorMessage = "Labor Cost  must be a positive decimal.")]
        public Decimal LaborCost { get; set; }
        [Range(1, float.MaxValue, ErrorMessage = "Part Cost  must be a positive decimal.")]
        public Decimal PartsCost { get; set; }
        [Range(1, float.MaxValue, ErrorMessage = "Externel Service Cost must be a positive decimal.")]
        public Decimal ExternalServiceCost { get; set; }
        [Range(1, float.MaxValue, ErrorMessage = "Total Cost must be a positive decimal.")]
        public Decimal TotalCost { get; set; }
        public WorkShop? WorkShop { get; set; }
        public Vehicle? Vehicle { get; set; }
        public Invoice? Invoice { get; set; }
        public List<Job> Jobs { get; set; } = new List<Job>();

    }
}
