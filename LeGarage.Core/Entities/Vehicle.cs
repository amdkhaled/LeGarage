using LeGarage.Core.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeGarage.Core.Entities
{
    public class Vehicle : BaseEntity
    {
        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public required string Vin { get; set; }
        public string? PlateNumber { get; set; }
        public string? Make { get; set; }
        public string? Model { get; set; }
        public DateTime Year { get; set; }
        public int Mileage { get; set; }
        public required string FuelType { get; set; }
        public required string TransmissionType { get; set; }
        public Client? Client { get; set; }
    }
}
