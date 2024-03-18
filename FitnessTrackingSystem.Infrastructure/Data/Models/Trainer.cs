using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FitnessTrackingSystem.Infrastructure.Data.DataConstants;
using Microsoft.EntityFrameworkCore;

namespace FitnessTrackingSystem.Infrastructure.Data.Models
{
    [Index(nameof(PhoneNumber),IsUnique =true)]
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

        public string ImageUrl { get; set; } = string.Empty;

        public int Rating {  get; set; }

        public IEnumerable<Challenge> Challenges { get; set; } = new List<Challenge>();
        public IEnumerable<Activity> Activities { get; set; }=new List<Activity>(); 
    }
}
