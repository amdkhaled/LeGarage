using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace LeGarage.Core.Entities
{
    public class Employee : IdentityUser<int>
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Name is required."),
         MaxLength(100, ErrorMessage = "Name cannot exceed 100 characters.")]
        public required string Name { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "LastName is required."),
         MaxLength(100, ErrorMessage = "LastName cannot exceed 100 characters.")]
        public required string LastName { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "PhoneNumber is required."),
         MaxLength(100, ErrorMessage = "PhoneNumber cannot exceed 20 characters.")]
        public required string Address { get; set; }
        public DateTime HireDate { get; set; }
        [MaxLength(50, ErrorMessage = "AvailabilityStatus cannot exceed 50 characters.")]
        public string? AvailabilityStatus { get; set; }
    }
}
