using FitnessTrackingSystem.Infrastructure.Data.DataConstants;
using FitnessTrackingSystem.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Emit;
using System.Xml.Linq;
using FitnessTrackingSystem.Infrastructure.Data.SeedDb;

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
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new TrainerConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ChallengeConfiguration());

            modelBuilder.Entity<Activity>()
                .HasOne(c => c.Category)
                .WithMany(c => c.Activities)
                .HasForeignKey(c => c.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ChallengeParticipant>()
                .HasKey(cp => new { cp.ParticipantId, cp.ChallengeId });

            modelBuilder.Entity<ChallengeParticipant>()
                .HasOne(cp => cp.Challenge)
                .WithMany(cp => cp.ChallengeParticipants)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<ChallengeParticipant> ChallengeParticipants { get; set; }
        public DbSet<Challenge> Challenges { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Goal> Goals { get; set; }
        public DbSet<Supplies> Supplies { get; set; }

    }
}

