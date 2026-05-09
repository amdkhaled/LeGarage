using LeGarage.Core.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeGarage.Core.Entities
{
    public class WorkShop : BaseEntity
    {
        [ForeignKey("Company")]
        public int CompanyId { get; set; }

        [Required(ErrorMessage = "Code is required."), MaxLength(50)]
        public required string Code { get; set; }
        [Required(ErrorMessage = "Name is required."), MaxLength(50)]
        public required string Name { get; set; }
        [Required(ErrorMessage = "Location is required."), MaxLength(50)]
        public required string Location { get; set; }
        [Required(ErrorMessage = "Phone Number is required."), MaxLength(50)]
        public required string PhoneNumber { get; set; }
        [MaxLength(50)]
        public string? Email { get; set; }
        [MaxLength(50)]
        public string? OpeningHourse { get; set; }
        public List<WorkOrder> WorkOrders { get; set; } = new List<WorkOrder>();
        public Company? Company { get; set; }
    }
}
