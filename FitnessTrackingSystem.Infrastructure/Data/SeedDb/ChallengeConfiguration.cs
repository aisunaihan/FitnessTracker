using FitnessTrackingSystem.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrackingSystem.Infrastructure.Data.SeedDb
{
    internal class ChallengeConfiguration:IEntityTypeConfiguration<Challenge>
    {
        public void Configure(EntityTypeBuilder<Challenge> builder)
        {
            builder
               .HasOne(c => c.Category)
               .WithMany(c => c.Challenges)
               .HasForeignKey(c => c.CategoryId)
               .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(c => c.Trainer)
                .WithMany()
                .HasForeignKey(c => c.TrainerId)
                .OnDelete(DeleteBehavior.Restrict);

            var data = new SeedData();

            builder.HasData(new Challenge[] { data.FirstChallenge, data.SecondChallenge, data.ThirdChallenge });
        }
    }
}
