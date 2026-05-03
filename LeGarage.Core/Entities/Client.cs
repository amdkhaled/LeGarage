using LeGarage.Core.Common;
using System.ComponentModel.DataAnnotations;

namespace LeGarage.Core.Entities
{
    public class Client : BaseEntity
    {
        [Required(ErrorMessage = "Cin is required."), MaxLength(8)]
        public required string Cin { get; set; }
        [Required(ErrorMessage = "Firdt Name is required."), MaxLength(50)]
        public required string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is required."), MaxLength(50)]
        public required string LastName { get; set; }
        [Required(ErrorMessage = "Contact is required."), MaxLength(50)]
        public required string PhoneNumber { get; set; }
        [MaxLength(100)]
        public string? Email { get; set; }
        [MaxLength(255)]
        public string? Address { get; set; }
        [MaxLength(50)]
        public string? CompanyId { get; set; }
        [MaxLength(100)]
        public string? CompanyName { get; set; }
        public List<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
        public List<Invoice> Invoices { get; set; } = new List<Invoice>();

    }
}
