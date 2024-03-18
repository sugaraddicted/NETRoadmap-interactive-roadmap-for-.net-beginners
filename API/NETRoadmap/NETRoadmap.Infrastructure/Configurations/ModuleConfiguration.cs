using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NETRoadmap.Core.Models;

namespace NETRoadmap.Infrastructure.Configurations
{
    public class ModuleConfiguration : IEntityTypeConfiguration<Module>
    {
        public void Configure(EntityTypeBuilder<Module> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .ValueGeneratedOnAdd();

            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(255);


            // Navigation properties
            builder.HasMany(p => p.Topics)
                .WithOne(c => c.Module)
                .HasForeignKey(c => c.ModuleId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
