using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeGarage.Core.Common
{
    public abstract class BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public bool IsActive { get; set; }
        [MaxLength(500)]
        public string? Notes { get; set; }
        public DateTime CreatedAt { get; set; }
        [MaxLength(100)]
        public string? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        [MaxLength(100)]
        public string? UpdatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        [MaxLength(100)]
        public string? DeletedBy { get; set; }
        public DateTime? RestoredAt { get; set; }
        [MaxLength(100)]
        public string? RestoredBy { get; set; }
    }
}
