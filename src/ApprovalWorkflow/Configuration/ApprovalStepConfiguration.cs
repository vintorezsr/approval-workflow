using ApprovalWorkflow.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApprovalWorkflow.Configuration
{
    public class ApprovalStepConfiguration
        : IEntityTypeConfiguration<ApprovalStep>
    {
        public void Configure(EntityTypeBuilder<ApprovalStep> builder)
        {
            throw new NotImplementedException();
        }
    }
}
