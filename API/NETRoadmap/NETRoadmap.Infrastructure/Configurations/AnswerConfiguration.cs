using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using NETRoadmap.Core.Models;

namespace NETRoadmap.Infrastructure.Configurations
{
    public class AnswerConfiguration : IEntityTypeConfiguration<Answer>
    {
        public void Configure(EntityTypeBuilder<Answer> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .ValueGeneratedOnAdd();

            builder.Property(c => c.AnswerText)
                .IsRequired()
                .HasMaxLength(255);

            // Navigation properties
            builder.HasOne(p => p.Question)
                .WithMany(t => t.Variants)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
