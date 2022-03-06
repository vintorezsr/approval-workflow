using ApprovalWorkflow.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApprovalWorkflow.Configuration
{
    public class ApprovalHistoryConfiguration
        : IEntityTypeConfiguration<ApprovalHistory>
    {
        public void Configure(EntityTypeBuilder<ApprovalHistory> builder)
        {
            throw new NotImplementedException();
        }
    }
}
