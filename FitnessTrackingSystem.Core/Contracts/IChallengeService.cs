using FitnessTrackingSystem.Core.Models.Challenge;
using FitnessTrackingSystem.Core.Models.Home;

namespace FitnessTrackingSystem.Core.Contracts
{
    public interface IChallengeService
    {
        Task<IEnumerable<ChallengeIndexServiceModel>> LastThreeChallengesAsync();

        Task<IEnumerable<ChallengeCategoryServiceModel>> AllCategoriesAsync();

        Task<bool> CategoryExistsAsync(int categoryId);
        Task<int> CreateAsync(ChallengeFormModel model,int trainerId);
    }
}
