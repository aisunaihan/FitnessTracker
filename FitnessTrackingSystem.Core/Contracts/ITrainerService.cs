﻿namespace FitnessTrackingSystem.Core.Contracts
{
    public interface ITrainerService
    {
        Task<bool> ExistsByIdAsync(string userId);

        Task<bool> UserWithPhoneNumberExistsAsync(string phoneNumber);

        Task CreateAsync(string userId, string phoneNumber);
    }
}