using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using NETRoadmap.Core.Models;

namespace NETRoadmap.Infrastructure.Configurations
{
    public class TopicConfiguration : IEntityTypeConfiguration<Topic>
    {
        public void Configure(EntityTypeBuilder<Topic> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .ValueGeneratedOnAdd();

            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(255);


            // Navigation properties
            builder.HasMany(p => p.SubTopics)
                .WithOne(c => c.Topic)
                .HasForeignKey(c => c.TopicId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(p => p.Resources)
                .WithOne(c => c.Topic)
                .HasForeignKey(c => c.TopicId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
