using LeGarage.Core.Common;

namespace LeGarage.Core.Entities
{
    public class Company : BaseEntity
    {
        public required string Name { get; set; }
        public required string HeadQuorter { get; set; }
        public required string Code { get; set; }
        public required string CodeRegister { get; set; }
        public string? LogoLink { get; set; }
        public List<WorkShop> WorkShops { get; set; } = new List<WorkShop>();
    }
}
