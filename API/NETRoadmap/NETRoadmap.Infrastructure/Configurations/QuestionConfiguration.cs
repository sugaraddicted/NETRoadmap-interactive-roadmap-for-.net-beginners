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
    public class QuestionsConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .ValueGeneratedOnAdd();

            builder.Property(c => c.QuestionText)
                .IsRequired()
                .HasMaxLength(255);

            // Navigation properties
            builder.HasMany(p => p.Variants)
                .WithOne(c => c.Question)
                .HasForeignKey(c => c.QuestionId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(p => p.Test)
                .WithMany(t => t.Questions)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
