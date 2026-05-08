using LeGarage.Core.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeGarage.Core.Entities
{
    public class PauseRecord : BaseEntity
    {
        [ForeignKey("Task")]
        public int TaskId { get; set; }
        [Required(ErrorMessage = "Reason is required."), MaxLength(255)]
        public required string Reason { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Pause Duration must be a positive integer.")]
        public int PauseDuration { get; set; }
        public Job? Job { get; set; }
    }
}
