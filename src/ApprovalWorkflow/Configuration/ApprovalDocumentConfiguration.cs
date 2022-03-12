using ApprovalWorkflow.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApprovalWorkflow.Configuration
{
    public class ApprovalDocumentConfiguration
        : IEntityTypeConfiguration<ApprovalInstance>
    {
        public void Configure(EntityTypeBuilder<ApprovalInstance> builder)
        {
            builder.HasKey(property => property.Id);
            builder.Property(property => property.InstanceNumber)
                .IsRequired()
                .HasMaxLength(150);
            builder.Property(property => property.Status)
                .IsRequired();
            builder.Property(property => property.Activities)
                .IsRequired();
        }
    }
}
