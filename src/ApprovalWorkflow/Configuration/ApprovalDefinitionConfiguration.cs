using ApprovalWorkflow.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApprovalWorkflow.Configuration
{
    public class ApprovalDefinitionConfiguration
        : IEntityTypeConfiguration<ApprovalDefinition>
    {
        public void Configure(EntityTypeBuilder<ApprovalDefinition> builder)
        {
            builder.HasKey(property => property.Id);
            builder.Property(property => property.Name)
                .IsRequired()
                .HasMaxLength(150);
            builder.HasMany(property => property.ApprovalSteps);
        }
    }
}
