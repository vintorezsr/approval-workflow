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
            throw new NotImplementedException();
        }
    }
}
