using FitnessTrackingSystem.Core.Contracts;
using FitnessTrackingSystem.Core.Models.Challenge;
using FitnessTrackingSystem.Core.Models.Home;
using FitnessTrackingSystem.Infrastructure.Data.Common;
using FitnessTrackingSystem.Infrastructure.Data.Models;
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

        public async Task<IEnumerable<ChallengeCategoryServiceModel>> AllCategoriesAsync()
        {
            return await repository.AllReadOnly<Category>()
                .Select(c=>new ChallengeCategoryServiceModel()
                {
                    Id = c.Id,
                    Name = c.Name,
                })
                .ToListAsync();
        }

        public async Task<bool> CategoryExistsAsync(int categoryId)
        {
            return await repository.AllReadOnly<Category>()
                .AnyAsync(c=>c.Id==categoryId);
        }

        public async Task<int> CreateAsync(ChallengeFormModel model,int trainerId)
        {
            var challenge=new Challenge()
            {
                Title = model.Title,
                Description = model.Description,
                VideoUrl = model.VideoUrl,
                Duration = model.Duration,
                Start=model.Start,
                End=model.End,
                TrainerId=trainerId,
                CategoryId=model.CategoryId
            };

            await repository.AddAsync(challenge);
            await repository.SaveChangesAsync();

            return challenge.Id;
        }

        public async Task<IEnumerable<ChallengeIndexServiceModel>> LastThreeChallengesAsync()
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
