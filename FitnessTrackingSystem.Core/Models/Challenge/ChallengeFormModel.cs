using FitnessTrackingSystem.Infrastructure.Data.DataConstants;
using System.ComponentModel.DataAnnotations;

namespace FitnessTrackingSystem.Core.Models.Challenge
{
    public class ChallengeFormModel
    { 

        [Required(ErrorMessage =ErrorMessages.RequiredMessage)]
        [StringLength(ChallengeDataConstants.MaxChallengeTitleLength,
            MinimumLength = ChallengeDataConstants.MinChallengeTitleLength,
            ErrorMessage =ErrorMessages.LengthMessage)]
        public string Title { get; set; } = string.Empty;

        [StringLength(ChallengeDataConstants.MaxChallengeDescriptionLength,
            MinimumLength = ChallengeDataConstants.MinChallengeDescriptionLength,
            ErrorMessage = ErrorMessages.LengthMessage)]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = ErrorMessages.RequiredMessage)]
        public string VideoUrl { get; set; } = string.Empty;

        [Required(ErrorMessage = ErrorMessages.RequiredMessage)]
        [Range(
            ChallengeDataConstants.MaxChallengeDuration,
            ChallengeDataConstants.MinChallengeDuration,
            ErrorMessage =ErrorMessages.DurationMessage)]
        public int Duration { get; set; }

        [Required(ErrorMessage = ErrorMessages.RequiredMessage)]
        public DateTime Start { get; set; }

        [Required(ErrorMessage = ErrorMessages.RequiredMessage)]
        public DateTime End { get; set; }
        public int CategoryId { get; set; }
        public IEnumerable<ChallengeCategoryServiceModel> Categories { get; set; }=
            new List<ChallengeCategoryServiceModel>();
    }
}
