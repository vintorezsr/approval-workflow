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
            throw new NotImplementedException();
        }
    }
}
