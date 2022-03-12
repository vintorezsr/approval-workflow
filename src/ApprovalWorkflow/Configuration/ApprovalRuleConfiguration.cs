using ApprovalWorkflow.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApprovalWorkflow.Configuration
{
    public class ApprovalRuleConfiguration
        : IEntityTypeConfiguration<ApprovalRule>
    {
        public void Configure(EntityTypeBuilder<ApprovalRule> builder)
        {
            builder.HasKey(property => property.Id);
        }
    }
}
