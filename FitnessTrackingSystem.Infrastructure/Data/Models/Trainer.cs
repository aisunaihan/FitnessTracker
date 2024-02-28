using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FitnessTrackingSystem.Infrastructure.Data.DataConstants;

namespace FitnessTrackingSystem.Infrastructure.Data.Models
{
    public class Trainer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(TrainerDataConstants.MaxTrainerFullNameLength)]
        public string FullName { get; set; } = string.Empty;

        [Required]
        [MaxLength(TrainerDataConstants.MaxTrainerPhoneNumLength)]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required]
        public string UserId { get; set; } = string.Empty;

        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;

        public IEnumerable<Activity> Activities { get; set; }=new List<Activity>(); 
    }
}
