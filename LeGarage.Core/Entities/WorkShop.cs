using LeGarage.Core.Common;

namespace LeGarage.Core.Entities
{
    public class WorkShop : BaseEntity
    {
        public required string Code { get; set; }
        public required string Name { get; set; }
        public required string Location { get; set; }
        public required string PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? OpeningHourse { get; set; }
        public List<WorkOrder> WorkOrders { get; set; } = new List<WorkOrder>();
    }
}
