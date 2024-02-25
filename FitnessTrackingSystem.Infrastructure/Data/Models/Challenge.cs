using FitnessTrackingSystem.Infrastructure.Data.DataConstants;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessTrackingSystem.Infrastructure.Data.Models
{
    public class Challenge
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(ChallengeDataConstants.MaxChallengeTitleLength)]
        public string Title { get; set; }=string.Empty;

        [MaxLength(ChallengeDataConstants.MaxChallengeDescriptionLength)]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Range(
            ChallengeDataConstants.MaxChallengeDuration,
            ChallengeDataConstants.MinChallengeDuration)]
        public int Duration { get; set; }

        [Required]
        public DateTime Start { get; set; }

        [Required]
        public DateTime End { get; set; }

        [Required]
        public string CreatorId { get; set; } = string.Empty;

        [ForeignKey(nameof(CreatorId))]
        public IdentityUser Creator { get; set; } = null!;

        [Required]
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;

        public IList<ChallengeParticipant> ChallengeParticipants { get; set; } = new List<ChallengeParticipant>();
    }
}
