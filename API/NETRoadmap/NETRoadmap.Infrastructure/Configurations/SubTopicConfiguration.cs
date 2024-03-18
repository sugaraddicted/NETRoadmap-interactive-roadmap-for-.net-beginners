using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NETRoadmap.Core.Models;

namespace NETRoadmap.Infrastructure.Configurations
{
    public class SubTopicConfiguration : IEntityTypeConfiguration<SubTopic>
    {
        public void Configure(EntityTypeBuilder<SubTopic> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .ValueGeneratedOnAdd();

            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(255);

            // Navigation properties
            builder.HasMany(p => p.SubResources)
                .WithOne(c => c.SubTopic)
                .HasForeignKey(c => c.SubTopicId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(p => p.Test)
                .WithOne(t => t.SubTopic);


            builder.HasOne(p => p.Topic)
                .WithMany(t => t.SubTopics)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
