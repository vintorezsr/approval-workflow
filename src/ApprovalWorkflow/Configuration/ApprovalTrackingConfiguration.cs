using ApprovalWorkflow.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApprovalWorkflow.Configuration
{
    public class ApprovalTrackingConfiguration
        : IEntityTypeConfiguration<ApprovalTracking>
    {
        public void Configure(EntityTypeBuilder<ApprovalTracking> builder)
        {
            throw new NotImplementedException();
        }
    }
}
