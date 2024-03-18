using FitnessTrackingSystem.Core.Models.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrackingSystem.Core.Contracts.Challenge
{
    public interface IChallengeService
    {
        Task<IEnumerable<ChallengeIndexServiceModel>> LastThreeChallenges();
    }
}
