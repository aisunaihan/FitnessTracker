using FitnessTrackingSystem.Infrastructure.Data.DataConstants;
using System.ComponentModel.DataAnnotations;

namespace FitnessTrackingSystem.Infrastructure.Data.Models
{
    public class Goal
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(GoalDataConstants.MaxGoalNameLength)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(GoalDataConstants.MaxGoalDescriptionLength)]
        public string Description { get; set; } = string.Empty;

        [Required]
        public bool IsCompleted { get; set; }
    }
}
