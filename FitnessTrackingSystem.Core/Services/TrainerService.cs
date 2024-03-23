using FitnessTrackingSystem.Core.Contracts;
using FitnessTrackingSystem.Infrastructure.Data.Common;
using FitnessTrackingSystem.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrackingSystem.Core.Services
{
    public class TrainerService : ITrainerService
    {
        private readonly IRepository repository;

        public TrainerService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task CreateAsync(string userId,string fullName, string phoneNumber, string imageUrl)
        {
            await repository.AddAsync(new Trainer()
            {
                UserId= userId,
                FullName= fullName,
                PhoneNumber= phoneNumber,
                ImageUrl= imageUrl
            });

            await repository.SaveChangesAsync();
        }

        public async Task<bool> ExistsByIdAsync(string userId)
        {
            return await repository.AllReadOnly<Trainer>()
                .AnyAsync(t=>t.UserId == userId);   
        }

        public async Task<int?> GetTrainerIdAsync(string userId)
        {
            return (await repository.AllReadOnly<Trainer>()
                .FirstOrDefaultAsync(t=>t.UserId == userId))?.Id;
        }

        public async Task<bool> UserWithPhoneNumberExistsAsync(string phoneNumber)
        {
            return await repository.AllReadOnly<Trainer>()
                .AnyAsync (t=>t.PhoneNumber == phoneNumber);
        }
    }
}
