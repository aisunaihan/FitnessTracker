using FitnessTrackingSystem.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace FitnessTrackingSystem.Infrastructure.Data
{
    public class FitnessTrackerDbContext : IdentityDbContext
    {
        public FitnessTrackerDbContext(DbContextOptions<FitnessTrackerDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChallengeParticipant>()
                .HasKey(cp => new { cp.ParticipantId, cp.ChallengeId });

            modelBuilder.Entity<ChallengeParticipant>()
                .HasOne(cp=>cp.Challenge)
                .WithMany(cp=>cp.ChallengeParticipants)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Challenge>()
                .HasOne<Category>()
                .WithMany(c => c.Challenges)
                .HasForeignKey(c => c.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Activity>()
                .HasOne(a=>a.Category)
                .WithMany(c => c.Activities)
                .HasForeignKey(c => c.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Activity>()
                .HasOne<Member>()
                .WithMany(a=>a.Activities)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Member>()
                .HasMany(m => m.Goals);

            modelBuilder
               .Entity<Category>()
               .HasData(new Category()
               {
                   Id = 1,
                   Name = "UpperBody Workout"
               },
               new Category()
               {
                   Id = 2,
                   Name = "LowerBody Workout"
               },
               new Category()
               {
                   Id = 3,
                   Name = "FullBody Workout"
               },
               new Category()
               {
                   Id = 4,
                   Name = "Core Training"
               },
               new Category{
                   Id = 5,
                   Name = "Cooling Down"
               },
               new Category()
               {
                   Id = 6,
                   Name = "Strength Training"
               },
               new Category()
               {
                   Id = 7,
                   Name = "Stretching"
               },
               new Category()
               {
                   Id = 8,
                   Name = "MultiSport"
               },
               new Category()
               {
                   Id=9,
                   Name="Balance"
               });

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<ChallengeParticipant> ChallengeParticipants { get; set; }
        public DbSet<Challenge> Challenges { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Goal> Goals { get; set; }  
        public DbSet<Member> Members { get; set; }
    }
}
