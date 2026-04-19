using LeGarage.Core.Common;

namespace LeGarage.Core.Entities
{
    public class Bridge : BaseEntity
    {
        public required string Code { get; set; }
        public required string Name { get; set; }
        public required int CapacityKg { get; set; }
        public bool IsAvailable { get; set; }
    }
}
