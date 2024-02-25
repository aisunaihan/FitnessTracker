using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessTrackingSystem.Infrastructure.Data.Models
{
    public class ChallengeParticipant
    {
        [Required]
        public string ParticipantId { get; set; } = string.Empty;

        [ForeignKey(nameof(ParticipantId))]
        public IdentityUser Participant { get; set; } = null!;

        [Required]
        public int ChallengeId { get; set; }

        [ForeignKey(nameof(ChallengeId))]
        public Challenge Challenge { get; set; } = null!;
    }
}
