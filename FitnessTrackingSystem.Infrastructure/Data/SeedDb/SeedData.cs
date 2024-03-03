using FitnessTrackingSystem.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;

namespace FitnessTrackingSystem.Infrastructure.Data.SeedDb
{
    internal class SeedData
    {
        public Category Category1 { get; set; }
        public Category Category2 { get; set; }
        public Category Category3 { get; set; }
        public IdentityUser TrainerUser { get; set; }
        public IdentityUser GuestUser { get; set; }
        public Trainer Trainer { get; set; }
        public Challenge FirstChallenge { get; set; }
        public Challenge SecondChallenge { get; set; }
        public Challenge ThirdChallenge { get; set; }

        public SeedData()
        {
            SeedUsers();
            SeedTrainer();
            SeedChallenges();
            SeedCategories();
        }
        private void SeedUsers()
        {
            var hasher = new PasswordHasher<IdentityUser>();

            TrainerUser = new IdentityUser()
            {
                Id = "dea12856-c198-4129-b3f3-b893d8395082",
                UserName = "trainer@mail.com",
                NormalizedUserName = "trainer@mail.com",
                Email = "trainer@mail.com",
                NormalizedEmail = "trainer@mail.com"
            };

            TrainerUser.PasswordHash = hasher.HashPassword(TrainerUser, "trainer123");

            GuestUser = new IdentityUser()
            {
                Id = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                UserName = "guest@mail.com",
                NormalizedUserName = "guest@mail.com",
                Email = "guest@mail.com",
                NormalizedEmail = "guest@mail.com"
            };

            GuestUser.PasswordHash = hasher.HashPassword(TrainerUser, "guest123");
        }
        private void SeedTrainer()
        {
            Trainer = new Trainer()
            {
                Id = 1,
                FullName = "Mariah Wellson",
                PhoneNumber = "+359888888888",
                UserId = TrainerUser.Id,
                ImageUrl = "",
                Rating = 10
            };
        }
        private void SeedCategories()
        {
            Category1 = new Category()
            {
                Id = 1,
                Name = "UpperBody Workout"
            };
            Category2 = new Category()
            {
                Id = 2,
                Name = "LowerBody Workout"
            };
            Category3 = new Category()
            {
                Id = 3,
                Name = "FullBody Workout"
            };
        }
        private void SeedChallenges()
        {
            FirstChallenge = new Challenge()
            {
                Id = 1,
                Title = "Build Your Chest",
                Description = "The best way to build a bigger chest with a strong back",
                Start = DateTime.Now,
                End = DateTime.Now,
                TrainerId = Trainer.Id,
                CategoryId = 1,
            };

            SecondChallenge = new Challenge()
            {
                Id = 2,
                Title = "Pump booty",
                Description = "The challenge is targeted towards women who want to build their booty muscles",
                Start = DateTime.Now,
                End = DateTime.Now,
                TrainerId = Trainer.Id,
                CategoryId = 2,
            };

            ThirdChallenge = new Challenge()
            {
                Id = 3,
                Title = "Intense full-body workout",
                Description = "This is very intense workout for your whole body",
                Start = DateTime.Now,
                End = DateTime.Now,
                TrainerId = Trainer.Id,
                CategoryId = 3,
            };
        }
    }
}
