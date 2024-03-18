
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using NETRoadmap.Core.Models;

namespace NETRoadmap.Infrastructure.Configurations
{
    public class ResourceConfiguration : IEntityTypeConfiguration<Resource>
    {
        public void Configure(EntityTypeBuilder<Resource> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .ValueGeneratedOnAdd();

            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(255);

            // Navigation properties
            builder.HasOne(p => p.Topic)
                .WithMany(t => t.Resources)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
