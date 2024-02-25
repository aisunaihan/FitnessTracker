using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FitnessTrackingSystem.Infrastructure.Data.DataConstants;
namespace FitnessTrackingSystem.Infrastructure.Data.Models
{
    public class Activity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(ActivityDataConstants.MaxActivityNameLength)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(ActivityDataConstants.MaxActivityNotesLength)]
        public string Notes {  get; set; } = string.Empty;

        [Required]
        [Range(
            ActivityDataConstants.MaxActivityDuration,
            ActivityDataConstants.MinActivityDuration)]
        public int Duration { get; set; }

        [Required]
        public int CategoryId {  get; set; }
        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;

        public Goal Goal { get; set; } = null!;
    }
}
