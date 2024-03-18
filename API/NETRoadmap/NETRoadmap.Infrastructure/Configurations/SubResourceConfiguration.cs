using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using NETRoadmap.Core.Models;

namespace NETRoadmap.Infrastructure.Configurations
{
    public class SubResourceConfiguration : IEntityTypeConfiguration<SubResource>
    {
        public void Configure(EntityTypeBuilder<SubResource> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .ValueGeneratedOnAdd();

            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(255);

            // Navigation properties
            builder.HasOne(p => p.SubTopic)
                .WithMany(t => t.SubResources)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
