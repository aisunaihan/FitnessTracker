using FitnessTrackingSystem.Core.Contracts;
using FitnessTrackingSystem.Core.Models.Home;
using FitnessTrackingSystem.Infrastructure.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace FitnessTrackingSystem.Core.Services
{
    public class ChallengeService : IChallengeService
    {
        private readonly IRepository repository;

        public ChallengeService(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task<IEnumerable<ChallengeIndexServiceModel>> LastThreeChallenges()
        {
            return await repository
                .AllReadOnly<Infrastructure.Data.Models.Challenge>()
                .OrderByDescending(c => c.Id)
                .Take(3)
                .Select(c => new ChallengeIndexServiceModel()
                {
                    Id = c.Id,
                    Title = c.Title,
                    VideoUrl = c.VideoUrl,
                })
                .ToListAsync();
        }
    }
}
