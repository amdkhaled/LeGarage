using LeGarage.Core.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeGarage.Core.Entities
{
    public class Vehicle : BaseEntity
    {
        [ForeignKey("Client")]
        public int ClientId { get; set; }
        [Required(ErrorMessage = "VIN is required."), MaxLength(20)]
        public required string Vin { get; set; }
        [MaxLength(50)]
        public string? PlateNumber { get; set; }
        [MaxLength(50)]
        public string? Make { get; set; }
        [MaxLength(50)]
        public string? Model { get; set; }
        public DateTime Year { get; set; }
        public int Mileage { get; set; }
        [Required(ErrorMessage = "Fuel Type is required."), MaxLength(50)]
        public required string FuelType { get; set; }
        [Required(ErrorMessage = "Transmission Type is required."), MaxLength(50)]
        public required string TransmissionType { get; set; }
        public Client? Client { get; set; }
        public List<WorkOrder> WorkOrders { get; set; } = new List<WorkOrder>();
    }
}
