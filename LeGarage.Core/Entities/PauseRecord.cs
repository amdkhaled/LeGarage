using LeGarage.Core.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeGarage.Core.Entities
{
    public class PauseRecord : BaseEntity
    {
        [ForeignKey("Task")]
        public int TaskId { get; set; }
        public required string Reason { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int PauseDuration { get; set; }
        public Task? Task { get; set; }
    }
}
