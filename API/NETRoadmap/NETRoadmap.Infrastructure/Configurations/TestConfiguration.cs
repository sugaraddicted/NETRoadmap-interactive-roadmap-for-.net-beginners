using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using NETRoadmap.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETRoadmap.Infrastructure.Configurations
{
    public class TestConfiguration : IEntityTypeConfiguration<Test>
    {
        public void Configure(EntityTypeBuilder<Test> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .ValueGeneratedOnAdd();

            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(255);

            // Navigation properties
            builder.HasMany(p => p.Questions)
                .WithOne(c => c.Test)
                .HasForeignKey(c => c.TestId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(p => p.SubTopic)
                .WithOne(t => t.Test)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
