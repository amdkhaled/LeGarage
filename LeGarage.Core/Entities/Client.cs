using LeGarage.Core.Common;
using System.ComponentModel.DataAnnotations;

namespace LeGarage.Core.Entities
{
    public class Client : BaseEntity
    {
        [StringLength(8)]
        public required string Cin { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? CompanyId { get; set; }
        public string? CompanyName { get; set; }
        public List<Vehicle> Vehicles { get; set; } = new List<Vehicle>();


    }
}
